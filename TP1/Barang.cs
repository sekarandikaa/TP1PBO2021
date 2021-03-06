using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        public string namaBarang { get; set; }
        public int hargaBarang { get; set; }
        public string jenisBarang { get; set; }
        public Barang() { }

        public Barang(string namaBarang, int hargaBarang, string jenisBarang)
        {
            this.namaBarang = namaBarang;
            this.hargaBarang = hargaBarang;
            this.jenisBarang = jenisBarang;
        }
    }
}
