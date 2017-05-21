using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dft
{
    public partial class DFT : Form
    {
        double[] tabR;
        double[] tabI;

        public DFT(double[] tabR, double[] tabI)
        {
            InitializeComponent();
            this.tabR = new double[tabR.Length];
            this.tabR = tabR;
            this.tabI = new double[tabI.Length];
            this.tabI = tabI;
        }

        private void DFT_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tabR.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, tabR[i]);
                chart2.Series[0].Points.AddXY(i, tabI[i]);
            }
            chart1.Dock = DockStyle.Fill;
            chart2.Dock = DockStyle.Fill;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
    }
}
