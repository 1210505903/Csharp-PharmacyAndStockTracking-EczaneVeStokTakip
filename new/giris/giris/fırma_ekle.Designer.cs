namespace giris
{
    partial class fırma_ekle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_fadi = new System.Windows.Forms.TextBox();
            this.text_adres = new System.Windows.Forms.TextBox();
            this.text_tel = new System.Windows.Forms.TextBox();
            this.text_mail = new System.Windows.Forms.TextBox();
            this.combo_tel = new System.Windows.Forms.ComboBox();
            this.combo_ulke = new System.Windows.Forms.ComboBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_vazgec = new System.Windows.Forms.Button();
            this.combo_il = new System.Windows.Forms.ComboBox();
            this.combo_ilce = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "firmanın adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "firmanın adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "telefonu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E_mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ülke";
            // 
            // text_fadi
            // 
            this.text_fadi.Location = new System.Drawing.Point(263, 194);
            this.text_fadi.Name = "text_fadi";
            this.text_fadi.Size = new System.Drawing.Size(232, 20);
            this.text_fadi.TabIndex = 5;
            // 
            // text_adres
            // 
            this.text_adres.Location = new System.Drawing.Point(5, 36);
            this.text_adres.Multiline = true;
            this.text_adres.Name = "text_adres";
            this.text_adres.Size = new System.Drawing.Size(227, 23);
            this.text_adres.TabIndex = 6;
            this.text_adres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(398, 306);
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(100, 20);
            this.text_tel.TabIndex = 7;
            // 
            // text_mail
            // 
            this.text_mail.Location = new System.Drawing.Point(263, 352);
            this.text_mail.Name = "text_mail";
            this.text_mail.Size = new System.Drawing.Size(235, 20);
            this.text_mail.TabIndex = 8;
            this.text_mail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // combo_tel
            // 
            this.combo_tel.FormattingEnabled = true;
            this.combo_tel.Location = new System.Drawing.Point(263, 306);
            this.combo_tel.Name = "combo_tel";
            this.combo_tel.Size = new System.Drawing.Size(121, 21);
            this.combo_tel.TabIndex = 9;
            // 
            // combo_ulke
            // 
            this.combo_ulke.FormattingEnabled = true;
            this.combo_ulke.Location = new System.Drawing.Point(263, 390);
            this.combo_ulke.Name = "combo_ulke";
            this.combo_ulke.Size = new System.Drawing.Size(235, 21);
            this.combo_ulke.TabIndex = 10;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Image = global::giris.Properties.Resources.kaydet;
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_kaydet.Location = new System.Drawing.Point(237, 463);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(93, 70);
            this.button_kaydet.TabIndex = 11;
            this.button_kaydet.Text = "KAYDET";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_vazgec
            // 
            this.button_vazgec.Image = global::giris.Properties.Resources.cikiskirmizi;
            this.button_vazgec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_vazgec.Location = new System.Drawing.Point(354, 463);
            this.button_vazgec.Name = "button_vazgec";
            this.button_vazgec.Size = new System.Drawing.Size(88, 70);
            this.button_vazgec.TabIndex = 12;
            this.button_vazgec.Text = "VAZGEÇ";
            this.button_vazgec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_vazgec.UseVisualStyleBackColor = true;
            // 
            // combo_il
            // 
            this.combo_il.FormattingEnabled = true;
            this.combo_il.Location = new System.Drawing.Point(3, 9);
            this.combo_il.Name = "combo_il";
            this.combo_il.Size = new System.Drawing.Size(121, 21);
            this.combo_il.TabIndex = 13;
            this.combo_il.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // combo_ilce
            // 
            this.combo_ilce.FormattingEnabled = true;
            this.combo_ilce.Location = new System.Drawing.Point(135, 9);
            this.combo_ilce.Name = "combo_ilce";
            this.combo_ilce.Size = new System.Drawing.Size(100, 21);
            this.combo_ilce.TabIndex = 14;
            this.combo_ilce.SelectedIndexChanged += new System.EventHandler(this.combo_ilce_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_adres);
            this.panel1.Controls.Add(this.combo_ilce);
            this.panel1.Controls.Add(this.combo_il);
            this.panel1.Location = new System.Drawing.Point(263, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 62);
            this.panel1.TabIndex = 15;
            // 
            // fırma_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::giris.Properties.Resources.formarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_vazgec);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.combo_ulke);
            this.Controls.Add(this.combo_tel);
            this.Controls.Add(this.text_mail);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.text_fadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fırma_ekle";
            this.Text = "fırma_ekle";
            this.Load += new System.EventHandler(this.fırma_ekle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_fadi;
        private System.Windows.Forms.TextBox text_adres;
        private System.Windows.Forms.TextBox text_tel;
        private System.Windows.Forms.TextBox text_mail;
        private System.Windows.Forms.ComboBox combo_tel;
        private System.Windows.Forms.ComboBox combo_ulke;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_vazgec;
        private System.Windows.Forms.ComboBox combo_il;
        private System.Windows.Forms.ComboBox combo_ilce;
        private System.Windows.Forms.Panel panel1;
    }
}