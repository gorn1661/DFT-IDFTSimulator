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
        char? dz = null;

        public Form1()
        {
            InitializeComponent();
            expressionTB.Text = "A*Math.sin(W*N)";
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
            if (panel2.Visible)
                panel2.Visible = false;
            if (panel3.Visible)
                panel3.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
                panel1.Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";

            double[] tabN = new double[int.Parse(nTB.Text)];
            string A = "A=" + aTB.Text + ";";
            string W = "W=" + wTB.Text + ";";

            for(int i = 0; i < tabN.Length; i++)
                try
                {
                    string N = "N=" + i + ";";
                    tabN[i] = obj.Eval(N + A + W + expressionTB.Text);
                }
                catch
                {
                    MessageBox.Show("Expression error");
                }
                
            if (tableItems.Length == 1)
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
            //comboBox1.Items.Add(tableItems[tableItems.Length - 2].Text);
            comboBox2.Items.Add(tableItems[tableItems.Length - 2].Text);
            comboBox3.Items.Add(tableItems[tableItems.Length - 2].Text);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (!panelDFT.Visible)
                panelDFT.Visible = true;
            if (panel1.Visible)
                panel1.Visible = false;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panel3.Visible)
                panel3.Visible = false;
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
                tabR[i] = 0;
                tabI[i] = 0;
                for(int j = 0; j < tabN.Length-1; j++)
                {
                    tabR[i] += tabN[j] * Math.Cos(2 * Math.PI * j * i / tabN.Length);
                    tabI[i] += -(tabN[j] * Math.Sin(2 * Math.PI * j * i / tabN.Length));
                }
            }









            ////////////////////////////

            if (dftItem.Length == 1)
            {
                dftItem = new DFT[dftItem.Length + 1];
                dftItem[0] = new DFT(tabR, tabI);
                dftItem[0].Text = "DFT od " + tableItems[chooseGraph.SelectedIndex].Text;
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
                dftItem[dftItem.Length - 2].Text = "DFT od " + tableItems[chooseGraph.SelectedIndex].Text/*(dftItem.Length - 2)*/;
            }
            dftItem[dftItem.Length - 2].Show();

            ////////////////////////////










        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
                panel2.Visible = false;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (!panel2.Visible)
                panel2.Visible = true;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
            if (panel1.Visible)
                panel1.Visible = false;
            if (panel3.Visible)
                panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] tabN = new double[tableItems[comboBox1.SelectedIndex].lengthTabN()];
            tabN = tableItems[comboBox1.SelectedIndex].getTabN();

            double[] tabR = new double[tabN.Length];
            double[] tabI = new double[tabN.Length];

            for (int i = 0; i < tabN.Length; i++)
            {
                tabR[i] = 0;
                tabI[i] = 0;
                for (int j = 1; j < tabN.Length-1; j++)
                {
                    tabR[i] += tabN[j] * Math.Cos(2 * Math.PI * j * i / tabN.Length);
                    tabI[i] += tabN[j] * Math.Sin(2 * Math.PI * j * i / tabN.Length);
                }
                tabR[i] = (tabR[i] * (1 / tabN.Length));
                tabI[i] *= (double)(1 / tabN.Length);
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

        private void addition_Click(object sender, EventArgs e)
        {
            if (!panel3.Visible)
                panel3.Visible = true;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
            if (panel1.Visible)
                panel1.Visible = false;
            dz = '+';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
                panel3.Visible = false;
        }

        int i = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            double[] tabN1 = new double[tableItems[comboBox2.SelectedIndex].lengthTabN()];
            tabN1 = tableItems[comboBox2.SelectedIndex].getTabN();
            double[] tabN2 = new double[tableItems[comboBox3.SelectedIndex].lengthTabN()];
            tabN2 = tableItems[comboBox3.SelectedIndex].getTabN();
            double[] tabN = new double[tableItems[comboBox2.SelectedIndex].lengthTabN()];

            try
            {

                switch (dz)
                {
                    case '+':
                        for (int i = 0; i < tabN1.Length; i++)
                        {
                            tabN[i] = tabN1[i] + tabN2[i];
                        }
                        break;
                    case '-':
                        for (int i = 0; i < tabN1.Length; i++)
                        {
                            tabN[i] = tabN1[i] - tabN2[i];
                        }
                        break;
                    case '*':
                        for (int i = 0; i < tabN1.Length; i++)
                        {
                            tabN[i] = tabN1[i] * tabN2[i];
                        }
                        break;
                    case '/':
                        for (int i = 0; i < tabN1.Length; i++)
                        {
                            tabN[i] = tabN1[i] / tabN2[i];
                        }
                        break;
                }
                

                if (tableItems.Length == 1)
                {
                    tableItems = new GraphItem[tableItems.Length + 1];
                    tableItems[0] = new GraphItem(tabN);
                    tableItems[0].Text = "Wykres wynik " + i + " z " + 
                        tableItems[comboBox2.SelectedIndex].Text + 
                        tableItems[comboBox3.SelectedIndex].Text;
                    i++;
                }
                else
                {
                    GraphItem[] t = new GraphItem[tableItems.Length - 1];
                    t = tableItems;
                    tableItems = new GraphItem[tableItems.Length + 1];
                    for (int i = 0; i < t.Length; i++)
                    {
                        tableItems[i] = t[i];
                    }
                    tableItems[tableItems.Length - 2] = new GraphItem(tabN);
                    tableItems[tableItems.Length - 2].Text = "Wykres wynik " + i;
                    i++;
                }
                tableItems[tableItems.Length - 2].Show();
                chooseGraph.Items.Add(tableItems[tableItems.Length - 2].Text);
                //comboBox1.Items.Add(tableItems[tableItems.Length - 2].Text);
                comboBox2.Items.Add(tableItems[tableItems.Length - 2].Text);
                comboBox3.Items.Add(tableItems[tableItems.Length - 2].Text);

            }
            catch(Exception c)
            {
                
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (!panel3.Visible)
                panel3.Visible = true;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
            if (panel1.Visible)
                panel1.Visible = false;
            dz = '-';
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (!panel3.Visible)
                panel3.Visible = true;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
            if (panel1.Visible)
                panel1.Visible = false;
            dz = '*';
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (!panel3.Visible)
                panel3.Visible = true;
            if (panel2.Visible)
                panel2.Visible = false;
            if (panelDFT.Visible)
                panelDFT.Visible = false;
            if (panel1.Visible)
                panel1.Visible = false;
            dz = '/';
        }
    }
}
