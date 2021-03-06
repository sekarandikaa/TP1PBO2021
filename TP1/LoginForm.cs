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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "pbo123")
            {
                MenuUtama menu = new MenuUtama();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Gagal Login!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
