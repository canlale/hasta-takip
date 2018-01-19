using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Erkek");
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateTimePicker1.Value;

            HastaTakip hasta = new HastaTakip
            {
                adi = txtad.Text,
                ucret = Convert.ToInt32(txtucret.Text),
                dogumyili = dogumTarihi.Year,
                cisiyet = comboBox1.Text,
            };
            hasta.YasHesapla();
            hasta.IndirimliUcretHesapla();

            
            dataGridView1.Rows.Add(hasta.adi, hasta.dogumyili,hasta.cisiyet, hasta.ucret, hasta.indirimliucrt, hasta.yas);
        }
    }
}
