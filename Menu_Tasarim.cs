using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UygulamaDenemesi;
namespace LotoUygulaması
{
    public partial class Menu_Tasarim : Form
    {
        public Menu_Tasarim()
        {
            InitializeComponent();

        }
        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            // Form Geçiş
            UygulumaCalismaKodları FormGecis = new UygulumaCalismaKodları();
            FormGecis.Show();
            this.Hide();
        }
        private void btnOyunuKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
