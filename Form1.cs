using SchoolAps.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_Siswa uc = new UC_Siswa();
            addUserControl(uc);
            btnSiswa.PerformClick();
        }
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            UC_Siswa uc = new UC_Siswa();
            addUserControl(uc);
        }

        private void btnSekolah_Click(object sender, EventArgs e)
        {
            UC_Sekolah uc = new UC_Sekolah();
            addUserControl(uc);
        }

        private void btnKota_Click(object sender, EventArgs e)
        {
            UC_Kota uc = new UC_Kota();
            addUserControl(uc);
        }
    }
}
