namespace dft
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addition = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraction = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplication = new System.Windows.Forms.ToolStripMenuItem();
            this.division = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expressionTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wTB = new System.Windows.Forms.TextBox();
            this.aTB = new System.Windows.Forms.TextBox();
            this.nTB = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panelDFT = new System.Windows.Forms.Panel();
            this.no = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.chose = new System.Windows.Forms.Label();
            this.chooseGraph = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDFT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem7,
            this.toolStripMenuItem13});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem1.Text = "System";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(135, 26);
            this.exit.Text = "Wyjdź";
            this.exit.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItem,
            this.addition,
            this.subtraction,
            this.multiplication,
            this.division});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem7.Text = "Operacje";
            // 
            // addItem
            // 
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(173, 26);
            this.addItem.Text = "Dodaj wykres";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // addition
            // 
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(173, 26);
            this.addition.Text = "Dodaj";
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(173, 26);
            this.subtraction.Text = "Odejmij";
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(173, 26);
            this.multiplication.Text = "Mnóż";
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(173, 26);
            this.division.Text = "Dziel";
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(121, 24);
            this.toolStripMenuItem13.Text = "Przekształcenia";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem14.Text = "DFT";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(114, 26);
            this.toolStripMenuItem15.Text = "IDFT";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem15_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.expressionTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.wTB);
            this.panel1.Controls.Add(this.aTB);
            this.panel1.Controls.Add(this.nTB);
            this.panel1.Controls.Add(this.w);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.n);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.add);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 389);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // expressionTB
            // 
            this.expressionTB.Location = new System.Drawing.Point(312, 203);
            this.expressionTB.Name = "expressionTB";
            this.expressionTB.Size = new System.Drawing.Size(200, 22);
            this.expressionTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wzór";
            // 
            // wTB
            // 
            this.wTB.Location = new System.Drawing.Point(312, 154);
            this.wTB.Name = "wTB";
            this.wTB.Size = new System.Drawing.Size(100, 22);
            this.wTB.TabIndex = 7;
            this.wTB.Text = "3";
            // 
            // aTB
            // 
            this.aTB.Location = new System.Drawing.Point(312, 105);
            this.aTB.Name = "aTB";
            this.aTB.Size = new System.Drawing.Size(100, 22);
            this.aTB.TabIndex = 6;
            this.aTB.Text = "3";
            // 
            // nTB
            // 
            this.nTB.Location = new System.Drawing.Point(312, 58);
            this.nTB.Name = "nTB";
            this.nTB.Size = new System.Drawing.Size(100, 22);
            this.nTB.TabIndex = 5;
            this.nTB.Text = "256";
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(218, 154);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(25, 17);
            this.w.TabIndex = 4;
            this.w.Text = "W:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(221, 105);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(21, 17);
            this.a.TabIndex = 3;
            this.a.Text = "A:";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(221, 58);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(22, 17);
            this.n.TabIndex = 2;
            this.n.Text = "N:";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(356, 341);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Cofnij";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(356, 297);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panelDFT
            // 
            this.panelDFT.Controls.Add(this.no);
            this.panelDFT.Controls.Add(this.yes);
            this.panelDFT.Controls.Add(this.chose);
            this.panelDFT.Controls.Add(this.chooseGraph);
            this.panelDFT.Location = new System.Drawing.Point(12, 31);
            this.panelDFT.Name = "panelDFT";
            this.panelDFT.Size = new System.Drawing.Size(780, 389);
            this.panelDFT.TabIndex = 2;
            this.panelDFT.Visible = false;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(354, 286);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 23);
            this.no.TabIndex = 7;
            this.no.Text = "Cofnij";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(354, 240);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 23);
            this.yes.TabIndex = 6;
            this.yes.Text = "Wybierz";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // chose
            // 
            this.chose.AutoSize = true;
            this.chose.Location = new System.Drawing.Point(329, 80);
            this.chose.Name = "chose";
            this.chose.Size = new System.Drawing.Size(119, 17);
            this.chose.TabIndex = 5;
            this.chose.Text = "chose your graph";
            // 
            // chooseGraph
            // 
            this.chooseGraph.FormattingEnabled = true;
            this.chooseGraph.Location = new System.Drawing.Point(265, 123);
            this.chooseGraph.Name = "chooseGraph";
            this.chooseGraph.Size = new System.Drawing.Size(250, 24);
            this.chooseGraph.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 389);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "cofnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "dalej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "wybierz wykres";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(312, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(9, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 389);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "wybierz wykres 2";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(442, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "cofnij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "dalej";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "wybierz wykres 1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(163, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelDFT);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wyznaczanie DFT i IDFT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDFT.ResumeLayout(false);
            this.panelDFT.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem addItem;
        private System.Windows.Forms.ToolStripMenuItem addition;
        private System.Windows.Forms.ToolStripMenuItem subtraction;
        private System.Windows.Forms.ToolStripMenuItem multiplication;
        private System.Windows.Forms.ToolStripMenuItem division;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox wTB;
        private System.Windows.Forms.TextBox aTB;
        private System.Windows.Forms.TextBox nTB;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Panel panelDFT;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Label chose;
        private System.Windows.Forms.ComboBox chooseGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox expressionTB;
        private System.Windows.Forms.Label label4;
    }
}

