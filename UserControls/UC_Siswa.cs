using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    


namespace SchoolAps.UserControls
{
    public partial class UC_Siswa : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        Koneksi Konn = new Koneksi();
        public UC_Siswa()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxCari.Text = "";
            comboBoxKota.SelectedIndex= -1;
            comboBoxSekolah.SelectedIndex = -1;
        }

        void TambahTombol()
        {
            
            if (dataGridViewSiswa.Columns["btnUbah"] == null)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "Ubah";
                btnUbah.Name = "btnUbah";
                btnUbah.Text = "Ubah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewSiswa.Columns.Add(btnUbah);
            }

           
            if (dataGridViewSiswa.Columns["btnHapus"] == null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dataGridViewSiswa.Columns.Add(btnHapus);
            }
        }
        void TampilBarang()
        {
            SqlConnection conn = Koneksi.GetConn(); // Koneksi ke database
            try
            {
                conn.Open();

                // Query dengan INNER JOIN
                string query = @"
            SELECT 
                Siswa.ID AS 'ID Siswa',
                Siswa.Nama AS 'Nama Siswa',
                Sekolah.Nama AS 'Nama Sekolah',
                Kota.Nama AS 'Nama Kota'
            FROM 
                Siswa
            INNER JOIN 
                Sekolah ON Siswa.SekolahID = Sekolah.ID
            INNER JOIN 
                Kota ON Siswa.KotaID = Kota.ID";

                cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "DataSiswa");

                // Mengatur DataSource DataGridView
                dataGridViewSiswa.DataSource = ds;
                dataGridViewSiswa.DataMember = "DataSiswa";
                dataGridViewSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TambahTombol();
                int totalRows = dataGridViewSiswa.Rows.Count;
                labelCountFill.Text = $"Total Data : {totalRows}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void MunculComboSekolah()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Sekolah", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Sekolah");
                comboBoxSekolah.DataSource = ds.Tables["Sekolah"];
                comboBoxSekolah.DisplayMember = "Nama";
                comboBoxSekolah.ValueMember = "ID";
            }
            catch
            {
                MessageBox.Show("Koneksi Gagal");
            }
            finally
            {
                conn.Close();
            }
        }
        void MunculComboKota()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Kota", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Kota");
                comboBoxKota.DataSource = ds.Tables["Kota"];
                comboBoxKota.DisplayMember = "Nama";
                comboBoxKota.ValueMember = "ID";
            }
            catch
            {
                MessageBox.Show("Koneksi Gagal");
            }
            finally
            {
                conn.Close();
            }
        }

        void cariBarang() 
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Siswa WHERE Nama LIKE '%" + textBoxCari.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Siswa");
                dataGridViewSiswa.DataSource = ds;
                dataGridViewSiswa.DataMember = "Siswa";
                dataGridViewSiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch(Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void UC_Siswa_Load(object sender, EventArgs e)
        {
            TampilBarang();
            bersihkan();
            MunculComboSekolah();
            MunculComboKota();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "" || comboBoxKota.Text == "" || comboBoxSekolah.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection conn = Koneksi.GetConn();
                try
                {
                    conn.Open();
                    if (!string.IsNullOrEmpty(textBoxID.Text))
                    {
                        // Update existing data
                        cmd = new SqlCommand("UPDATE Siswa SET Nama = @Nama, SekolahID = @SekolahID, KotaID = @KotaID WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                    }
                    else
                    {
                        // Insert new data
                        cmd = new SqlCommand("INSERT INTO Siswa (Nama, SekolahID, KotaID) VALUES (@Nama, @SekolahID, @KotaID)", conn);
                    }

                    cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@SekolahID", comboBoxSekolah.SelectedValue);
                    cmd.Parameters.AddWithValue("@KotaID", comboBoxKota.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan");
                    TampilBarang();
                    bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Data Gagal Disimpan. Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }



        private void btnBatal_Click(object sender, EventArgs e)
        {
           
            if (textBoxNama.Text == "" || comboBoxKota.Text == "" || comboBoxSekolah.Text == "")
            {
                MessageBox.Show("Data Belum Diisi");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Yakin Ingin Membatalkan?", "Batal", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data Tidak Dibatalkan");
                    textBoxNama.Focus();
                    textBoxCari.Focus();
                    comboBoxKota.Focus();
                    comboBoxSekolah.Focus();
                }
            }   
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cariBarang();
        }

        private void dataGridViewSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSiswa.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                DialogResult dialog = MessageBox.Show("Yakin Ingin Menghapus?", "Hapus", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = Koneksi.GetConn();
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE FROM Siswa WHERE ID = @ID ", conn);
                        cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        TampilBarang();
                        bersihkan();
                    }
                    catch
                    {
                        MessageBox.Show("Data Gagal Dihapus");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Dihapus");
                }
            }
            else if (dataGridViewSiswa.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                try
                {
                    DataGridViewRow row = this.dataGridViewSiswa.Rows[e.RowIndex];
                    textBoxID.Text = row.Cells["ID Siswa"].Value.ToString();
                    textBoxNama.Text = row.Cells["Nama Siswa"].Value.ToString();
                    comboBoxSekolah.Text = row.Cells["Nama Sekolah"].Value.ToString();
                    comboBoxKota.Text = row.Cells["Nama Kota"].Value.ToString();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilBarang();
            bersihkan();
            MunculComboKota();
            MunculComboSekolah();
        }
    }
}
