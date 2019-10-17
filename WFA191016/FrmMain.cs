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
            lblAsztal.Text = vendegek[cbNevek.SelectedIndex].Asztal + ". asztal";
            lblKaja.Text = vendegek[cbNevek.SelectedIndex].Vega ? "vega" : "hús";
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            var asz = new Dictionary<int, int>();
            foreach (var v in vendegek)
            {
                if (!asz.ContainsKey(v.Asztal))
                {
                    asz.Add(v.Asztal, 1);
                }
                else asz[v.Asztal]++;
            }

            //var sw2 = new StreamWriter("asd.txt");

            //foreach (KeyValuePair<int, int> kvp in asz)
            //{
            //    sw2.WriteLine(kvp.Key + "->>" + kvp.Value);
            //}

            //var s = "";
            //foreach (var item in asz.Values)
            //{
            //    s += item + " ";
            //}
            //MessageBox.Show(s);

            //sw2.Close();


            //var dic = new Dictionary<string, string[]>();
            //string[] st = { "cat", "pussy", "kitty" };

            //dic.Add("cica", st);

            //MessageBox.Show(dic["cica"][1]);


            if (cbNevek.Items.Contains(tbNev.Text))
            {
                MessageBox.Show("ez a vendég már meg lett hívva!");
            }
            else if(asz[int.Parse(tbAsztal.Text)] >= 5)
            { 
                MessageBox.Show("ez az asztal már tele van");
            }
            else
            {
                var sw = new StreamWriter("vendegek.txt", true, Encoding.UTF8);

                sw.WriteLine(
                    $"{tbNev.Text};" +
                    $"{(rbFerfi.Checked ? "m" : "f")};" +
                    $"{tbAsztal.Text};" +
                    $"{(cbVega.Checked ? "v" : "m")}");
                sw.Close();
                Application.Restart();
            }
        }
    }
}
