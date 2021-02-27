
namespace Geometri_Odev
{
    partial class Form1
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
            this.tbTaban = new System.Windows.Forms.TextBox();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.lbTaban = new System.Windows.Forms.Label();
            this.lbYukseklik = new System.Windows.Forms.Label();
            this.lYaricap = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lbAlan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKare = new System.Windows.Forms.CheckBox();
            this.cbDikdortgen = new System.Windows.Forms.CheckBox();
            this.cbEskenarUcgen = new System.Windows.Forms.CheckBox();
            this.cbDikUcgen = new System.Windows.Forms.CheckBox();
            this.cbDaire = new System.Windows.Forms.CheckBox();
            this.lbCevre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTaban
            // 
            this.tbTaban.Location = new System.Drawing.Point(11, 74);
            this.tbTaban.Name = "tbTaban";
            this.tbTaban.Size = new System.Drawing.Size(100, 20);
            this.tbTaban.TabIndex = 0;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(137, 74);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(100, 20);
            this.tbYukseklik.TabIndex = 0;
            // 
            // tbYariCap
            // 
            this.tbYariCap.Location = new System.Drawing.Point(271, 74);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(100, 20);
            this.tbYariCap.TabIndex = 0;
            this.tbYariCap.Visible = false;
            // 
            // lbTaban
            // 
            this.lbTaban.AutoSize = true;
            this.lbTaban.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTaban.Location = new System.Drawing.Point(11, 54);
            this.lbTaban.Name = "lbTaban";
            this.lbTaban.Size = new System.Drawing.Size(52, 18);
            this.lbTaban.TabIndex = 1;
            this.lbTaban.Text = "Taban:";
            // 
            // lbYukseklik
            // 
            this.lbYukseklik.AutoSize = true;
            this.lbYukseklik.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYukseklik.Location = new System.Drawing.Point(137, 54);
            this.lbYukseklik.Name = "lbYukseklik";
            this.lbYukseklik.Size = new System.Drawing.Size(72, 18);
            this.lbYukseklik.TabIndex = 1;
            this.lbYukseklik.Text = "Yükseklik:";
            // 
            // lYaricap
            // 
            this.lYaricap.AutoSize = true;
            this.lYaricap.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lYaricap.Location = new System.Drawing.Point(271, 54);
            this.lYaricap.Name = "lYaricap";
            this.lYaricap.Size = new System.Drawing.Size(58, 18);
            this.lYaricap.TabIndex = 1;
            this.lYaricap.Text = "Yarıçap:";
            this.lYaricap.Visible = false;
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesap.Location = new System.Drawing.Point(11, 251);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(97, 42);
            this.btnHesap.TabIndex = 2;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lbAlan
            // 
            this.lbAlan.AutoSize = true;
            this.lbAlan.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAlan.Location = new System.Drawing.Point(70, 188);
            this.lbAlan.Name = "lbAlan";
            this.lbAlan.Size = new System.Drawing.Size(61, 23);
            this.lbAlan.TabIndex = 3;
            this.lbAlan.Text = "sonuc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Alan:";
            // 
            // cbKare
            // 
            this.cbKare.AutoSize = true;
            this.cbKare.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKare.Location = new System.Drawing.Point(11, 119);
            this.cbKare.Name = "cbKare";
            this.cbKare.Size = new System.Drawing.Size(57, 22);
            this.cbKare.TabIndex = 4;
            this.cbKare.Text = "Kare";
            this.cbKare.UseVisualStyleBackColor = true;
            this.cbKare.CheckedChanged += new System.EventHandler(this.cbKare_CheckedChanged);
            // 
            // cbDikdortgen
            // 
            this.cbDikdortgen.AutoSize = true;
            this.cbDikdortgen.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDikdortgen.Location = new System.Drawing.Point(11, 147);
            this.cbDikdortgen.Name = "cbDikdortgen";
            this.cbDikdortgen.Size = new System.Drawing.Size(102, 22);
            this.cbDikdortgen.TabIndex = 4;
            this.cbDikdortgen.Text = "Dikdörtgen";
            this.cbDikdortgen.UseVisualStyleBackColor = true;
            this.cbDikdortgen.CheckedChanged += new System.EventHandler(this.cbDikdortgen_CheckedChanged);
            // 
            // cbEskenarUcgen
            // 
            this.cbEskenarUcgen.AutoSize = true;
            this.cbEskenarUcgen.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEskenarUcgen.Location = new System.Drawing.Point(175, 119);
            this.cbEskenarUcgen.Name = "cbEskenarUcgen";
            this.cbEskenarUcgen.Size = new System.Drawing.Size(126, 22);
            this.cbEskenarUcgen.TabIndex = 4;
            this.cbEskenarUcgen.Text = "Eşkenar Üçgen";
            this.cbEskenarUcgen.UseVisualStyleBackColor = true;
            this.cbEskenarUcgen.CheckedChanged += new System.EventHandler(this.cbEskenarUcgen_CheckedChanged);
            // 
            // cbDikUcgen
            // 
            this.cbDikUcgen.AutoSize = true;
            this.cbDikUcgen.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDikUcgen.Location = new System.Drawing.Point(74, 119);
            this.cbDikUcgen.Name = "cbDikUcgen";
            this.cbDikUcgen.Size = new System.Drawing.Size(95, 22);
            this.cbDikUcgen.TabIndex = 4;
            this.cbDikUcgen.Text = "Dik Üçgen";
            this.cbDikUcgen.UseVisualStyleBackColor = true;
            this.cbDikUcgen.CheckedChanged += new System.EventHandler(this.cbDikUcgen_CheckedChanged);
            // 
            // cbDaire
            // 
            this.cbDaire.AutoSize = true;
            this.cbDaire.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaire.Location = new System.Drawing.Point(307, 119);
            this.cbDaire.Name = "cbDaire";
            this.cbDaire.Size = new System.Drawing.Size(62, 22);
            this.cbDaire.TabIndex = 4;
            this.cbDaire.Text = "Daire";
            this.cbDaire.UseVisualStyleBackColor = true;
            this.cbDaire.CheckedChanged += new System.EventHandler(this.cbDaire_CheckedChanged);
            // 
            // lbCevre
            // 
            this.lbCevre.AutoSize = true;
            this.lbCevre.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbCevre.Location = new System.Drawing.Point(71, 211);
            this.lbCevre.Name = "lbCevre";
            this.lbCevre.Size = new System.Drawing.Size(61, 23);
            this.lbCevre.TabIndex = 3;
            this.lbCevre.Text = "sonuc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çevre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 33);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geometrik İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 315);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDaire);
            this.Controls.Add(this.cbDikUcgen);
            this.Controls.Add(this.cbEskenarUcgen);
            this.Controls.Add(this.cbDikdortgen);
            this.Controls.Add(this.cbKare);
            this.Controls.Add(this.lbCevre);
            this.Controls.Add(this.lbAlan);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lYaricap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbYukseklik);
            this.Controls.Add(this.lbTaban);
            this.Controls.Add(this.tbYariCap);
            this.Controls.Add(this.tbYukseklik);
            this.Controls.Add(this.tbTaban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaban;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.TextBox tbYariCap;
        private System.Windows.Forms.Label lbTaban;
        private System.Windows.Forms.Label lbYukseklik;
        private System.Windows.Forms.Label lYaricap;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Label lbAlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbKare;
        private System.Windows.Forms.CheckBox cbDikdortgen;
        private System.Windows.Forms.CheckBox cbEskenarUcgen;
        private System.Windows.Forms.CheckBox cbDikUcgen;
        private System.Windows.Forms.CheckBox cbDaire;
        private System.Windows.Forms.Label lbCevre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

