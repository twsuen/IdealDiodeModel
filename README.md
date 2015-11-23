# IdealDiodeModel
Ideal diode model of solar cells in a module.

# Project Description
This project is a code demo I created over the course of several days for an interview at a solar company.

There are two main components to the GUI.  The top half of the form allows the user to enter the area-normalized diode parameters of a given solar cell.  [Here](http://www.pveducation.org/pvcdrom/solar-cell-operation/ideality-factor) is the equation for the ideal diode model used in solar cells.  [Series resistance](http://www.pveducation.org/pvcdrom/solar-cell-operation/series-resistance) and [shunt resistance](http://www.pveducation.org/pvcdrom/solar-cell-operation/shunt-resistance) are common non-idealities added to a basic circuit model.  Since current appears in the exponential of the diode equation when series resistance is taken into account, the equation can only be solved iteratively.  The right side of the equation is monotonic, though, so it is fairly straightforward to find the current by repeatedly dividing the range in half until the desired precision is reached.  **Plot Device** yields the IV curves and corresponding data to the right.

The bottom half of the form allows the user to simulate the module IV given the diode parameters of each cell.  **Fill** fills **Number of Cells** cells with the diode parameters above.  **Device to Cell** copies the parameters from the top half to the highlighted row and vice versa for **Cell to Device**.  In order to plot the module, [LT Spice](http://www.linear.com/designtools/software/) must be installed with the executable at C:\Program Files (x86)\LTC\LTspiceIV\scad3.exe .  If your version of SPICE is installed elsewhere, this can be changed in the code.  **Model** simply brings up the SPICE model itself with the cells in series.

Unfortunately, there are minor race conditions that I have not resolved.  If there are existing results from a prior simulation, **Plot Module** sometimes plots that data instead of waiting for the latest simulation to finish.  If you notice the graph remaining the same, simply click **Plot Module** again and it should update with the latest results.

As a quick demo of the SPICE model in action, run the program and click **Fill** to create a four-cell module using the default parameters.  If you click **Plot Module**, you'll see that the maximum module current is 5.937 A.  If you change the **jL** of cell 2 to 28 mA/cm^2 instead of 38 mA/cm^2 and plot again, you'll notice that the module current has now been reduced to 4.403 A since the cells are in series.
