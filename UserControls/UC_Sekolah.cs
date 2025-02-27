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
    public partial class UC_Sekolah : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public UC_Sekolah()
        {
            InitializeComponent();
        }
        void TambahTombol()
        {

            if (dataGridViewSekolah.Columns["btnUbah"] == null)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "Ubah";
                btnUbah.Name = "btnUbah";
                btnUbah.Text = "Ubah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewSekolah.Columns.Add(btnUbah);
            }


            if (dataGridViewSekolah.Columns["btnHapus"] == null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dataGridViewSekolah.Columns.Add(btnHapus);
            }
        }
        void tampilSekolah()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                String query = @"
                    SELECT 
                        Sekolah.ID AS 'ID Sekolah',
                        Sekolah.Nama AS 'Nama Sekolah',
                        Kota.Nama AS 'Nama Kota'
                    FROM 
                        Sekolah
                    INNER JOIN 
                        Kota ON Sekolah.KotaID = Kota.ID";
                cmd = new SqlCommand(query, conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Sekolah");
                dataGridViewSekolah.DataSource = ds;
                dataGridViewSekolah.DataMember = "Sekolah";
                dataGridViewSekolah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TambahTombol();
                int totalRows = dataGridViewSekolah.Rows.Count;
                labelCountFill.Text = $"Total Data : {totalRows}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void bersihkan()
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxCari.Text = "";
            comboBoxKota.SelectedIndex = -1;
        }

        void cariSekolah()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Sekolah WHERE Nama LIKE '%" + textBoxCari.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Sekolah");
                dataGridViewSekolah.DataSource = ds;
                dataGridViewSekolah.DataMember = "Sekolah";
                dataGridViewSekolah.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void UC_Sekolah_Load(object sender, EventArgs e)
        {
            tampilSekolah();
            bersihkan();
            MunculComboKota();
            dataGridViewSekolah.ReadOnly = true;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cariSekolah();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Data Belum Diisi");
            }
            else
            {
                if (MessageBox.Show("Apakah Anda Yakin Ingin Membatalkan?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bersihkan();
                }
                else
                {
                    textBoxNama.Focus();
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "" || comboBoxKota.SelectedIndex == -1)
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection conn = Koneksi.GetConn();
                try
                {
                    conn.Open();
                    string nama = textBoxNama.Text;
                    int kotaID = (int)comboBoxKota.SelectedValue;
                    if (!string.IsNullOrEmpty(textBoxID.Text)) 
                    {
                        int sekolahID = int.Parse(textBoxID.Text); 
                        cmd = new SqlCommand("UPDATE Sekolah SET Nama = @nama, KotaID = @kota WHERE ID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", sekolahID);
                        cmd.Parameters.AddWithValue("@kota", kotaID);
                    }
                    else 
                    {
                        cmd = new SqlCommand("INSERT INTO Sekolah (Nama, KotaID) VALUES (@nama, @kotaID)", conn);
                    }

                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@kotaID", kotaID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Disimpan");
                    tampilSekolah();
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

        private void dataGridViewSekolah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSekolah.Columns[e.ColumnIndex].Name == "btnhapus")
            {
                DialogResult dialog = MessageBox.Show("Yakin Ingin Menghapus?", "Hapus", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = Koneksi.GetConn();
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE FROM Sekolah WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", textBoxID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        tampilSekolah();
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
            else if (dataGridViewSekolah.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                try
                {
                    DataGridViewRow row = this.dataGridViewSekolah.Rows[e.RowIndex];
                    textBoxID.Text = row.Cells["ID Sekolah"].Value.ToString();
                    textBoxNama.Text = row.Cells["Nama Sekolah"].Value.ToString();
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
            tampilSekolah();
            bersihkan();
            MunculComboKota();
        }
    }
}
