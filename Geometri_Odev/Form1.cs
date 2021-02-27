using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometri_Odev.Classes;

namespace Geometri_Odev
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cbDaire_CheckedChanged(object sender, EventArgs e)
        {
            cbDikUcgen.Checked = false;
            cbKare.Checked = false;
            cbDikdortgen.Checked = false;
            cbEskenarUcgen.Checked = false;

            lbTaban.Visible = false;
            lbYukseklik.Visible = false;
            tbTaban.Visible = false;
            tbYukseklik.Visible = false;

            lYaricap.Visible = true;
            tbYariCap.Visible = true;


        }

        

        private void btnHesap_Click(object sender, EventArgs e)
        {
            if (!(cbEskenarUcgen.Checked || cbDikUcgen.Checked || cbDikdortgen.Checked || cbDaire.Checked || cbKare.Checked))
            {
                MessageBox.Show("Lütfen boş seçim yapmayınız!", "Hata!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            if (tbTaban.Text.Trim() == "" || tbYukseklik.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş seçim yapmayınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbKare.Checked)
                {
                    Dikdortgen_Kare kare = new Dikdortgen_Kare();

                    kare.Taban = Convert.ToDouble(tbTaban.Text);
                    kare.Yukseklik = Convert.ToDouble(tbYukseklik.Text);

                    lbAlan.Text = kare.AlanHesapla().ToString();
                    lbCevre.Text = kare.CevreHesapla().ToString();
                }

                if (cbDikdortgen.Checked)
                {
                    Dikdortgen_Kare dikdortgen = new Dikdortgen_Kare();

                    dikdortgen.Taban = Convert.ToDouble(tbTaban.Text);
                    dikdortgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);

                    lbAlan.Text = dikdortgen.AlanHesapla().ToString();
                    lbCevre.Text = dikdortgen.CevreHesapla().ToString();
                }

                if (cbDikUcgen.Checked)
                {
                    DikUcgen dikucgen = new DikUcgen();

                    dikucgen.Taban = Convert.ToDouble(tbTaban.Text);
                    dikucgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);

                    lbAlan.Text = dikucgen.AlanHesapla().ToString();
                    lbCevre.Text = dikucgen.CevreHesapla().ToString();
                }

                if (cbEskenarUcgen.Checked)
                {
                    EskenarUcgen eskenarUcgen = new EskenarUcgen();

                    eskenarUcgen.Taban = Convert.ToDouble(tbTaban.Text);
                    eskenarUcgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text);

                    lbAlan.Text = eskenarUcgen.AlanHesapla().ToString();
                    lbCevre.Text = eskenarUcgen.CevreHesapla().ToString();
                }


                if (cbDaire.Checked)
                {
                    Daire daire = new Daire();

                    daire.YariCap = Convert.ToDouble(tbYariCap.Text);

                    lbAlan.Text = daire.AlanHesapla().ToString();
                    lbCevre.Text = daire.CevreHesapla().ToString();

                }
            }
           
        }

        private void cbKare_CheckedChanged(object sender, EventArgs e)
        {
            lbTaban.Visible = true;
            lbYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbEskenarUcgen.Checked = false;
            cbDikUcgen.Checked = false;
            cbDaire.Checked = false;
            cbDikdortgen.Checked = false;
            
        }

        private void cbDikUcgen_CheckedChanged(object sender, EventArgs e)
        {
            lbTaban.Visible = true;
            lbYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbEskenarUcgen.Checked = false;
            cbKare.Checked = false;
            cbDaire.Checked = false;
            cbDikdortgen.Checked = false;
        }

        private void cbEskenarUcgen_CheckedChanged(object sender, EventArgs e)
        {
            lbTaban.Visible = true;
            lbYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbDikUcgen.Checked = false;
            cbKare.Checked = false;
            cbDaire.Checked = false;
            cbDikdortgen.Checked = false;
        }

        private void cbDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            lbTaban.Visible = true;
            lbYukseklik.Visible = true;
            tbTaban.Visible = true;
            tbYukseklik.Visible = true;

            cbDikUcgen.Checked = false;
            cbKare.Checked = false;
            cbDaire.Checked = false;
            cbEskenarUcgen.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            cbDikdortgen.Checked = false;
            cbDikUcgen.Checked = false;
            cbKare.Checked = false;
            cbDaire.Checked = false;
            cbEskenarUcgen.Checked = false;

            tbYariCap.Text = null;
            tbTaban.Text = null;
            tbYukseklik.Text = null;

            lbAlan.Text = null;
            lbCevre.Text = null;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
