using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class MenuUtama : Form
    {
        Barang barang = new Barang();
        List<Barang> DataBarang = new List<Barang>();
        public int minHargaCari = 0;
        public int maxHargaCari = 0;
        //public Panel P;
        public MenuUtama()
        {
            InitializeComponent();
        }


        void addDataBarang()
        {
            this.DataBarang.Add(new Barang("Baju Supreme", 500000, "Baju"));
            this.DataBarang.Add(new Barang("Hoodie", 300000, "Baju"));
            this.DataBarang.Add(new Barang("Laptop Lenovo", 100000, "Elektronik"));
            this.DataBarang.Add(new Barang("Hp Xiaomi", 1000000, "Elektronik"));
            this.DataBarang.Add(new Barang("Nasi Padang", 200000, "Makanan"));
            this.DataBarang.Add(new Barang("Nasi Goreng", 450000, "Makanan"));

        }
        
        void LoadDataBarang()
        {
            flCatalog.Controls.Clear();

            foreach (var data in DataBarang)
            {
                Panel P = addPanel(data.namaBarang, data.hargaBarang);
                flCatalog.Controls.Add(P);
            }
        }
        private void MenuUtama_Load(object sender, EventArgs e)
        {
            addDataBarang();
            LoadDataBarang();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadDataBarang();
        }
        private void btnWebCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shopee.co.id/");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Visible = false;
        }

        Panel addPanel(string namaBarang, int hargaBarang)
        {
            Panel P = new Panel();
            P.Name = "panel" + namaBarang;
            //P.Text = "panel";
            P.ForeColor = Color.Black;
            P.BackColor = Color.Lavender;
            P.Font = new Font("Verdana", 12, FontStyle.Bold);
            P.Width = 200;
            P.Height = 200;
            //Picture Box
            PictureBox pbx = addPictureBox();
            P.Controls.Add(pbx);
            //Label Nama Barang
            Label ln = addLabelNama(namaBarang);
            P.Controls.Add(ln);
            //Label Harga Barang
            Label lh = addLabelHarga(hargaBarang);
            P.Controls.Add(lh);
            //Button Beli
            Button btn = addButtonBeli();
            P.Controls.Add(btn);
            btn.Click += new EventHandler(btnBeli_Click);

            return P;
        }

        Label addLabelNama(string NamaBarang)
        {
            Label l = new Label();
            l.Name = "lbl" + NamaBarang;
            l.Text = NamaBarang;
            l.ForeColor = Color.Black;
            l.BackColor = Color.SteelBlue;
            l.Font = new Font("Verdana", 9, FontStyle.Bold);
            l.Padding = new Padding(0);
            l.Dock = DockStyle.Bottom;
            l.TextAlign = ContentAlignment.MiddleCenter;

            return l;
        }

        Label addLabelHarga(int HargaBarang)
        {
            Label l = new Label();
            l.Name = "lblHarga" + HargaBarang.ToString();
            l.Text = "Rp." + HargaBarang.ToString();
            l.ForeColor = Color.Black;
            l.BackColor = Color.SteelBlue;
            l.Font = new Font("Verdana", 8, FontStyle.Bold);
            l.Padding = new Padding(0);
            l.Dock = DockStyle.Bottom;
            l.TextAlign = ContentAlignment.MiddleCenter;

            return l;
        }

        Button addButtonBeli()
        {
            Button b = new Button();
            b.Name = "btnBeli";
            b.Text = "Beli";
            b.ForeColor = Color.Black;
            b.BackColor = Color.LightGray;
            b.Font = new Font("ArialRoundedMT", 8, FontStyle.Bold);
            b.Padding = new Padding(0);
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Dock = DockStyle.Bottom;
            b.Click += new EventHandler(btnBeli_Click);

            return b;
        }

        PictureBox addPictureBox()
        {
            PictureBox p = new PictureBox();
            p.Image = Properties.Resources.icons8_clothes_127px;
            p.Dock = DockStyle.Fill ;
            p.SizeMode = PictureBoxSizeMode.CenterImage;

            return p;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

            flCatalog.Controls.Clear();
            string jenisCari = Convert.ToString(cbxJenis.SelectedItem);
            string hargaCari = Convert.ToString(cbxRange.SelectedItem);

            //Menentukan Range Harga
            if (hargaCari == "100rb - 200rb")
            {
                minHargaCari = 100000;
                maxHargaCari = 200000;
            }
            else if(hargaCari == "200rb - 500rb")
            {
                minHargaCari = 200000;
                maxHargaCari = 500000;
            }
            else if (hargaCari == "500rb - 1jt")
            {
                minHargaCari = 500000;
                maxHargaCari = 1000000;
            }

            //Tampilkan Search Barang
            foreach (var data in DataBarang)
            {
                if ((data.jenisBarang == jenisCari) && (data.hargaBarang >= minHargaCari) && (data.hargaBarang <= maxHargaCari))
                {
                    Panel P = addPanel(data.namaBarang, data.hargaBarang);
                    flCatalog.Controls.Add(P);

                }
            }

        }
        private void btnBeli_Click(object sender, EventArgs e)
        {
            MenuDetail menu = new MenuDetail();
            menu.Show();
            this.Visible = false;
        }

    }
}
