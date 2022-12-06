namespace giris
{
    partial class hastaarama
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_adi = new System.Windows.Forms.RadioButton();
            this.radio_sadi = new System.Windows.Forms.RadioButton();
            this.radio_tcno = new System.Windows.Forms.RadioButton();
            this.text_ara = new System.Windows.Forms.TextBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.data_hasta = new System.Windows.Forms.DataGridView();
            this.vt_eczaneDataSet = new giris.vt_eczaneDataSet();
            this.tbl_hastaTableAdapter = new giris.vt_eczaneDataSetTableAdapters.tbl_hastaTableAdapter();
            this.tblhastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastasadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastadogumtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guvencenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_tcno);
            this.panel1.Controls.Add(this.radio_sadi);
            this.panel1.Controls.Add(this.radio_adi);
            this.panel1.Location = new System.Drawing.Point(67, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 95);
            this.panel1.TabIndex = 0;
            // 
            // radio_adi
            // 
            this.radio_adi.AutoSize = true;
            this.radio_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_adi.Location = new System.Drawing.Point(14, 13);
            this.radio_adi.Name = "radio_adi";
            this.radio_adi.Size = new System.Drawing.Size(151, 22);
            this.radio_adi.TabIndex = 0;
            this.radio_adi.TabStop = true;
            this.radio_adi.Text = "ADINA GÖRE ARA";
            this.radio_adi.UseVisualStyleBackColor = true;
            // 
            // radio_sadi
            // 
            this.radio_sadi.AutoSize = true;
            this.radio_sadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_sadi.Location = new System.Drawing.Point(14, 36);
            this.radio_sadi.Name = "radio_sadi";
            this.radio_sadi.Size = new System.Drawing.Size(182, 22);
            this.radio_sadi.TabIndex = 1;
            this.radio_sadi.TabStop = true;
            this.radio_sadi.Text = "SOYADINA GÖRE ARA";
            this.radio_sadi.UseVisualStyleBackColor = true;
            // 
            // radio_tcno
            // 
            this.radio_tcno.AutoSize = true;
            this.radio_tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_tcno.Location = new System.Drawing.Point(14, 64);
            this.radio_tcno.Name = "radio_tcno";
            this.radio_tcno.Size = new System.Drawing.Size(229, 22);
            this.radio_tcno.TabIndex = 2;
            this.radio_tcno.TabStop = true;
            this.radio_tcno.Text = "TC NUMARASINA GÖRE ARA";
            this.radio_tcno.UseVisualStyleBackColor = true;
            // 
            // text_ara
            // 
            this.text_ara.Location = new System.Drawing.Point(67, 238);
            this.text_ara.Name = "text_ara";
            this.text_ara.Size = new System.Drawing.Size(366, 20);
            this.text_ara.TabIndex = 1;
            // 
            // button_ara
            // 
            this.button_ara.Image = global::giris.Properties.Resources.ara;
            this.button_ara.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ara.Location = new System.Drawing.Point(439, 238);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(70, 56);
            this.button_ara.TabIndex = 2;
            this.button_ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ara.UseVisualStyleBackColor = true;
            // 
            // data_hasta
            // 
            this.data_hasta.AutoGenerateColumns = false;
            this.data_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastaidDataGridViewTextBoxColumn,
            this.hastaadiDataGridViewTextBoxColumn,
            this.hastasadiDataGridViewTextBoxColumn,
            this.hastatcnoDataGridViewTextBoxColumn,
            this.hastadogumtDataGridViewTextBoxColumn,
            this.dogumyeriilDataGridViewTextBoxColumn,
            this.dogumyeriilceDataGridViewTextBoxColumn,
            this.guvencenoDataGridViewTextBoxColumn,
            this.telefonnoDataGridViewTextBoxColumn});
            this.data_hasta.DataSource = this.tblhastaBindingSource;
            this.data_hasta.Location = new System.Drawing.Point(67, 300);
            this.data_hasta.Name = "data_hasta";
            this.data_hasta.Size = new System.Drawing.Size(442, 191);
            this.data_hasta.TabIndex = 3;
            // 
            // vt_eczaneDataSet
            // 
            this.vt_eczaneDataSet.DataSetName = "vt_eczaneDataSet";
            this.vt_eczaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_hastaTableAdapter
            // 
            this.tbl_hastaTableAdapter.ClearBeforeFill = true;
            // 
            // tblhastaBindingSource
            // 
            this.tblhastaBindingSource.DataMember = "tbl_hasta";
            this.tblhastaBindingSource.DataSource = this.vt_eczaneDataSet;
            // 
            // hastaidDataGridViewTextBoxColumn
            // 
            this.hastaidDataGridViewTextBoxColumn.DataPropertyName = "hasta_id";
            this.hastaidDataGridViewTextBoxColumn.HeaderText = "hasta_id";
            this.hastaidDataGridViewTextBoxColumn.Name = "hastaidDataGridViewTextBoxColumn";
            // 
            // hastaadiDataGridViewTextBoxColumn
            // 
            this.hastaadiDataGridViewTextBoxColumn.DataPropertyName = "hasta_adi";
            this.hastaadiDataGridViewTextBoxColumn.HeaderText = "hasta_adi";
            this.hastaadiDataGridViewTextBoxColumn.Name = "hastaadiDataGridViewTextBoxColumn";
            // 
            // hastasadiDataGridViewTextBoxColumn
            // 
            this.hastasadiDataGridViewTextBoxColumn.DataPropertyName = "hasta_sadi";
            this.hastasadiDataGridViewTextBoxColumn.HeaderText = "hasta_sadi";
            this.hastasadiDataGridViewTextBoxColumn.Name = "hastasadiDataGridViewTextBoxColumn";
            // 
            // hastatcnoDataGridViewTextBoxColumn
            // 
            this.hastatcnoDataGridViewTextBoxColumn.DataPropertyName = "hasta_tcno";
            this.hastatcnoDataGridViewTextBoxColumn.HeaderText = "hasta_tcno";
            this.hastatcnoDataGridViewTextBoxColumn.Name = "hastatcnoDataGridViewTextBoxColumn";
            // 
            // hastadogumtDataGridViewTextBoxColumn
            // 
            this.hastadogumtDataGridViewTextBoxColumn.DataPropertyName = "hasta_dogumt";
            this.hastadogumtDataGridViewTextBoxColumn.HeaderText = "hasta_dogumt";
            this.hastadogumtDataGridViewTextBoxColumn.Name = "hastadogumtDataGridViewTextBoxColumn";
            // 
            // dogumyeriilDataGridViewTextBoxColumn
            // 
            this.dogumyeriilDataGridViewTextBoxColumn.DataPropertyName = "dogumyeri_il";
            this.dogumyeriilDataGridViewTextBoxColumn.HeaderText = "dogumyeri_il";
            this.dogumyeriilDataGridViewTextBoxColumn.Name = "dogumyeriilDataGridViewTextBoxColumn";
            // 
            // dogumyeriilceDataGridViewTextBoxColumn
            // 
            this.dogumyeriilceDataGridViewTextBoxColumn.DataPropertyName = "dogumyeri_ilce";
            this.dogumyeriilceDataGridViewTextBoxColumn.HeaderText = "dogumyeri_ilce";
            this.dogumyeriilceDataGridViewTextBoxColumn.Name = "dogumyeriilceDataGridViewTextBoxColumn";
            // 
            // guvencenoDataGridViewTextBoxColumn
            // 
            this.guvencenoDataGridViewTextBoxColumn.DataPropertyName = "guvence_no";
            this.guvencenoDataGridViewTextBoxColumn.HeaderText = "guvence_no";
            this.guvencenoDataGridViewTextBoxColumn.Name = "guvencenoDataGridViewTextBoxColumn";
            // 
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            // 
            // hastaarama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::giris.Properties.Resources.formarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 560);
            this.Controls.Add(this.data_hasta);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.text_ara);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "hastaarama";
            this.Text = "HASTA ARATMA";
            this.Load += new System.EventHandler(this.hastaarama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_tcno;
        private System.Windows.Forms.RadioButton radio_sadi;
        private System.Windows.Forms.RadioButton radio_adi;
        private System.Windows.Forms.TextBox text_ara;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.DataGridView data_hasta;
        private vt_eczaneDataSet vt_eczaneDataSet;
        private vt_eczaneDataSetTableAdapters.tbl_hastaTableAdapter tbl_hastaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastasadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastadogumtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guvencenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblhastaBindingSource;
    }
}