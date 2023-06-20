using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inap
{
    public class Inap
    {
        public string id_jenis_kamar { get; set; }
        public int id_paket_kamar { get; set; }
        public string nama_jenis_kamar { get; set; }
        public string nomor_kamar { get; set; } 
        public decimal harga_paket { get; set; }
        public string deskripsi_paket { get; set; }
        public int status { get; set; }

    }
}
