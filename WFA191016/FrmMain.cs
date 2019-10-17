using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191016
{
    public partial class FrmMain : Form
    {
        List<Vendeg> vendegek;
        public FrmMain()
        {
            InitializeComponent();
            Beolvas();
            CbNevekFeltolt();
        }

        private void CbNevekFeltolt()
        {
            foreach (var v in vendegek)
            {
                cbNevek.Items.Add(v.Nev);
            }
        }

        private void Beolvas()
        {
            vendegek = new List<Vendeg>();
            var sr = new StreamReader("vendegek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                vendegek.Add(new Vendeg(sr.ReadLine()));
            }
            sr.Close();
        }

        private void cbNevek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
