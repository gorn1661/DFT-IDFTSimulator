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
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAll = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDFT.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.toolStripMenuItem3,
            this.exit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem1.Text = "System";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(135, 26);
            this.load.Text = "Wczytaj";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.saveAll});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 26);
            this.toolStripMenuItem3.Text = "Zapisz";
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(189, 26);
            this.saveItem.Text = "Zapisz obiekt";
            // 
            // saveAll
            // 
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(189, 26);
            this.saveAll.Text = "Zapisz wszystko";
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
            // 
            // subtraction
            // 
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(173, 26);
            this.subtraction.Text = "Odejmij";
            // 
            // multiplication
            // 
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(173, 26);
            this.multiplication.Text = "Mnóż";
            // 
            // division
            // 
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(173, 26);
            this.division.Text = "Dziel";
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wTB);
            this.panel1.Controls.Add(this.aTB);
            this.panel1.Controls.Add(this.nTB);
            this.panel1.Controls.Add(this.w);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.n);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.add);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 389);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
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
            this.w.Location = new System.Drawing.Point(224, 154);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 452);
            this.Controls.Add(this.panelDFT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Okno główne";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDFT.ResumeLayout(false);
            this.panelDFT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem saveAll;
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
    }
}

