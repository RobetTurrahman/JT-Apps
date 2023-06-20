using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inap
{
    internal class inapContext
    {
        public List<Inap> listInap = new List<Inap>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = " Host=localhost;Port=5432;Database=JT-Apps;Username=postgres;Password=robet123";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                conn.Open();            
                string sql =
                    @"select * from paket_kamar pk join jenis_kamar jk on pk. jenis_kamar_id_jeniskamar = jk. id_jeniskamar";
                //JOIN wisata ON transaksi.id_wisata = wisata.id_wisata
                //JOIN tiket ON trasaksi.id_tiket = tiket.id_tiket";

                
                using NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader Reader = cmd.ExecuteReader(0);
                    listInap.Clear();
                    while (Reader.Read())
                    {
                        Inap inap1 = new Inap();

                        inap1.id_jenis_kamar = (string)Reader["id_jeniskamar"];
                        inap1.id_paket_kamar = (int)Reader["paket_kamar_id"];
                        inap1.nama_jenis_kamar = (string)Reader["nama_jeniskamar"];
                        inap1.nomor_kamar = (string)Reader["nomor_kamar"];
                        inap1.harga_paket = Decimal.Parse(Reader["harga_paket"].ToString());
                        inap1.deskripsi_paket = (string)Reader["deskripsi_paket"];
                        inap1.status = (int)Reader["status"];


                        listInap.Add(inap1);
                    }
                }
            }
            return isSuccess;
        }
    }
}
