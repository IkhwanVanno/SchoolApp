namespace SchoolAps.UserControls
{
    partial class UC_Siswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Siswa));
            this.labelJudul = new System.Windows.Forms.Label();
            this.dataGridViewSiswa = new System.Windows.Forms.DataGridView();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDBDataSet = new SchoolAps.SekolahDBDataSet();
            this.siswaTableAdapter = new SchoolAps.SekolahDBDataSetTableAdapters.SiswaTableAdapter();
            this.labelCari = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelSekolah = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxSekolah = new System.Windows.Forms.ComboBox();
            this.comboBoxKota = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.siswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.labelCountFill = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uCSiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource2)).BeginInit();
            this.tableLayoutPanelForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uCSiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(13, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(102, 21);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "DATA SISWA";
            // 
            // dataGridViewSiswa
            // 
            this.dataGridViewSiswa.AllowUserToAddRows = false;
            this.dataGridViewSiswa.AllowUserToDeleteRows = false;
            this.dataGridViewSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiswa.Location = new System.Drawing.Point(17, 89);
            this.dataGridViewSiswa.MultiSelect = false;
            this.dataGridViewSiswa.Name = "dataGridViewSiswa";
            this.dataGridViewSiswa.ReadOnly = true;
            this.dataGridViewSiswa.RowHeadersVisible = false;
            this.dataGridViewSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiswa.Size = new System.Drawing.Size(767, 150);
            this.dataGridViewSiswa.TabIndex = 1;
            this.dataGridViewSiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiswa_CellContentClick);
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.sekolahDBDataSetBindingSource;
            // 
            // sekolahDBDataSetBindingSource
            // 
            this.sekolahDBDataSetBindingSource.DataSource = this.sekolahDBDataSet;
            this.sekolahDBDataSetBindingSource.Position = 0;
            // 
            // sekolahDBDataSet
            // 
            this.sekolahDBDataSet.DataSetName = "SekolahDBDataSet";
            this.sekolahDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(14, 63);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 2;
            this.labelCari.Text = "Cari :";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNama.Location = new System.Drawing.Point(3, 0);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(70, 27);
            this.labelNama.TabIndex = 3;
            this.labelNama.Text = "Nama :";
            this.labelNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSekolah
            // 
            this.labelSekolah.AutoSize = true;
            this.labelSekolah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSekolah.Location = new System.Drawing.Point(3, 27);
            this.labelSekolah.Name = "labelSekolah";
            this.labelSekolah.Size = new System.Drawing.Size(70, 27);
            this.labelSekolah.TabIndex = 4;
            this.labelSekolah.Text = "Sekolah :";
            this.labelSekolah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKota.Location = new System.Drawing.Point(3, 54);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(70, 29);
            this.labelKota.TabIndex = 5;
            this.labelKota.Text = "Kota :";
            this.labelKota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(51, 60);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(178, 20);
            this.textBoxCari.TabIndex = 6;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNama.Location = new System.Drawing.Point(79, 3);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(300, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // comboBoxSekolah
            // 
            this.comboBoxSekolah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSekolah.FormattingEnabled = true;
            this.comboBoxSekolah.Location = new System.Drawing.Point(79, 30);
            this.comboBoxSekolah.Name = "comboBoxSekolah";
            this.comboBoxSekolah.Size = new System.Drawing.Size(300, 21);
            this.comboBoxSekolah.TabIndex = 8;
            // 
            // comboBoxKota
            // 
            this.comboBoxKota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKota.FormattingEnabled = true;
            this.comboBoxKota.Location = new System.Drawing.Point(79, 57);
            this.comboBoxKota.Name = "comboBoxKota";
            this.comboBoxKota.Size = new System.Drawing.Size(300, 21);
            this.comboBoxKota.TabIndex = 9;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Location = new System.Drawing.Point(461, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(303, 20);
            this.textBoxID.TabIndex = 12;
            this.textBoxID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(385, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // siswaBindingSource1
            // 
            this.siswaBindingSource1.DataMember = "Siswa";
            this.siswaBindingSource1.DataSource = this.sekolahDBDataSetBindingSource;
            // 
            // siswaBindingSource2
            // 
            this.siswaBindingSource2.DataMember = "Siswa";
            this.siswaBindingSource2.DataSource = this.sekolahDBDataSetBindingSource;
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
            this.btnRefresh.Location = new System.Drawing.Point(757, 63);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 20);
            this.btnRefresh.TabIndex = 14;
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
            this.tableLayoutPanelForm.Controls.Add(this.labelCountFill, 3, 0);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxKota, 1, 2);
            this.tableLayoutPanelForm.Controls.Add(this.labelKota, 0, 2);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxSekolah, 1, 1);
            this.tableLayoutPanelForm.Controls.Add(this.labelSekolah, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.labelNama, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxID, 3, 1);
            this.tableLayoutPanelForm.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(17, 255);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowCount = 3;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(767, 83);
            this.tableLayoutPanelForm.TabIndex = 15;
            // 
            // labelCountFill
            // 
            this.labelCountFill.AutoSize = true;
            this.labelCountFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountFill.Location = new System.Drawing.Point(461, 0);
            this.labelCountFill.Name = "labelCountFill";
            this.labelCountFill.Size = new System.Drawing.Size(303, 27);
            this.labelCountFill.TabIndex = 15;
            this.labelCountFill.Text = "Total Data :";
            this.labelCountFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(232, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(147, 26);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(79, 3);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(147, 26);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btnBatal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSimpan, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 339);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 32);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // uCSiswaBindingSource
            // 
            this.uCSiswaBindingSource.DataSource = typeof(SchoolAps.UserControls.UC_Siswa);
            // 
            // UC_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.dataGridViewSiswa);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Name = "UC_Siswa";
            this.Size = new System.Drawing.Size(800, 506);
            this.Load += new System.EventHandler(this.UC_Siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource2)).EndInit();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uCSiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.DataGridView dataGridViewSiswa;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private System.Windows.Forms.BindingSource sekolahDBDataSetBindingSource;
        private SekolahDBDataSet sekolahDBDataSet;
        private SekolahDBDataSetTableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelSekolah;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxSekolah;
        private System.Windows.Forms.ComboBox comboBoxKota;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource siswaBindingSource1;
        private System.Windows.Forms.BindingSource siswaBindingSource2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource uCSiswaBindingSource;
        private System.Windows.Forms.Label labelCountFill;
    }
}
