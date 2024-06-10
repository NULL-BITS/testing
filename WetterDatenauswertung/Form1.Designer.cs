namespace WetterDatenauswertung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btHinzufügen = new Button();
            tbLuftfeuchtigkeit = new TextBox();
            tbTemperatur = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbDate = new TextBox();
            panel2 = new Panel();
            tbAuswertung = new TextBox();
            lbAusgabe = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btHinzufügen);
            panel1.Controls.Add(tbLuftfeuchtigkeit);
            panel1.Controls.Add(tbTemperatur);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbDate);
            panel1.Location = new Point(12, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 111);
            panel1.TabIndex = 0;
            // 
            // btHinzufügen
            // 
            btHinzufügen.Location = new Point(3, 80);
            btHinzufügen.Name = "btHinzufügen";
            btHinzufügen.Size = new Size(185, 23);
            btHinzufügen.TabIndex = 1;
            btHinzufügen.Text = "Hinzufügen";
            btHinzufügen.UseVisualStyleBackColor = true;
            btHinzufügen.Click += btHinzufügen_Click;
            // 
            // tbLuftfeuchtigkeit
            // 
            tbLuftfeuchtigkeit.Location = new Point(100, 51);
            tbLuftfeuchtigkeit.Name = "tbLuftfeuchtigkeit";
            tbLuftfeuchtigkeit.Size = new Size(88, 23);
            tbLuftfeuchtigkeit.TabIndex = 1;
            // 
            // tbTemperatur
            // 
            tbTemperatur.Location = new Point(100, 26);
            tbTemperatur.Name = "tbTemperatur";
            tbTemperatur.Size = new Size(88, 23);
            tbTemperatur.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 54);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Luftfeuchtigkeit";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "temperatur";
            // 
            // tbDate
            // 
            tbDate.Location = new Point(3, 3);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(185, 23);
            tbDate.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbAuswertung);
            panel2.Location = new Point(224, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 410);
            panel2.TabIndex = 1;
            // 
            // tbAuswertung
            // 
            tbAuswertung.Location = new Point(3, 3);
            tbAuswertung.Multiline = true;
            tbAuswertung.Name = "tbAuswertung";
            tbAuswertung.ReadOnly = true;
            tbAuswertung.Size = new Size(194, 404);
            tbAuswertung.TabIndex = 2;
            // 
            // lbAusgabe
            // 
            lbAusgabe.FormattingEnabled = true;
            lbAusgabe.ItemHeight = 15;
            lbAusgabe.Location = new Point(439, 12);
            lbAusgabe.Name = "lbAusgabe";
            lbAusgabe.Size = new Size(349, 409);
            lbAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbAusgabe);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbLuftfeuchtigkeit;
        private TextBox tbTemperatur;
        private Label label2;
        private Label label1;
        private TextBox tbDate;
        private Button btHinzufügen;
        private Panel panel2;
        private TextBox tbAuswertung;
        private ListBox lbAusgabe;
    }
}
