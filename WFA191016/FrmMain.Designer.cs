namespace WFA191016
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNevek = new System.Windows.Forms.ComboBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.rbFerfi = new System.Windows.Forms.RadioButton();
            this.cbVega = new System.Windows.Forms.CheckBox();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAsztal = new System.Windows.Forms.Label();
            this.lblKaja = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.tbAsztal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendég neve:";
            // 
            // cbNevek
            // 
            this.cbNevek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbNevek.FormattingEnabled = true;
            this.cbNevek.Location = new System.Drawing.Point(201, 25);
            this.cbNevek.Name = "cbNevek";
            this.cbNevek.Size = new System.Drawing.Size(269, 37);
            this.cbNevek.TabIndex = 1;
            this.cbNevek.SelectedIndexChanged += new System.EventHandler(this.cbNevek_SelectedIndexChanged);
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(168, 329);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(231, 34);
            this.tbNev.TabIndex = 2;
            // 
            // rbFerfi
            // 
            this.rbFerfi.AutoSize = true;
            this.rbFerfi.Checked = true;
            this.rbFerfi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFerfi.Location = new System.Drawing.Point(185, 386);
            this.rbFerfi.Name = "rbFerfi";
            this.rbFerfi.Size = new System.Drawing.Size(74, 33);
            this.rbFerfi.TabIndex = 3;
            this.rbFerfi.TabStop = true;
            this.rbFerfi.Text = "férfi";
            this.rbFerfi.UseVisualStyleBackColor = true;
            // 
            // cbVega
            // 
            this.cbVega.AutoSize = true;
            this.cbVega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVega.Location = new System.Drawing.Point(300, 450);
            this.cbVega.Name = "cbVega";
            this.cbVega.Size = new System.Drawing.Size(99, 33);
            this.cbVega.TabIndex = 4;
            this.cbVega.Text = "vega?";
            this.cbVega.UseVisualStyleBackColor = true;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(12, 512);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(458, 49);
            this.btnRogzit.TabIndex = 5;
            this.btnRogzit.Text = "RÖGZÍT";
            this.btnRogzit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vendég adatai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(163, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Asztal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(178, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kaja:";
            // 
            // lblAsztal
            // 
            this.lblAsztal.AutoSize = true;
            this.lblAsztal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAsztal.Location = new System.Drawing.Point(265, 134);
            this.lblAsztal.Name = "lblAsztal";
            this.lblAsztal.Size = new System.Drawing.Size(52, 29);
            this.lblAsztal.TabIndex = 0;
            this.lblAsztal.Text = "###";
            // 
            // lblKaja
            // 
            this.lblKaja.AutoSize = true;
            this.lblKaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKaja.Location = new System.Drawing.Point(265, 185);
            this.lblKaja.Name = "lblKaja";
            this.lblKaja.Size = new System.Drawing.Size(52, 29);
            this.lblKaja.TabIndex = 0;
            this.lblKaja.Text = "###";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(100, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "ÚJ VENDÉG RÖGZÍTÉSE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(100, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Név:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(91, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(80, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Asztal:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbNo.Location = new System.Drawing.Point(331, 386);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(61, 33);
            this.rbNo.TabIndex = 3;
            this.rbNo.Text = "nő";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // tbAsztal
            // 
            this.tbAsztal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAsztal.Location = new System.Drawing.Point(168, 448);
            this.tbAsztal.Name = "tbAsztal";
            this.tbAsztal.Size = new System.Drawing.Size(110, 34);
            this.tbAsztal.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 578);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.cbVega);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbFerfi);
            this.Controls.Add(this.tbAsztal);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.cbNevek);
            this.Controls.Add(this.lblKaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAsztal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNevek;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.RadioButton rbFerfi;
        private System.Windows.Forms.CheckBox cbVega;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAsztal;
        private System.Windows.Forms.Label lblKaja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.TextBox tbAsztal;
    }
}

