namespace IdealDiode1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lightCurrentTextBox = new System.Windows.Forms.TextBox();
            this.lightCurrentLabel = new System.Windows.Forms.Label();
            this.diodeCurrentLabel = new System.Windows.Forms.Label();
            this.diodeCurrentTextBox = new System.Windows.Forms.TextBox();
            this.diodeIdealityLabel = new System.Windows.Forms.Label();
            this.diodeIdealityTextBox = new System.Windows.Forms.TextBox();
            this.seriesResistanceLabel = new System.Windows.Forms.Label();
            this.seriesResistanceTextBox = new System.Windows.Forms.TextBox();
            this.shuntResistanceLabel = new System.Windows.Forms.Label();
            this.shuntResistanceTextBox = new System.Windows.Forms.TextBox();
            this.IVChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IVDataGridView = new System.Windows.Forms.DataGridView();
            this.numCellsLabel = new System.Windows.Forms.Label();
            this.numCellsTextBox = new System.Windows.Forms.TextBox();
            this.modelButton = new System.Windows.Forms.Button();
            this.cellDataGridView = new System.Windows.Forms.DataGridView();
            this.fillButton = new System.Windows.Forms.Button();
            this.deviceToCellButton = new System.Windows.Forms.Button();
            this.cellToDeviceButton = new System.Windows.Forms.Button();
            this.cellAreaTextBox = new System.Windows.Forms.TextBox();
            this.cellAreaLabel = new System.Windows.Forms.Label();
            this.plotModuleButton = new System.Windows.Forms.Button();
            this.plotDeviceButton = new System.Windows.Forms.Button();
            this.cellStartVoltageTextBox = new System.Windows.Forms.TextBox();
            this.cellEndVoltageTextBox = new System.Windows.Forms.TextBox();
            this.moduleEndVoltageTextBox = new System.Windows.Forms.TextBox();
            this.moduleStartVoltageTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.voltageRangeDeviceLabel = new System.Windows.Forms.Label();
            this.voltageRangeModuleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IVChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lightCurrentTextBox
            // 
            this.lightCurrentTextBox.Location = new System.Drawing.Point(158, 12);
            this.lightCurrentTextBox.Name = "lightCurrentTextBox";
            this.lightCurrentTextBox.Size = new System.Drawing.Size(50, 20);
            this.lightCurrentTextBox.TabIndex = 0;
            this.lightCurrentTextBox.Text = "38";
            this.lightCurrentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lightCurrentLabel
            // 
            this.lightCurrentLabel.AutoSize = true;
            this.lightCurrentLabel.Location = new System.Drawing.Point(30, 15);
            this.lightCurrentLabel.Name = "lightCurrentLabel";
            this.lightCurrentLabel.Size = new System.Drawing.Size(122, 13);
            this.lightCurrentLabel.TabIndex = 1;
            this.lightCurrentLabel.Text = "Light Current (mA/cm^2)";
            // 
            // diodeCurrentLabel
            // 
            this.diodeCurrentLabel.AutoSize = true;
            this.diodeCurrentLabel.Location = new System.Drawing.Point(33, 41);
            this.diodeCurrentLabel.Name = "diodeCurrentLabel";
            this.diodeCurrentLabel.Size = new System.Drawing.Size(119, 13);
            this.diodeCurrentLabel.TabIndex = 3;
            this.diodeCurrentLabel.Text = "Diode Current (A/cm^2)";
            // 
            // diodeCurrentTextBox
            // 
            this.diodeCurrentTextBox.Location = new System.Drawing.Point(158, 38);
            this.diodeCurrentTextBox.Name = "diodeCurrentTextBox";
            this.diodeCurrentTextBox.Size = new System.Drawing.Size(50, 20);
            this.diodeCurrentTextBox.TabIndex = 2;
            this.diodeCurrentTextBox.Text = "1E-13";
            this.diodeCurrentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // diodeIdealityLabel
            // 
            this.diodeIdealityLabel.AutoSize = true;
            this.diodeIdealityLabel.Location = new System.Drawing.Point(81, 67);
            this.diodeIdealityLabel.Name = "diodeIdealityLabel";
            this.diodeIdealityLabel.Size = new System.Drawing.Size(71, 13);
            this.diodeIdealityLabel.TabIndex = 5;
            this.diodeIdealityLabel.Text = "Diode Ideality";
            // 
            // diodeIdealityTextBox
            // 
            this.diodeIdealityTextBox.Location = new System.Drawing.Point(158, 64);
            this.diodeIdealityTextBox.Name = "diodeIdealityTextBox";
            this.diodeIdealityTextBox.Size = new System.Drawing.Size(50, 20);
            this.diodeIdealityTextBox.TabIndex = 4;
            this.diodeIdealityTextBox.Text = "1";
            this.diodeIdealityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seriesResistanceLabel
            // 
            this.seriesResistanceLabel.AutoSize = true;
            this.seriesResistanceLabel.Location = new System.Drawing.Point(13, 93);
            this.seriesResistanceLabel.Name = "seriesResistanceLabel";
            this.seriesResistanceLabel.Size = new System.Drawing.Size(139, 13);
            this.seriesResistanceLabel.TabIndex = 7;
            this.seriesResistanceLabel.Text = "Series Resistance (Ω-cm^2)";
            // 
            // seriesResistanceTextBox
            // 
            this.seriesResistanceTextBox.Location = new System.Drawing.Point(158, 90);
            this.seriesResistanceTextBox.Name = "seriesResistanceTextBox";
            this.seriesResistanceTextBox.Size = new System.Drawing.Size(50, 20);
            this.seriesResistanceTextBox.TabIndex = 6;
            this.seriesResistanceTextBox.Text = "1.2";
            this.seriesResistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shuntResistanceLabel
            // 
            this.shuntResistanceLabel.AutoSize = true;
            this.shuntResistanceLabel.Location = new System.Drawing.Point(14, 119);
            this.shuntResistanceLabel.Name = "shuntResistanceLabel";
            this.shuntResistanceLabel.Size = new System.Drawing.Size(138, 13);
            this.shuntResistanceLabel.TabIndex = 9;
            this.shuntResistanceLabel.Text = "Shunt Resistance (Ω-cm^2)";
            // 
            // shuntResistanceTextBox
            // 
            this.shuntResistanceTextBox.Location = new System.Drawing.Point(158, 116);
            this.shuntResistanceTextBox.Name = "shuntResistanceTextBox";
            this.shuntResistanceTextBox.Size = new System.Drawing.Size(50, 20);
            this.shuntResistanceTextBox.TabIndex = 8;
            this.shuntResistanceTextBox.Text = "10000";
            this.shuntResistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IVChart
            // 
            chartArea2.Name = "IVChartArea";
            this.IVChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.IVChart.Legends.Add(legend2);
            this.IVChart.Location = new System.Drawing.Point(334, 12);
            this.IVChart.Name = "IVChart";
            this.IVChart.Size = new System.Drawing.Size(532, 449);
            this.IVChart.TabIndex = 10;
            this.IVChart.Text = "IV";
            this.IVChart.DoubleClick += new System.EventHandler(this.IVChart_DoubleClick);
            // 
            // IVDataGridView
            // 
            this.IVDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.IVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IVDataGridView.Location = new System.Drawing.Point(872, 15);
            this.IVDataGridView.Name = "IVDataGridView";
            this.IVDataGridView.Size = new System.Drawing.Size(201, 446);
            this.IVDataGridView.TabIndex = 11;
            // 
            // numCellsLabel
            // 
            this.numCellsLabel.AutoSize = true;
            this.numCellsLabel.Location = new System.Drawing.Point(13, 198);
            this.numCellsLabel.Name = "numCellsLabel";
            this.numCellsLabel.Size = new System.Drawing.Size(81, 13);
            this.numCellsLabel.TabIndex = 13;
            this.numCellsLabel.Text = "Number of Cells";
            // 
            // numCellsTextBox
            // 
            this.numCellsTextBox.Location = new System.Drawing.Point(100, 195);
            this.numCellsTextBox.Name = "numCellsTextBox";
            this.numCellsTextBox.Size = new System.Drawing.Size(50, 20);
            this.numCellsTextBox.TabIndex = 12;
            this.numCellsTextBox.Text = "4";
            this.numCellsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // modelButton
            // 
            this.modelButton.Location = new System.Drawing.Point(190, 441);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(100, 20);
            this.modelButton.TabIndex = 14;
            this.modelButton.Text = "Model";
            this.modelButton.UseVisualStyleBackColor = true;
            this.modelButton.Click += new System.EventHandler(this.modelButton_Click);
            // 
            // cellDataGridView
            // 
            this.cellDataGridView.AllowUserToAddRows = false;
            this.cellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellDataGridView.Location = new System.Drawing.Point(16, 246);
            this.cellDataGridView.Name = "cellDataGridView";
            this.cellDataGridView.Size = new System.Drawing.Size(312, 162);
            this.cellDataGridView.TabIndex = 15;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(16, 220);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(100, 20);
            this.fillButton.TabIndex = 16;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // deviceToCellButton
            // 
            this.deviceToCellButton.Location = new System.Drawing.Point(122, 220);
            this.deviceToCellButton.Name = "deviceToCellButton";
            this.deviceToCellButton.Size = new System.Drawing.Size(100, 20);
            this.deviceToCellButton.TabIndex = 17;
            this.deviceToCellButton.Text = "Device to Cell";
            this.deviceToCellButton.UseVisualStyleBackColor = true;
            this.deviceToCellButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cellToDeviceButton
            // 
            this.cellToDeviceButton.Location = new System.Drawing.Point(228, 221);
            this.cellToDeviceButton.Name = "cellToDeviceButton";
            this.cellToDeviceButton.Size = new System.Drawing.Size(100, 20);
            this.cellToDeviceButton.TabIndex = 18;
            this.cellToDeviceButton.Text = "Cell to Device";
            this.cellToDeviceButton.UseVisualStyleBackColor = true;
            this.cellToDeviceButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // cellAreaTextBox
            // 
            this.cellAreaTextBox.Location = new System.Drawing.Point(278, 195);
            this.cellAreaTextBox.Name = "cellAreaTextBox";
            this.cellAreaTextBox.Size = new System.Drawing.Size(50, 20);
            this.cellAreaTextBox.TabIndex = 19;
            this.cellAreaTextBox.Text = "156.25";
            this.cellAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cellAreaLabel
            // 
            this.cellAreaLabel.AutoSize = true;
            this.cellAreaLabel.Location = new System.Drawing.Point(223, 198);
            this.cellAreaLabel.Name = "cellAreaLabel";
            this.cellAreaLabel.Size = new System.Drawing.Size(49, 13);
            this.cellAreaLabel.TabIndex = 20;
            this.cellAreaLabel.Text = "Cell Area";
            // 
            // plotModuleButton
            // 
            this.plotModuleButton.Location = new System.Drawing.Point(190, 415);
            this.plotModuleButton.Name = "plotModuleButton";
            this.plotModuleButton.Size = new System.Drawing.Size(100, 20);
            this.plotModuleButton.TabIndex = 21;
            this.plotModuleButton.Text = "Plot Module";
            this.plotModuleButton.UseVisualStyleBackColor = true;
            this.plotModuleButton.Click += new System.EventHandler(this.plotModuleButton_Click);
            // 
            // plotDeviceButton
            // 
            this.plotDeviceButton.Location = new System.Drawing.Point(190, 141);
            this.plotDeviceButton.Name = "plotDeviceButton";
            this.plotDeviceButton.Size = new System.Drawing.Size(100, 20);
            this.plotDeviceButton.TabIndex = 22;
            this.plotDeviceButton.Text = "Plot Device";
            this.plotDeviceButton.UseVisualStyleBackColor = true;
            this.plotDeviceButton.Click += new System.EventHandler(this.plotCellButton_Click);
            // 
            // cellStartVoltageTextBox
            // 
            this.cellStartVoltageTextBox.Location = new System.Drawing.Point(98, 142);
            this.cellStartVoltageTextBox.Name = "cellStartVoltageTextBox";
            this.cellStartVoltageTextBox.Size = new System.Drawing.Size(40, 20);
            this.cellStartVoltageTextBox.TabIndex = 23;
            this.cellStartVoltageTextBox.Text = "0";
            this.cellStartVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cellEndVoltageTextBox
            // 
            this.cellEndVoltageTextBox.Location = new System.Drawing.Point(144, 142);
            this.cellEndVoltageTextBox.Name = "cellEndVoltageTextBox";
            this.cellEndVoltageTextBox.Size = new System.Drawing.Size(40, 20);
            this.cellEndVoltageTextBox.TabIndex = 24;
            this.cellEndVoltageTextBox.Text = "0.8";
            this.cellEndVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // moduleEndVoltageTextBox
            // 
            this.moduleEndVoltageTextBox.Location = new System.Drawing.Point(144, 415);
            this.moduleEndVoltageTextBox.Name = "moduleEndVoltageTextBox";
            this.moduleEndVoltageTextBox.Size = new System.Drawing.Size(40, 20);
            this.moduleEndVoltageTextBox.TabIndex = 26;
            this.moduleEndVoltageTextBox.Text = "3.2";
            this.moduleEndVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // moduleStartVoltageTextBox
            // 
            this.moduleStartVoltageTextBox.Location = new System.Drawing.Point(98, 415);
            this.moduleStartVoltageTextBox.Name = "moduleStartVoltageTextBox";
            this.moduleStartVoltageTextBox.Size = new System.Drawing.Size(40, 20);
            this.moduleStartVoltageTextBox.TabIndex = 25;
            this.moduleStartVoltageTextBox.Text = "0";
            this.moduleStartVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(16, 167);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 20);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // voltageRangeDeviceLabel
            // 
            this.voltageRangeDeviceLabel.AutoSize = true;
            this.voltageRangeDeviceLabel.Location = new System.Drawing.Point(14, 145);
            this.voltageRangeDeviceLabel.Name = "voltageRangeDeviceLabel";
            this.voltageRangeDeviceLabel.Size = new System.Drawing.Size(78, 13);
            this.voltageRangeDeviceLabel.TabIndex = 28;
            this.voltageRangeDeviceLabel.Text = "Voltage Range";
            // 
            // voltageRangeModuleLabel
            // 
            this.voltageRangeModuleLabel.AutoSize = true;
            this.voltageRangeModuleLabel.Location = new System.Drawing.Point(14, 418);
            this.voltageRangeModuleLabel.Name = "voltageRangeModuleLabel";
            this.voltageRangeModuleLabel.Size = new System.Drawing.Size(78, 13);
            this.voltageRangeModuleLabel.TabIndex = 29;
            this.voltageRangeModuleLabel.Text = "Voltage Range";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 470);
            this.Controls.Add(this.voltageRangeModuleLabel);
            this.Controls.Add(this.voltageRangeDeviceLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.moduleEndVoltageTextBox);
            this.Controls.Add(this.moduleStartVoltageTextBox);
            this.Controls.Add(this.cellEndVoltageTextBox);
            this.Controls.Add(this.cellStartVoltageTextBox);
            this.Controls.Add(this.plotDeviceButton);
            this.Controls.Add(this.plotModuleButton);
            this.Controls.Add(this.cellAreaLabel);
            this.Controls.Add(this.cellAreaTextBox);
            this.Controls.Add(this.cellToDeviceButton);
            this.Controls.Add(this.deviceToCellButton);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.cellDataGridView);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.numCellsLabel);
            this.Controls.Add(this.numCellsTextBox);
            this.Controls.Add(this.IVDataGridView);
            this.Controls.Add(this.IVChart);
            this.Controls.Add(this.shuntResistanceLabel);
            this.Controls.Add(this.shuntResistanceTextBox);
            this.Controls.Add(this.seriesResistanceLabel);
            this.Controls.Add(this.seriesResistanceTextBox);
            this.Controls.Add(this.diodeIdealityLabel);
            this.Controls.Add(this.diodeIdealityTextBox);
            this.Controls.Add(this.diodeCurrentLabel);
            this.Controls.Add(this.diodeCurrentTextBox);
            this.Controls.Add(this.lightCurrentLabel);
            this.Controls.Add(this.lightCurrentTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IVChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lightCurrentTextBox;
        private System.Windows.Forms.Label lightCurrentLabel;
        private System.Windows.Forms.Label diodeCurrentLabel;
        private System.Windows.Forms.TextBox diodeCurrentTextBox;
        private System.Windows.Forms.Label diodeIdealityLabel;
        private System.Windows.Forms.TextBox diodeIdealityTextBox;
        private System.Windows.Forms.Label seriesResistanceLabel;
        private System.Windows.Forms.TextBox seriesResistanceTextBox;
        private System.Windows.Forms.Label shuntResistanceLabel;
        private System.Windows.Forms.TextBox shuntResistanceTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart IVChart;
        private System.Windows.Forms.DataGridView IVDataGridView;
        private System.Windows.Forms.Label numCellsLabel;
        private System.Windows.Forms.TextBox numCellsTextBox;
        private System.Windows.Forms.Button modelButton;
        private System.Windows.Forms.DataGridView cellDataGridView;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button deviceToCellButton;
        private System.Windows.Forms.Button cellToDeviceButton;
        private System.Windows.Forms.TextBox cellAreaTextBox;
        private System.Windows.Forms.Label cellAreaLabel;
        private System.Windows.Forms.Button plotModuleButton;
        private System.Windows.Forms.Button plotDeviceButton;
        private System.Windows.Forms.TextBox cellStartVoltageTextBox;
        private System.Windows.Forms.TextBox cellEndVoltageTextBox;
        private System.Windows.Forms.TextBox moduleEndVoltageTextBox;
        private System.Windows.Forms.TextBox moduleStartVoltageTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label voltageRangeDeviceLabel;
        private System.Windows.Forms.Label voltageRangeModuleLabel;
    }
}

