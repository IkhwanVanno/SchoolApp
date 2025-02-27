namespace SchoolAps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKota = new Guna.UI2.WinForms.Guna2Button();
            this.btnSekolah = new Guna.UI2.WinForms.Guna2Button();
            this.btnSiswa = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(186)))));
            this.pnlHeader.Controls.Add(this.labelTitle);
            this.pnlHeader.Controls.Add(this.picboxLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(49, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(178, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "SMK NEGERI 2 SURABAYA";
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(8, 7);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(35, 28);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnKota, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSekolah, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSiswa, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnKota
            // 
            this.btnKota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(162)))));
            this.btnKota.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKota.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(94)))));
            this.btnKota.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKota.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKota.FillColor = System.Drawing.Color.Empty;
            this.btnKota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKota.ForeColor = System.Drawing.Color.Black;
            this.btnKota.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(116)))));
            this.btnKota.Image = ((System.Drawing.Image)(resources.GetObject("btnKota.Image")));
            this.btnKota.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKota.Location = new System.Drawing.Point(535, 3);
            this.btnKota.Name = "btnKota";
            this.btnKota.Size = new System.Drawing.Size(262, 49);
            this.btnKota.TabIndex = 4;
            this.btnKota.Text = "DATA KOTA";
            this.btnKota.Click += new System.EventHandler(this.btnKota_Click);
            // 
            // btnSekolah
            // 
            this.btnSekolah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(162)))));
            this.btnSekolah.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSekolah.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(94)))));
            this.btnSekolah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSekolah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSekolah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSekolah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSekolah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSekolah.FillColor = System.Drawing.Color.Empty;
            this.btnSekolah.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSekolah.ForeColor = System.Drawing.Color.Black;
            this.btnSekolah.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(116)))));
            this.btnSekolah.Image = ((System.Drawing.Image)(resources.GetObject("btnSekolah.Image")));
            this.btnSekolah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSekolah.Location = new System.Drawing.Point(269, 3);
            this.btnSekolah.Name = "btnSekolah";
            this.btnSekolah.Size = new System.Drawing.Size(260, 49);
            this.btnSekolah.TabIndex = 3;
            this.btnSekolah.Text = "DATA SEKOLAH";
            this.btnSekolah.Click += new System.EventHandler(this.btnSekolah_Click);
            // 
            // btnSiswa
            // 
            this.btnSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(162)))));
            this.btnSiswa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSiswa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(94)))));
            this.btnSiswa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSiswa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSiswa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSiswa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiswa.FillColor = System.Drawing.Color.Empty;
            this.btnSiswa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiswa.ForeColor = System.Drawing.Color.Black;
            this.btnSiswa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(116)))));
            this.btnSiswa.Image = ((System.Drawing.Image)(resources.GetObject("btnSiswa.Image")));
            this.btnSiswa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSiswa.Location = new System.Drawing.Point(3, 3);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new System.Drawing.Size(260, 49);
            this.btnSiswa.TabIndex = 2;
            this.btnSiswa.Text = "DATA SISWA";
            this.btnSiswa.Click += new System.EventHandler(this.btnSiswa_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.Location = new System.Drawing.Point(0, 99);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 371);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSiswa;
        private Guna.UI2.WinForms.Guna2Button btnKota;
        private Guna.UI2.WinForms.Guna2Button btnSekolah;
        private System.Windows.Forms.Panel panelContainer;
    }
}

