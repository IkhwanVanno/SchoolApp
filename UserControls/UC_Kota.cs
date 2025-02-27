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
    public partial class UC_Kota : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public UC_Kota()
        {
            InitializeComponent();
        }
        void TambahTombol()
        {

            if (dataGridViewKota.Columns["btnUbah"] == null)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "Ubah";
                btnUbah.Name = "btnUbah";
                btnUbah.Text = "Ubah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewKota.Columns.Add(btnUbah);
            }


            if (dataGridViewKota.Columns["btnHapus"] == null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dataGridViewKota.Columns.Add(btnHapus);
            }
        }

        void TampilBarang()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Kota", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Kota");
                dataGridViewKota.DataSource = ds;
                dataGridViewKota.DataMember = "Kota";
                dataGridViewKota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                TambahTombol();
                int totalRows = dataGridViewKota.Rows.Count;
                labelCountFill.Text = $"Total Data : {totalRows}";
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
        void bersihkan()
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxCari.Text = "";
        }

        void cariKota()
        {
            SqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Kota WHERE Nama LIKE '%" + textBoxCari.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Kota");
                dataGridViewKota.DataSource = ds;
                dataGridViewKota.DataMember = "Kota";
                dataGridViewKota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void UC_Kota_Load(object sender, EventArgs e)
        {
            TampilBarang();
            bersihkan();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            cariKota();
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
            if (textBoxNama.Text == "")
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
                        int kotaID = int.Parse(textBoxID.Text);
                        cmd = new SqlCommand("UPDATE Kota SET Nama = @nama WHERE ID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", kotaID);

                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Kota (Nama) VALUES (@nama)", conn);
                    }

                    cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Disimpan");
                    TampilBarang();
                    bersihkan();
                }
                catch (Exception G)
                {
                    MessageBox.Show($"Data Gagal Disimpan. Error: {G.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void dataGridViewKota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKota.Columns[e.ColumnIndex].Name == "btnHapus")
            {
                if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection conn = Koneksi.GetConn();
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE FROM Kota WHERE ID = '" + dataGridViewKota.Rows[e.RowIndex].Cells["ID"].Value.ToString() + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        TampilBarang();
                        bersihkan();
                    }
                    catch (Exception G)
                    {
                        MessageBox.Show(G.ToString());
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
            else if (dataGridViewKota.Columns[e.ColumnIndex].Name == "btnUbah")
            {
                try
                {
                    DataGridViewRow row = this.dataGridViewKota.Rows[e.RowIndex];
                    textBoxID.Text = row.Cells["ID"].Value.ToString();
                    textBoxNama.Text = row.Cells["Nama"].Value.ToString();

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
        }
    }
}
