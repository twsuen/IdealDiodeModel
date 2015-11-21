using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IdealDiode1
{
    public partial class Form1: Form
    {
        double iL, i0, A, Rs, Rsh;
        double T = 298;
        const double q = 1.60218E-19;
        const double k = 1.38065E-23;
        DataTable IVDataTable = new DataTable();
        DataTable cellDataTable;
        int numSeries = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plotDevice();
        }

        private void plotCellButton_Click(object sender, EventArgs e)
        {
            plotDevice();
        }

        private void plotDevice()
        {
            double startVoltage = Convert.ToDouble(cellStartVoltageTextBox.Text);
            double endVoltage = Convert.ToDouble(cellEndVoltageTextBox.Text);
            double step = roundStep((endVoltage - startVoltage) / 100);
            int numPoints = Convert.ToInt16(Math.Ceiling((endVoltage - startVoltage) / step)) + 1;
            double[] voltage = Enumerable.Range(0, numPoints).Select(v => step * v + startVoltage).ToArray();
            double[] current = new double[voltage.Length];

            if (IVChart.Series.Count > 0 && IVChart.Series[0].Name == "Module")
            {
                clearPlot();
            }

            numSeries++;
            IVDataTable.Columns.Add("Voltage (V) " + numSeries.ToString());
            IVDataTable.Columns.Add("Current (mA/cm^2) " + numSeries.ToString());
            for (int i = 0; i < voltage.Length; i++)
            {
                current[i] = findCurrent(voltage[i]);
                if (i == IVDataTable.Rows.Count)
                {
                    IVDataTable.Rows.Add();
                }
                IVDataTable.Rows[i][2 * numSeries - 2] = voltage[i];
                IVDataTable.Rows[i][2 * numSeries - 1] = current[i];
            }
            IVDataGridView.DataSource = IVDataTable;

            Series s = new Series();
            s.Name = "Device " + numSeries.ToString();
            s.ChartType = SeriesChartType.Line;
            IVChart.Series.Add(s);
            s.Points.DataBindXY(voltage, current);

            IVChart.ChartAreas["IVChartArea"].AxisX.Title = "Voltage (V)";
            IVChart.ChartAreas["IVChartArea"].AxisX.Minimum = startVoltage - 0.1;
            IVChart.ChartAreas["IVChartArea"].AxisX.Maximum = endVoltage;
            IVChart.ChartAreas["IVChartArea"].AxisX.Interval = 0.2;
            IVChart.ChartAreas["IVChartArea"].AxisX.IntervalOffset = 0.1;
            IVChart.ChartAreas["IVChartArea"].AxisY.Title = "Current (mA/cm^2)";
            IVChart.ChartAreas["IVChartArea"].AxisY.Minimum = -5;
            IVChart.ChartAreas["IVChartArea"].AxisY.Maximum = 40;
            IVChart.ChartAreas["IVChartArea"].AxisY.Interval = 10;
            IVChart.ChartAreas["IVChartArea"].AxisY.IntervalOffset = 5;
        }

        private double roundStep(double interval)
        {
            double coefficient = interval / Math.Pow(10, Math.Floor(Math.Log10(interval)));
            if (coefficient > 5)
            {
                return 5 * Math.Pow(10, Math.Floor(Math.Log10(interval)));
            }
            else if (coefficient > 2)
            {
                return 2 * Math.Pow(10, Math.Floor(Math.Log10(interval)));
            }
            else
            {
                return Math.Pow(10, Math.Floor(Math.Log10(interval)));
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            cellDataTable = new DataTable();
            cellDataTable.Columns.Add("jL");
            cellDataTable.Columns.Add("j0");
            cellDataTable.Columns.Add("m");
            cellDataTable.Columns.Add("Rs");
            cellDataTable.Columns.Add("Rsh");
            cellDataGridView.DataSource = null;
            cellDataGridView.DataSource = cellDataTable;
            cellDataGridView.Columns["jL"].Width = 50;
            cellDataGridView.Columns["j0"].Width = 50;
            cellDataGridView.Columns["m"].Width = 50;
            cellDataGridView.Columns["Rs"].Width = 50;
            cellDataGridView.Columns["Rsh"].Width = 50;

            int numCells = Convert.ToInt16(numCellsTextBox.Text);
            for (int i = 0; i < numCells; i++)
            {
                cellDataTable.Rows.Add(Convert.ToDouble(lightCurrentTextBox.Text),
                    Convert.ToDouble(diodeCurrentTextBox.Text),
                    Convert.ToDouble(diodeIdealityTextBox.Text),
                    Convert.ToDouble(seriesResistanceTextBox.Text),
                    Convert.ToDouble(shuntResistanceTextBox.Text));
                cellDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            moduleStartVoltageTextBox.Text = (numCells * Convert.ToDouble(cellStartVoltageTextBox.Text)).ToString();
            moduleEndVoltageTextBox.Text = (numCells * Convert.ToDouble(cellEndVoltageTextBox.Text)).ToString();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["jL"] = Convert.ToDouble(lightCurrentTextBox.Text);
            cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["j0"] = Convert.ToDouble(diodeCurrentTextBox.Text);
            cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["m"] = Convert.ToDouble(diodeIdealityTextBox.Text);
            cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["Rs"] = Convert.ToDouble(seriesResistanceTextBox.Text);
            cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["Rsh"] = Convert.ToDouble(shuntResistanceTextBox.Text);
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            lightCurrentTextBox.Text = cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["jL"].ToString();
            diodeCurrentTextBox.Text = cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["j0"].ToString();
            diodeIdealityTextBox.Text = cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["m"].ToString();
            seriesResistanceTextBox.Text = cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["Rs"].ToString();
            shuntResistanceTextBox.Text = cellDataTable.Rows[cellDataGridView.CurrentCellAddress.Y]["Rsh"].ToString();
        }

        private double findCurrent(double v)
        {
            iL = 1E-3 * Convert.ToDouble(lightCurrentTextBox.Text);
            i0 = Convert.ToDouble(diodeCurrentTextBox.Text);
            A = Convert.ToDouble(diodeIdealityTextBox.Text);
            Rs = Convert.ToDouble(seriesResistanceTextBox.Text);
            Rsh = Convert.ToDouble(shuntResistanceTextBox.Text);

            double iGuess = calculatedCurrent(v, iL);
            if (iL < iGuess)
            {
                return 1E3 * guessCurrent(v, iL, iGuess);
            }
            else
            {
                return 1E3 * guessCurrent(v, iGuess, iL);
            }
        }

        private double guessCurrent(double v, double iMin, double iMax)
        {
            //using (StreamWriter file = new StreamWriter("log.txt", true))
            //    file.WriteLine("{0}\t{1}", iMin, iMax);

            double iMid = (iMin + iMax) / 2;
            if (iMax - iMin < 1E-6)
            {
                return iMid;
            }
            else
            {
                double iCalc = calculatedCurrent(v, iMid);
                if (iCalc > iMid)
                {
                    return guessCurrent(v, iMid, iMax);
                }
                else
                {
                    return guessCurrent(v, iMin, iMid);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearPlot();
        }

        private void clearPlot()
        {
            IVChart.Series.Clear();
            IVDataTable = new DataTable();
            IVDataGridView.DataSource = IVDataTable;
            numSeries = 0;
        }

        private void IVChart_DoubleClick(object sender, EventArgs e)
        {
            clearPlot();
        }

        private double calculatedCurrent(double v, double iGuess)
        {
            return iL - i0 * (Math.Exp(q * (v + iGuess * Rs) / (A * k * T)) - 1) - (v + iGuess * Rs) / Rsh;
        }

        private void plotModuleButton_Click(object sender, EventArgs e)
        {
            spiceModel(true);
            clearPlot();
            readModel();
        }

        private void modelButton_Click(object sender, EventArgs e)
        {
            spiceModel(false);
        }

        private void readModel()
        {
            using (StreamReader file = new StreamReader("DiodeModel.raw"))
            {
                string line;
                Match m;

                do
                {
                    line = file.ReadLine();
                    m = Regex.Match(line, @"No. Variables:\s*(\d+)");
                } while (!m.Success);
                int numVariables = Convert.ToInt16(m.Groups[1].Value);
                int numCells = numVariables - 2;

                line = file.ReadLine();
                m = Regex.Match(line, @"No. Points:\s*(\d+)");
                int numPoints = Convert.ToInt16(m.Groups[1].Value);

                do
                {
                    line = file.ReadLine();
                    m = Regex.Match(line, @"Variables:");
                } while (!m.Success);

                int moduleVoltageIndex = 0;
                int[] cellVoltageIndex = new int[numCells];
                int moduleCurrentIndex = 0;
                for (int j = 0; j < numVariables; j++)
                {
                    line = file.ReadLine();
                    string[] p = line.Split('\t');
                    if (p[2] == "v1")
                    {
                        moduleVoltageIndex = j;
                    }
                    else if (p[2] == "I(V1)")
                    {
                        moduleCurrentIndex = j;
                    }
                    else
                    {
                        m = Regex.Match(line, @"V\(n(\d+)\)");
                        int node = Convert.ToInt16(m.Groups[1].Value);
                        if (node == 2)
                        {
                            cellVoltageIndex[0] = j;
                        }
                        else
                        {
                            cellVoltageIndex[Convert.ToInt16((node - 1) / 2)] = j;
                        }
                    }
                }

                line = file.ReadLine();
                double[,] value = new double[numVariables, numPoints];
                for (int i = 0; i < numPoints; i++)
                {
                    for (int j = 0; j < numVariables; j++)
                    {
                        line = file.ReadLine();
                        string[] p = line.Split('\t');

                        if (j == 0)
                        {
                            value[j, i] = Convert.ToDouble(p[2]);
                        }
                        else
                        {
                            value[j, i] = Convert.ToDouble(p[1]);
                        }
                    }
                }

                double[] moduleVoltage = new double[numPoints];
                double[] moduleCurrent = new double[numPoints];
                double[][] cellVoltage = new double[numCells][];
                for (int j = 0; j < numCells; j++)
                {
                    cellVoltage[j] = new double[numPoints];
                }
                for (int i = 0; i < numPoints; i++)
                {
                    moduleVoltage[i] = value[moduleVoltageIndex, i];
                    moduleCurrent[i] = value[moduleCurrentIndex, i];
                    for (int j = 0; j < numCells - 1; j++)
                    {
                        cellVoltage[j][i] = value[cellVoltageIndex[j], i] - value[cellVoltageIndex[j + 1], i];
                    }
                    cellVoltage[numCells-1][i] = value[cellVoltageIndex[numCells-1], i];
                }

                if (numCells == 5 && cellDataTable.Rows.Count > 5)
                {
                    numCells = 4;
                }
                IVDataTable.Columns.Add("Module Voltage (V)");
                IVDataTable.Columns.Add("Module Current (A)");
                for (int j = 0; j < numCells; j++)
                {
                    IVDataTable.Columns.Add("Cell " + (j + 1).ToString() + " Voltage (V)");
                }
                for (int i = 0; i < numPoints; i++)
                {
                    IVDataTable.Rows.Add(moduleVoltage[i].ToString("G4"), moduleCurrent[i].ToString("G4"));
                    for (int j = 0; j < numCells; j++)
                    {
                        IVDataTable.Rows[i][j + 2] = cellVoltage[j][i].ToString("G4");
                    }
                }
                IVDataGridView.DataSource = IVDataTable;

                Series s = new Series();
                s.Name = "Module";
                s.ChartType = SeriesChartType.Line;
                IVChart.Series.Add(s);
                s.Points.DataBindXY(moduleVoltage, moduleCurrent);

                double minVoltage = 0;
                for (int j = 0; j < numCells; j++)
                {
                    s = new Series();
                    s.Name = "Cell " + (j + 1).ToString();
                    s.ChartType = SeriesChartType.Line;
                    IVChart.Series.Add(s);
                    s.Points.DataBindXY(cellVoltage[j], moduleCurrent);

                    if (cellVoltage[j].Min() < minVoltage)
                    {
                        minVoltage = cellVoltage[j].Min();
                    }
                }

                IVChart.ChartAreas["IVChartArea"].AxisX.Title = "Voltage (V)";
                IVChart.ChartAreas["IVChartArea"].AxisX.Minimum = minVoltage - 0.1;
                IVChart.ChartAreas["IVChartArea"].AxisX.Maximum = moduleVoltage[moduleVoltage.Length - 1] + 0.1;
                IVChart.ChartAreas["IVChartArea"].AxisX.Interval = roundStep((moduleVoltage[moduleVoltage.Length - 1] - moduleVoltage[0]) / 2);
                IVChart.ChartAreas["IVChartArea"].AxisX.IntervalOffset = -minVoltage + 0.1;
                IVChart.ChartAreas["IVChartArea"].AxisY.Title = "Current (A)";
                IVChart.ChartAreas["IVChartArea"].AxisY.Minimum = -0.5;
                IVChart.ChartAreas["IVChartArea"].AxisY.Maximum = Math.Ceiling(moduleCurrent[0]);
                IVChart.ChartAreas["IVChartArea"].AxisY.Interval = roundStep(moduleCurrent[0] / 2);
                IVChart.ChartAreas["IVChartArea"].AxisY.IntervalOffset = 0.5;
            }
        }

        private void spiceModel(bool run)
        {
            int numCells = cellDataTable.Rows.Count;

            //if (File.Exists("DiodeModel.raw"))
            //{
            //    File.Delete("DiodeModel.raw");
            //}

            using (StreamWriter file = new StreamWriter("DiodeModel.asc"))
            {
                file.WriteLine("Version 4");
                file.WriteLine("SHEET 1 880 680");

                file.WriteLine("WIRE 240 0 320 0");
                for (int i = 0; i < numCells; i++)
                {
                    int offset = 160 * i;
                    file.WriteLine("WIRE 0 {0} 80 {0}", offset);
                    file.WriteLine("WIRE 80 {0} 160 {0}", offset);
                    file.WriteLine("WIRE 0 {0} 80 {0}", offset + 80);
                    file.WriteLine("WIRE 80 {0} 160 {0}", offset + 80);
                    file.WriteLine("WIRE 80 {0} 80 {1}", offset + 64, offset + 80);
                    if (i < numCells - 1)
                    {
                        file.WriteLine("WIRE 160 {0} 240 {0}", offset + 80);
                        file.WriteLine("WIRE 240 {0} 240 {1}", offset + 80, offset + 160);
                    }
                    else
                    {
                        file.WriteLine("WIRE 160 {0} 320 {0}", offset + 80);
                        file.WriteLine("WIRE 320 {0} 320 {1}", offset + 80, offset + 96);
                        if (numCells > 1)
                        {
                            file.WriteLine("WIRE 320 80 320 {0}", offset + 80);
                        }
                        file.WriteLine("FLAG 320 {0} 0", offset + 96);
                    }
                }

                double cellArea = Convert.ToDouble(cellAreaTextBox.Text);
                for (int i = 0; i < numCells; i++)
                {
                    int offset = 160 * i;
                    file.WriteLine("SYMBOL current 0 {0} R180", offset + 80);
                    file.WriteLine("WINDOW 0 24 80 Left 2");
                    file.WriteLine("WINDOW 3 24 0 Left 2");
                    file.WriteLine("SYMATTR InstName I{0}", i + 1);
                    file.WriteLine("SYMATTR Value {0}", (cellArea * 1E-3 * Convert.ToDouble(cellDataTable.Rows[i]["jL"])));
                    file.WriteLine("SYMBOL diode 64 {0} R0", offset);
                    file.WriteLine("SYMATTR InstName D{0}", i + 1);
                    file.WriteLine("SYMATTR Value ID{0}", i + 1);
                    file.WriteLine("SYMBOL res 144 {0} R270", offset + 16);
                    file.WriteLine("WINDOW 0 32 16 VTop 2");
                    file.WriteLine("WINDOW 3 32 64 VTop 2");
                    file.WriteLine("SYMATTR InstName Rs{0}", i + 1);
                    file.WriteLine("SYMATTR Value {0}", Convert.ToDouble(cellDataTable.Rows[i]["Rs"]) / cellArea);
                    file.WriteLine("SYMBOL res 144 {0} R0", offset - 16);
                    file.WriteLine("SYMATTR InstName Rsh{0}", i + 1);
                    file.WriteLine("SYMATTR Value {0}", Convert.ToDouble(cellDataTable.Rows[i]["Rsh"]) / cellArea);
                }
                file.WriteLine("SYMBOL voltage 320 -16 R0");
                file.WriteLine("SYMATTR InstName V1");
                file.WriteLine("SYMATTR Value 0");

                for (int i = 0; i < numCells; i++)
                {
                    file.WriteLine("TEXT 480 {0} Left 2 !.model ID{1} D(Is={2} N={3} Tnom=25)", 32 * i, i + 1, cellArea * Convert.ToDouble(cellDataTable.Rows[i]["j0"]), Convert.ToDouble(cellDataTable.Rows[i]["m"]));
                }
                double startVoltage = Convert.ToDouble(moduleStartVoltageTextBox.Text);
                double endVoltage = Convert.ToDouble(moduleEndVoltageTextBox.Text);
                file.WriteLine("TEXT 480 {0} Left 2 !.dc V1 {1} {2} {3}", 32 * numCells, startVoltage, endVoltage, roundStep((endVoltage-startVoltage) / 100));

                if (run)
                {
                    string saveVariables = "";
                    for (int i = 1; i < numCells; i++)
                    {
                        saveVariables = saveVariables + " V(n00" + (2 * i + 1).ToString() + ")";
                    }
                    file.WriteLine("TEXT 480 {0} Left 2 !.save I(V1) V(n002){1}", 32 * (numCells + 1), saveVariables);
                }
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files (x86)\LTC\LTspiceIV\scad3.exe";
            if (run)
            {
                startInfo.Arguments = @"-b -ascii -Run DiodeModel.asc";
            }
            else
            {
                startInfo.Arguments = @"-ascii DiodeModel.asc";
            }
            Process p = Process.Start(startInfo);
            if (run)
            {
                p.WaitForExit();
            }
        }
    }
}
