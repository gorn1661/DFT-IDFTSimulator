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
    public partial class GraphItem : Form
    {
        double[] tabN;

        public GraphItem(double[] tabN)
        {
            InitializeComponent();
            this.tabN = new double[tabN.Length];
            this.tabN = tabN;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < tabN.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, tabN[i]);
            }
            chart1.Dock = DockStyle.Fill;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        public double[] getTabN()
        {
            return tabN;
        }

        public int lengthTabN()
        {
            return tabN.Length;
        }
    }
}
