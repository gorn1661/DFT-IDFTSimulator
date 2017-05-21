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
    public partial class Form1 : Form
    {
        GraphItem[] tableItems = new GraphItem[1];
        DFT[] dftItem = new DFT[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if(!panel1.Visible)
                panel1.Visible = true;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
                panel1.Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            double[] tabN = new double[int.Parse(nTB.Text)];
            for(int i = 0; i < tabN.Length; i++)
            {
                tabN[i] = (int.Parse(aTB.Text)) * Math.Sin((int.Parse(wTB.Text)) * i);
            }
            if(tableItems.Length == 1)
            {
                tableItems = new GraphItem[tableItems.Length + 1];
                tableItems[0] = new GraphItem(tabN);
                tableItems[0].Text = "Wykres " + 0;
            }
            else
            {
                GraphItem[] t = new GraphItem[tableItems.Length - 1];
                t = tableItems;
                tableItems = new GraphItem[tableItems.Length + 1];
                for(int i = 0; i < t.Length; i++)
                {
                    tableItems[i] = t[i];
                }
                tableItems[tableItems.Length - 2] = new GraphItem(tabN);
                tableItems[tableItems.Length - 2].Text = "Wykres " + (tableItems.Length - 2);
            }
            tableItems[tableItems.Length - 2].Show();
            chooseGraph.Items.Add(tableItems[tableItems.Length - 2].Text);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (!panelDFT.Visible)
                panelDFT.Visible = true;
            if (panel1.Visible)
                panel1.Visible = false;
        }

        private void no_Click(object sender, EventArgs e)
        {
            if (panelDFT.Visible)
                panelDFT.Visible = false;
        }

        private void yes_Click(object sender, EventArgs e)
        {
            double[] tabN = new double[tableItems[chooseGraph.SelectedIndex].lengthTabN()];
            tabN = tableItems[chooseGraph.SelectedIndex].getTabN();

            double[] tabR = new double[tabN.Length];
            double[] tabI = new double[tabN.Length];

            for (int i = 0; i < tabN.Length; i++)
            {
                for(int j = 0; j < tabN.Length; j++)
                {
                    tabR[i] = tabN[j] * Math.Cos(2 * Math.PI * j * i / tabN.Length);
                    tabI[i] = -(tabN[j] * Math.Sin(2 * Math.PI * j * i / tabN.Length));
                }
            }









            ////////////////////////////

            if (dftItem.Length == 1)
            {
                dftItem = new DFT[dftItem.Length + 1];
                dftItem[0] = new DFT(tabR, tabI);
                dftItem[0].Text = "DFT od wykres " + 0;
            }
            else
            {
                DFT[] t = new DFT[dftItem.Length - 1];
                t = dftItem;
                dftItem = new DFT[dftItem.Length + 1];
                for (int i = 0; i < t.Length; i++)
                {
                    dftItem[i] = t[i];
                }
                dftItem[dftItem.Length - 2] = new DFT(tabR, tabI);
                dftItem[dftItem.Length - 2].Text = "DFT od wykres " + (dftItem.Length - 2);
            }
            dftItem[dftItem.Length - 2].Show();

            ////////////////////////////










        }
    }
}
