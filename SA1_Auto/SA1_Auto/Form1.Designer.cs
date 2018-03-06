namespace SA1_Auto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_farbe = new System.Windows.Forms.ComboBox();
            this.txtb_marke = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txtb_verbrauch = new System.Windows.Forms.TextBox();
            this.txtb_tankgr = new System.Windows.Forms.TextBox();
            this.txtb_ps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_TankenFahren = new System.Windows.Forms.Panel();
            this.btn_fahren = new System.Windows.Forms.Button();
            this.btn_tanken = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtb_tanken = new System.Windows.Forms.TextBox();
            this.txtb_fahren = new System.Windows.Forms.TextBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtb_ausgabe = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel_TankenFahren.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_farbe
            // 
            this.cmb_farbe.FormattingEnabled = true;
            this.cmb_farbe.Items.AddRange(new object[] {
            "Rot",
            "Blau",
            "Schwarz",
            "Silber",
            "Weiß"});
            this.cmb_farbe.Location = new System.Drawing.Point(101, 63);
            this.cmb_farbe.Name = "cmb_farbe";
            this.cmb_farbe.Size = new System.Drawing.Size(121, 21);
            this.cmb_farbe.TabIndex = 0;
            this.cmb_farbe.Text = "Rot";
            // 
            // txtb_marke
            // 
            this.txtb_marke.Location = new System.Drawing.Point(101, 37);
            this.txtb_marke.Name = "txtb_marke";
            this.txtb_marke.Size = new System.Drawing.Size(121, 20);
            this.txtb_marke.TabIndex = 1;
            this.txtb_marke.Text = "Porsche";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(340, 87);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(121, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Auto erstellen";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtb_verbrauch
            // 
            this.txtb_verbrauch.Location = new System.Drawing.Point(340, 63);
            this.txtb_verbrauch.Name = "txtb_verbrauch";
            this.txtb_verbrauch.Size = new System.Drawing.Size(121, 20);
            this.txtb_verbrauch.TabIndex = 3;
            this.txtb_verbrauch.Text = "7";
            // 
            // txtb_tankgr
            // 
            this.txtb_tankgr.Location = new System.Drawing.Point(340, 37);
            this.txtb_tankgr.Name = "txtb_tankgr";
            this.txtb_tankgr.Size = new System.Drawing.Size(121, 20);
            this.txtb_tankgr.TabIndex = 4;
            this.txtb_tankgr.Text = "40";
            // 
            // txtb_ps
            // 
            this.txtb_ps.Location = new System.Drawing.Point(101, 90);
            this.txtb_ps.Name = "txtb_ps";
            this.txtb_ps.Size = new System.Drawing.Size(121, 20);
            this.txtb_ps.TabIndex = 5;
            this.txtb_ps.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marke :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tankgröße :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PS :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Farbe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Verbrauch :";
            // 
            // panel_TankenFahren
            // 
            this.panel_TankenFahren.Controls.Add(this.btn_fahren);
            this.panel_TankenFahren.Controls.Add(this.btn_tanken);
            this.panel_TankenFahren.Controls.Add(this.label11);
            this.panel_TankenFahren.Controls.Add(this.label8);
            this.panel_TankenFahren.Controls.Add(this.label9);
            this.panel_TankenFahren.Controls.Add(this.label10);
            this.panel_TankenFahren.Controls.Add(this.progressBar1);
            this.panel_TankenFahren.Controls.Add(this.txtb_tanken);
            this.panel_TankenFahren.Controls.Add(this.txtb_fahren);
            this.panel_TankenFahren.Enabled = false;
            this.panel_TankenFahren.Location = new System.Drawing.Point(44, 266);
            this.panel_TankenFahren.Name = "panel_TankenFahren";
            this.panel_TankenFahren.Size = new System.Drawing.Size(266, 159);
            this.panel_TankenFahren.TabIndex = 13;
            // 
            // btn_fahren
            // 
            this.btn_fahren.Location = new System.Drawing.Point(160, 119);
            this.btn_fahren.Name = "btn_fahren";
            this.btn_fahren.Size = new System.Drawing.Size(103, 23);
            this.btn_fahren.TabIndex = 11;
            this.btn_fahren.Text = "fahren";
            this.btn_fahren.UseVisualStyleBackColor = true;
            this.btn_fahren.Click += new System.EventHandler(this.btn_fahren_Click);
            // 
            // btn_tanken
            // 
            this.btn_tanken.Location = new System.Drawing.Point(160, 17);
            this.btn_tanken.Name = "btn_tanken";
            this.btn_tanken.Size = new System.Drawing.Size(103, 23);
            this.btn_tanken.TabIndex = 12;
            this.btn_tanken.Text = "tanken";
            this.btn_tanken.UseVisualStyleBackColor = true;
            this.btn_tanken.Click += new System.EventHandler(this.btn_tanken_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fahren";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tanken";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Liter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "km";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 42);
            this.progressBar1.TabIndex = 13;
            // 
            // txtb_tanken
            // 
            this.txtb_tanken.Location = new System.Drawing.Point(0, 19);
            this.txtb_tanken.Name = "txtb_tanken";
            this.txtb_tanken.Size = new System.Drawing.Size(121, 20);
            this.txtb_tanken.TabIndex = 11;
            // 
            // txtb_fahren
            // 
            this.txtb_fahren.Location = new System.Drawing.Point(0, 121);
            this.txtb_fahren.Name = "txtb_fahren";
            this.txtb_fahren.Size = new System.Drawing.Size(121, 20);
            this.txtb_fahren.TabIndex = 12;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.rtxtb_ausgabe);
            this.panel_Info.Controls.Add(this.label7);
            this.panel_Info.Location = new System.Drawing.Point(316, 266);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(227, 159);
            this.panel_Info.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Informationen";
            // 
            // rtxtb_ausgabe
            // 
            this.rtxtb_ausgabe.Location = new System.Drawing.Point(6, 19);
            this.rtxtb_ausgabe.Name = "rtxtb_ausgabe";
            this.rtxtb_ausgabe.Size = new System.Drawing.Size(218, 137);
            this.rtxtb_ausgabe.TabIndex = 16;
            this.rtxtb_ausgabe.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_error);
            this.groupBox1.Controls.Add(this.cmb_farbe);
            this.groupBox1.Controls.Add(this.txtb_marke);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtb_ps);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_tankgr);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_verbrauch);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neues Auto erstellen";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(340, 119);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_TankenFahren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_TankenFahren.ResumeLayout(false);
            this.panel_TankenFahren.PerformLayout();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_farbe;
        private System.Windows.Forms.TextBox txtb_marke;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txtb_verbrauch;
        private System.Windows.Forms.TextBox txtb_tankgr;
        private System.Windows.Forms.TextBox txtb_ps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_TankenFahren;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Button btn_fahren;
        private System.Windows.Forms.Button btn_tanken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtb_tanken;
        private System.Windows.Forms.TextBox txtb_fahren;
        public System.Windows.Forms.RichTextBox rtxtb_ausgabe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_error;
    }
}

