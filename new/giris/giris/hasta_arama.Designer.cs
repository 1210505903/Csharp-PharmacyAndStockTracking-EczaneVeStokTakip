namespace giris
{
    partial class hasta_arama
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
            this.radio_tcno = new System.Windows.Forms.RadioButton();
            this.radio_sadi = new System.Windows.Forms.RadioButton();
            this.radio_adi = new System.Windows.Forms.RadioButton();
            this.button_ara = new System.Windows.Forms.Button();
            this.text_ara = new System.Windows.Forms.TextBox();
            this.tblhastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vt_eczaneDataSet = new giris.vt_eczaneDataSet();
            this.tbl_hastaTableAdapter = new giris.vt_eczaneDataSetTableAdapters.tbl_hastaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.data_guvence = new System.Windows.Forms.DataGridView();
            this.guvenceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guvenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblguvenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_guvenceTableAdapter = new giris.vt_eczaneDataSetTableAdapters.tbl_guvenceTableAdapter();
            this.data_hastalik = new System.Windows.Forms.DataGridView();
            this.hastalikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastalikadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaliksebebiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblhastalikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_hastalikTableAdapter = new giris.vt_eczaneDataSetTableAdapters.tbl_hastalikTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.data_hasta = new System.Windows.Forms.DataGridView();
            this.vt_eczaneDataSet1 = new giris.vt_eczaneDataSet();
            this.tblhastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastasadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastadogumtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guvencenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_guvence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblguvenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_hastalik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastalikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_tcno);
            this.panel1.Controls.Add(this.radio_sadi);
            this.panel1.Controls.Add(this.radio_adi);
            this.panel1.Location = new System.Drawing.Point(88, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 55);
            this.panel1.TabIndex = 0;
            // 
            // radio_tcno
            // 
            this.radio_tcno.AutoSize = true;
            this.radio_tcno.Location = new System.Drawing.Point(254, 17);
            this.radio_tcno.Name = "radio_tcno";
            this.radio_tcno.Size = new System.Drawing.Size(185, 17);
            this.radio_tcno.TabIndex = 2;
            this.radio_tcno.TabStop = true;
            this.radio_tcno.Text = "TC NO NUMARASIN GÖRE ARA";
            this.radio_tcno.UseVisualStyleBackColor = true;
            this.radio_tcno.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radio_sadi
            // 
            this.radio_sadi.AutoSize = true;
            this.radio_sadi.Location = new System.Drawing.Point(116, 17);
            this.radio_sadi.Name = "radio_sadi";
            this.radio_sadi.Size = new System.Drawing.Size(139, 17);
            this.radio_sadi.TabIndex = 1;
            this.radio_sadi.TabStop = true;
            this.radio_sadi.Text = "SOYADINA GÖRE ARA";
            this.radio_sadi.UseVisualStyleBackColor = true;
            // 
            // radio_adi
            // 
            this.radio_adi.AutoSize = true;
            this.radio_adi.Location = new System.Drawing.Point(3, 17);
            this.radio_adi.Name = "radio_adi";
            this.radio_adi.Size = new System.Drawing.Size(117, 17);
            this.radio_adi.TabIndex = 0;
            this.radio_adi.TabStop = true;
            this.radio_adi.Text = "ADINA GÖRE ARA";
            this.radio_adi.UseVisualStyleBackColor = true;
            // 
            // button_ara
            // 
            this.button_ara.Image = global::giris.Properties.Resources.ara;
            this.button_ara.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ara.Location = new System.Drawing.Point(426, 215);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(101, 81);
            this.button_ara.TabIndex = 2;
            this.button_ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // text_ara
            // 
            this.text_ara.Location = new System.Drawing.Point(91, 215);
            this.text_ara.Multiline = true;
            this.text_ara.Name = "text_ara";
            this.text_ara.Size = new System.Drawing.Size(324, 81);
            this.text_ara.TabIndex = 3;
            this.text_ara.TextChanged += new System.EventHandler(this.text_ara_TextChanged);
            // 
            // tblhastaBindingSource
            // 
            this.tblhastaBindingSource.DataMember = "tbl_hasta";
            this.tblhastaBindingSource.DataSource = this.vt_eczaneDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // data_guvence
            // 
            this.data_guvence.AutoGenerateColumns = false;
            this.data_guvence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_guvence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guvenceidDataGridViewTextBoxColumn,
            this.guvenceDataGridViewTextBoxColumn});
            this.data_guvence.DataSource = this.tblguvenceBindingSource;
            this.data_guvence.Location = new System.Drawing.Point(2, 0);
            this.data_guvence.Name = "data_guvence";
            this.data_guvence.Size = new System.Drawing.Size(10, 10);
            this.data_guvence.TabIndex = 6;
            this.data_guvence.Visible = false;
            // 
            // guvenceidDataGridViewTextBoxColumn
            // 
            this.guvenceidDataGridViewTextBoxColumn.DataPropertyName = "guvence_id";
            this.guvenceidDataGridViewTextBoxColumn.HeaderText = "guvence_id";
            this.guvenceidDataGridViewTextBoxColumn.Name = "guvenceidDataGridViewTextBoxColumn";
            // 
            // guvenceDataGridViewTextBoxColumn
            // 
            this.guvenceDataGridViewTextBoxColumn.DataPropertyName = "guvence";
            this.guvenceDataGridViewTextBoxColumn.HeaderText = "guvence";
            this.guvenceDataGridViewTextBoxColumn.Name = "guvenceDataGridViewTextBoxColumn";
            // 
            // tblguvenceBindingSource
            // 
            this.tblguvenceBindingSource.DataMember = "tbl_guvence";
            this.tblguvenceBindingSource.DataSource = this.vt_eczaneDataSet;
            // 
            // tbl_guvenceTableAdapter
            // 
            this.tbl_guvenceTableAdapter.ClearBeforeFill = true;
            // 
            // data_hastalik
            // 
            this.data_hastalik.AutoGenerateColumns = false;
            this.data_hastalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hastalik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hastalikidDataGridViewTextBoxColumn,
            this.hastalikadiDataGridViewTextBoxColumn,
            this.hastaliksebebiDataGridViewTextBoxColumn});
            this.data_hastalik.DataSource = this.tblhastalikBindingSource;
            this.data_hastalik.Location = new System.Drawing.Point(39, 0);
            this.data_hastalik.Name = "data_hastalik";
            this.data_hastalik.Size = new System.Drawing.Size(10, 10);
            this.data_hastalik.TabIndex = 7;
            this.data_hastalik.Visible = false;
            // 
            // hastalikidDataGridViewTextBoxColumn
            // 
            this.hastalikidDataGridViewTextBoxColumn.DataPropertyName = "hastalik_id";
            this.hastalikidDataGridViewTextBoxColumn.HeaderText = "hastalik_id";
            this.hastalikidDataGridViewTextBoxColumn.Name = "hastalikidDataGridViewTextBoxColumn";
            // 
            // hastalikadiDataGridViewTextBoxColumn
            // 
            this.hastalikadiDataGridViewTextBoxColumn.DataPropertyName = "hastalik_adi";
            this.hastalikadiDataGridViewTextBoxColumn.HeaderText = "hastalik_adi";
            this.hastalikadiDataGridViewTextBoxColumn.Name = "hastalikadiDataGridViewTextBoxColumn";
            // 
            // hastaliksebebiDataGridViewTextBoxColumn
            // 
            this.hastaliksebebiDataGridViewTextBoxColumn.DataPropertyName = "hastalik_sebebi";
            this.hastaliksebebiDataGridViewTextBoxColumn.HeaderText = "hastalik_sebebi";
            this.hastaliksebebiDataGridViewTextBoxColumn.Name = "hastaliksebebiDataGridViewTextBoxColumn";
            // 
            // tblhastalikBindingSource
            // 
            this.tblhastalikBindingSource.DataMember = "tbl_hastalik";
            this.tblhastalikBindingSource.DataSource = this.vt_eczaneDataSet;
            // 
            // tbl_hastalikTableAdapter
            // 
            this.tbl_hastalikTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
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
            this.telefonnoDataGridViewTextBoxColumn,
            this.guvencenoDataGridViewTextBoxColumn,
            this.hastaliknoDataGridViewTextBoxColumn});
            this.data_hasta.DataSource = this.tblhastaBindingSource1;
            this.data_hasta.Location = new System.Drawing.Point(119, 324);
            this.data_hasta.Name = "data_hasta";
            this.data_hasta.Size = new System.Drawing.Size(240, 150);
            this.data_hasta.TabIndex = 10;
            this.data_hasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hasta_CellContentClick);
            this.data_hasta.DoubleClick += new System.EventHandler(this.data_hasta_DoubleClick_1);
            // 
            // vt_eczaneDataSet1
            // 
            this.vt_eczaneDataSet1.DataSetName = "vt_eczaneDataSet";
            this.vt_eczaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblhastaBindingSource1
            // 
            this.tblhastaBindingSource1.DataMember = "tbl_hasta";
            this.tblhastaBindingSource1.DataSource = this.vt_eczaneDataSet1;
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
            // telefonnoDataGridViewTextBoxColumn
            // 
            this.telefonnoDataGridViewTextBoxColumn.DataPropertyName = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.HeaderText = "telefon_no";
            this.telefonnoDataGridViewTextBoxColumn.Name = "telefonnoDataGridViewTextBoxColumn";
            // 
            // guvencenoDataGridViewTextBoxColumn
            // 
            this.guvencenoDataGridViewTextBoxColumn.DataPropertyName = "guvence_no";
            this.guvencenoDataGridViewTextBoxColumn.HeaderText = "guvence_no";
            this.guvencenoDataGridViewTextBoxColumn.Name = "guvencenoDataGridViewTextBoxColumn";
            // 
            // hastaliknoDataGridViewTextBoxColumn
            // 
            this.hastaliknoDataGridViewTextBoxColumn.DataPropertyName = "hastalik_no";
            this.hastaliknoDataGridViewTextBoxColumn.HeaderText = "hastalik_no";
            this.hastaliknoDataGridViewTextBoxColumn.Name = "hastaliknoDataGridViewTextBoxColumn";
            this.hastaliknoDataGridViewTextBoxColumn.Visible = false;
            // 
            // hasta_arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::giris.Properties.Resources.formarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 527);
            this.Controls.Add(this.data_hasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_hastalik);
            this.Controls.Add(this.data_guvence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_ara);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "hasta_arama";
            this.Text = "HASTA ARAMA";
            this.Load += new System.EventHandler(this.hasta_arama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_guvence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblguvenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_hastalik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastalikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vt_eczaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_tcno;
        private System.Windows.Forms.RadioButton radio_sadi;
        private System.Windows.Forms.RadioButton radio_adi;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.TextBox text_ara;
        private vt_eczaneDataSet vt_eczaneDataSet;
        private System.Windows.Forms.BindingSource tblhastaBindingSource;
        private vt_eczaneDataSetTableAdapters.tbl_hastaTableAdapter tbl_hastaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_guvence;
        private System.Windows.Forms.BindingSource tblguvenceBindingSource;
        private vt_eczaneDataSetTableAdapters.tbl_guvenceTableAdapter tbl_guvenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guvenceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guvenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView data_hastalik;
        private System.Windows.Forms.BindingSource tblhastalikBindingSource;
        private vt_eczaneDataSetTableAdapters.tbl_hastalikTableAdapter tbl_hastalikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastalikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastalikadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaliksebebiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_hasta;
        private vt_eczaneDataSet vt_eczaneDataSet1;
        private System.Windows.Forms.BindingSource tblhastaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastasadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastadogumtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guvencenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaliknoDataGridViewTextBoxColumn;
    }
}