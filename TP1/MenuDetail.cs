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
    public partial class MenuDetail : Form
    {

        public MenuDetail()
        {
            InitializeComponent();
        }

        private void MenuDetail_Load(object sender, EventArgs e)
        {
            Panel P = addPanel();
            flDetail.Controls.Add(P);
        }

        Panel addPanel()
        {
            Panel P = new Panel();
            P.Name = "panel";
            P.Text = "panel";
            P.ForeColor = Color.Black;
            P.BackColor = Color.Lavender;
            P.Font = new Font("Verdana", 12, FontStyle.Bold);
            P.Width = 200;
            P.Height = 200;
            //Picture Box
            PictureBox pbx = addPictureBox();
            P.Controls.Add(pbx);
            //Label Nama Barang
            Label ln = addLabelNama();
            P.Controls.Add(ln);
            //Label Harga Barang
            Label lh = addLabelHarga();
            P.Controls.Add(lh);

            return P;
        }

        Label addLabelNama()
        {
            Label l = new Label();
            l.Name = "lbl";
            l.Text = "Baju Supreme";
            l.ForeColor = Color.Black;
            l.BackColor = Color.SteelBlue;
            l.Font = new Font("Verdana", 10, FontStyle.Bold);
            l.Dock = DockStyle.Bottom;
            l.TextAlign = ContentAlignment.MiddleCenter;

            return l;
        }

        Label addLabelHarga()
        {
            Label l = new Label();
            l.Name = "lbl";
            l.Text = "Rp.500000";
            l.ForeColor = Color.Black;
            l.BackColor = Color.SteelBlue;
            l.Font = new Font("Verdana", 9, FontStyle.Bold);
            l.Dock = DockStyle.Bottom;
            l.TextAlign = ContentAlignment.MiddleCenter;

            return l;
        }
        PictureBox addPictureBox()
        {
            PictureBox p = new PictureBox();
            p.Image = Properties.Resources.icons8_clothes_127px;
            p.Dock = DockStyle.Fill;
            p.SizeMode = PictureBoxSizeMode.CenterImage;

            return p;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MenuUtama menu = new MenuUtama();
            menu.Show();
            this.Visible = false;
        }
    }
}
