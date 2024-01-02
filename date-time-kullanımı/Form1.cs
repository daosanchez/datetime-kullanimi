using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_time_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinValue_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "En Küçük: " + DateTime.MinValue;
            
        }

        private void btnMaxValue_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "En Büyük: " + DateTime.MaxValue;
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Now  : " + DateTime.Now;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Today: " + DateTime.Today;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2024, 3, 9);


            lblMesaj.Text = "Tarih: " + bugun.ToShortDateString();
            lblMesaj2.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }
    }
}
