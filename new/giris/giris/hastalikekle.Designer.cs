namespace giris
{
    partial class hastalikekle
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
            this.text_hadi = new System.Windows.Forms.TextBox();
            this.text_hsebebi = new System.Windows.Forms.TextBox();
            this.but_kaydet = new System.Windows.Forms.Button();
            this.but_vazgec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTALIK ADI:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTALIK SEBEBİ:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_hadi
            // 
            this.text_hadi.Location = new System.Drawing.Point(207, 185);
            this.text_hadi.Name = "text_hadi";
            this.text_hadi.Size = new System.Drawing.Size(100, 20);
            this.text_hadi.TabIndex = 2;
            // 
            // text_hsebebi
            // 
            this.text_hsebebi.Location = new System.Drawing.Point(207, 232);
            this.text_hsebebi.Multiline = true;
            this.text_hsebebi.Name = "text_hsebebi";
            this.text_hsebebi.Size = new System.Drawing.Size(100, 24);
            this.text_hsebebi.TabIndex = 3;
            this.text_hsebebi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // but_kaydet
            // 
            this.but_kaydet.BackColor = System.Drawing.Color.Transparent;
            this.but_kaydet.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.but_kaydet.Image = global::giris.Properties.Resources.kaydet;
            this.but_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_kaydet.Location = new System.Drawing.Point(49, 277);
            this.but_kaydet.Name = "but_kaydet";
            this.but_kaydet.Size = new System.Drawing.Size(109, 81);
            this.but_kaydet.TabIndex = 20;
            this.but_kaydet.Text = "KAYDET";
            this.but_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_kaydet.UseVisualStyleBackColor = false;
            this.but_kaydet.Click += new System.EventHandler(this.but_kaydet_Click);
            // 
            // but_vazgec
            // 
            this.but_vazgec.BackColor = System.Drawing.Color.Transparent;
            this.but_vazgec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_vazgec.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.but_vazgec.Image = global::giris.Properties.Resources.cikiskirmizi;
            this.but_vazgec.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_vazgec.Location = new System.Drawing.Point(188, 276);
            this.but_vazgec.Name = "but_vazgec";
            this.but_vazgec.Size = new System.Drawing.Size(119, 82);
            this.but_vazgec.TabIndex = 21;
            this.but_vazgec.Text = "VAZGEÇ";
            this.but_vazgec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_vazgec.UseVisualStyleBackColor = false;
            this.but_vazgec.Click += new System.EventHandler(this.but_vazgec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(114, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 93);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // hastalikekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::giris.Properties.Resources.formarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_vazgec);
            this.Controls.Add(this.but_kaydet);
            this.Controls.Add(this.text_hsebebi);
            this.Controls.Add(this.text_hadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "hastalikekle";
            this.Text = "                                                                                 " +
    "                                                     ";
            this.Load += new System.EventHandler(this.hastalikekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_hadi;
        private System.Windows.Forms.TextBox text_hsebebi;
        private System.Windows.Forms.Button but_kaydet;
        private System.Windows.Forms.Button but_vazgec;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}