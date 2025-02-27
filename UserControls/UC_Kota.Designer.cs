namespace SchoolAps.UserControls
{
    partial class UC_Kota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Kota));
            this.label1 = new System.Windows.Forms.Label();
            this.labelCari = new System.Windows.Forms.Label();
            this.dataGridViewKota = new System.Windows.Forms.DataGridView();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sekolahDBDataSet = new SchoolAps.SekolahDBDataSet();
            this.kotaTableAdapter = new SchoolAps.SekolahDBDataSetTableAdapters.KotaTableAdapter();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountFill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).BeginInit();
            this.tableLayoutPanelForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DATA KOTA";
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(9, 41);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 3;
            this.labelCari.Text = "Cari :";
            // 
            // dataGridViewKota
            // 
            this.dataGridViewKota.AllowUserToAddRows = false;
            this.dataGridViewKota.AllowUserToDeleteRows = false;
            this.dataGridViewKota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKota.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewKota.MultiSelect = false;
            this.dataGridViewKota.Name = "dataGridViewKota";
            this.dataGridViewKota.ReadOnly = true;
            this.dataGridViewKota.RowHeadersVisible = false;
            this.dataGridViewKota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKota.Size = new System.Drawing.Size(771, 150);
            this.dataGridViewKota.TabIndex = 4;
            this.dataGridViewKota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKota_CellContentClick);
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "Kota";
            this.kotaBindingSource.DataSource = this.sekolahDBDataSetBindingSource;
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
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(46, 38);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(154, 20);
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
            this.buttonBatal.TabIndex = 8;
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
            this.buttonSimpan.TabIndex = 9;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxID.Location = new System.Drawing.Point(461, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(303, 20);
            this.textBoxID.TabIndex = 16;
            this.textBoxID.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(10, 10);
            this.btnRefresh.Location = new System.Drawing.Point(756, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 20);
            this.btnRefresh.TabIndex = 18;
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
            this.tableLayoutPanelForm.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.labelCountFill, 3, 0);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(12, 224);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowCount = 1;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(767, 27);
            this.tableLayoutPanelForm.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountFill
            // 
            this.labelCountFill.AutoSize = true;
            this.labelCountFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountFill.Location = new System.Drawing.Point(461, 0);
            this.labelCountFill.Name = "labelCountFill";
            this.labelCountFill.Size = new System.Drawing.Size(303, 27);
            this.labelCountFill.TabIndex = 17;
            this.labelCountFill.Text = "Total Data :";
            this.labelCountFill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(385, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBatal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSimpan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxID, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 32);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // UC_Kota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.dataGridViewKota);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.label1);
            this.Name = "UC_Kota";
            this.Size = new System.Drawing.Size(800, 351);
            this.Load += new System.EventHandler(this.UC_Kota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekolahDBDataSet)).EndInit();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.DataGridView dataGridViewKota;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private System.Windows.Forms.BindingSource sekolahDBDataSetBindingSource;
        private SekolahDBDataSet sekolahDBDataSet;
        private SekolahDBDataSetTableAdapters.KotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxID;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCountFill;
    }
}
