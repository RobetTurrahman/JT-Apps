using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inap
{
    public partial class Edit_detail_penginapan : Form
    {
        //private string connectionString = "host=localhost;port=5432;database=db1;user id=postgres;password=robet123";
        //public string queryCommand;
        //private void LoadDataFromDatabase()
        //{
        //    using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        using (NpgsqlCommand comm = new NpgsqlCommand())
        //        {
        //            comm.Connection = conn;
        //            comm.CommandType = CommandType.Text;
        //            comm.CommandText = $"select * from \"Paket_Kamar\" pk join \"Jenis_Kamar\" jk on pk.\"id_jenis_kamar\" = jk.\"id_jenis_kamar\" where jk.\"id_jenis_kamar\" = 'SR01'";
        //            NpgsqlDataReader reader = comm.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                //pictureBox1.Image = reader[""]
        //                textboxjudul.Text += reader["nama_jenis_kamar"].ToString() + Environment.NewLine;
        //                textboxnokamar.Text = reader["nomor_kamar"].ToString() + Environment.NewLine;
        //                textboxfasilitas.Text += reader["deskripsi_paket"].ToString() + Environment.NewLine;
        //                textboxharga.Text += reader["harga_paket"].ToString() + Environment.NewLine;
        //                textboxstatus.Text += reader["status"].ToString() + Environment.NewLine;

        //            }

        //            reader.Close();
        //        }
        //    }
        //}
        Form1 form1 = new Form1();

        public Edit_detail_penginapan()
        {
            InitializeComponent();
            //LoadDataFromDatabase();

        }

        private void Edit_detail_penginapan_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kapasitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void Keterangan1_Click(object sender, EventArgs e)
        {

        }

        private void Judul_TextChanged(object sender, EventArgs e)
        {

        }

        private void harga1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
        public void SetInap(Inap inap)
        {
            //Codingan set tiap textbox dan komponen lainnya sesuai objek newsletternya
            //pbpenginapan.Text = inap.;
            tbjudul.Text = inap.nama_jenis_kamar;
            tbnokamar.Text = inap.nomor_kamar;
            tbfasilitas.Text = inap.deskripsi_paket;
            tbharga.Text = inap.harga_paket.ToString();
            tbstatus.Text = inap.status.ToString();

        }
    }
}
