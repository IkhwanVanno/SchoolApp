namespace SchoolAps.UserControls
{
    partial class UC_Sekolah
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sekolah));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSekolah = new System.Windows.Forms.DataGridView();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sekolahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDBDataSet = new SchoolAps.SekolahDBDataSet();
            this.sekolahTableAdapter = new SchoolAps.SekolahDBDataSetTableAdapters.SekolahTableAdapter();
            this.labelCari = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.labelKota = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelCountFill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSekolah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).BeginInit();
            this.tableLayoutPanelForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA SEKOLAH";
            // 
            // dataGridViewSekolah
            // 
            this.dataGridViewSekolah.AllowUserToAddRows = false;
            this.dataGridViewSekolah.AllowUserToDeleteRows = false;
            this.dataGridViewSekolah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSekolah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSekolah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ubah,
            this.hapus});
            this.dataGridViewSekolah.Location = new System.Drawing.Point(16, 71);
            this.dataGridViewSekolah.MultiSelect = false;
            this.dataGridViewSekolah.Name = "dataGridViewSekolah";
            this.dataGridViewSekolah.ReadOnly = true;
            this.dataGridViewSekolah.RowHeadersVisible = false;
            this.dataGridViewSekolah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSekolah.Size = new System.Drawing.Size(768, 150);
            this.dataGridViewSekolah.TabIndex = 2;
            this.dataGridViewSekolah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSekolah_CellContentClick);
            // 
            // Ubah
            // 
            this.Ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ubah.DataPropertyName = "Ubah";
            this.Ubah.HeaderText = "Ubah";
            this.Ubah.Name = "Ubah";
            this.Ubah.ReadOnly = true;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseColumnTextForButtonValue = true;
            // 
            // hapus
            // 
            this.hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hapus.DataPropertyName = "Hapus";
            this.hapus.HeaderText = "Hapus";
            this.hapus.Name = "hapus";
            this.hapus.ReadOnly = true;
            this.hapus.Text = "Hapus";
            this.hapus.UseColumnTextForButtonValue = true;
            // 
            // sekolahBindingSource
            // 
            this.sekolahBindingSource.DataMember = "Sekolah";
            this.sekolahBindingSource.DataSource = this.sekolahDBDataSet;
            // 
            // sekolahDBDataSet
            // 
            this.sekolahDBDataSet.DataSetName = "SekolahDBDataSet";
            this.sekolahDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sekolahTableAdapter
            // 
            this.sekolahTableAdapter.ClearBeforeFill = true;
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(13, 46);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 3;
            this.labelCari.Text = "Cari :";
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(50, 43);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(170, 20);
            this.textBoxCari.TabIndex = 6;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNama.Location = new System.Drawing.Point(79, 3);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(300, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // buttonBatal
            // 
            this.buttonBatal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBatal.Location = new System.Drawing.Point(79, 3);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(147, 26);
            this.buttonBatal.TabIndex = 9;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSimpan.Location = new System.Drawing.Point(232, 3);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(147, 26);
            this.buttonSimpan.TabIndex = 10;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(10, 10);
            this.btnRefresh.Location = new System.Drawing.Point(757, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 20);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelForm.ColumnCount = 4;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelForm.Controls.Add(this.labelKota, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxKota, 1, 1);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxID, 3, 1);
            this.tableLayoutPanelForm.Controls.Add(this.labelCountFill, 3, 0);
            this.tableLayoutPanelForm.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(16, 227);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowCount = 2;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(767, 53);
            this.tableLayoutPanelForm.TabIndex = 17;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKota.Location = new System.Drawing.Point(3, 26);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(70, 27);
            this.labelKota.TabIndex = 4;
            this.labelKota.Text = "Kota :";
            this.labelKota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(79, 29);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(300, 21);
            this.comboBoxKota.TabIndex = 8;
            this.comboBoxKota.SelectedIndexChanged += new System.EventHandler(this.comboBoxKota_SelectedIndexChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(461, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(303, 20);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.Visible = false;
            // 
            // labelCountFill
            // 
            this.labelCountFill.AutoSize = true;
            this.labelCountFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountFill.Location = new System.Drawing.Point(461, 0);
            this.labelCountFill.Name = "labelCountFill";
            this.labelCountFill.Size = new System.Drawing.Size(303, 26);
            this.labelCountFill.TabIndex = 16;
            this.labelCountFill.Text = "Total Data :";
            this.labelCountFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBatal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSimpan, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 32);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // UC_Sekolah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.dataGridViewSekolah);
            this.Controls.Add(this.label1);
            this.Name = "UC_Sekolah";
            this.Size = new System.Drawing.Size(800, 351);
            this.Load += new System.EventHandler(this.UC_Sekolah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSekolah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).EndInit();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSekolah;
        private System.Windows.Forms.BindingSource sekolahBindingSource;
        private SekolahDBDataSet sekolahDBDataSet;
        private SekolahDBDataSetTableAdapters.SekolahTableAdapter sekolahTableAdapter;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn hapus;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelCountFill;
    }
}
