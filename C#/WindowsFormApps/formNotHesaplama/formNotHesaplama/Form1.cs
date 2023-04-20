using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if(textBoxVize.Text == "" || textBoxVizeY.Text == "" || textBoxFinal.Text == "" || textBoxGecmeN.Text == "")
            {
                string baslik = "Uyarı!";
                string metin = "Lütfen tüm alanları doldurunuz ya da doğru değer giriniz!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(metin, baslik, button , icon);
            }
            else
            {
                byte vize, final;
                int vizeYuzdeUser, finalYuzdeUser;
                double ort, vizeYuzde, finalYuzde, gecmeNotu;
                string durum;

                vize = Convert.ToByte(textBoxVize.Text);
                vizeYuzdeUser = int.Parse(textBoxVizeY.Text);
                vizeYuzde = (double)vizeYuzdeUser / 100;

                final = Convert.ToByte(textBoxFinal.Text);
                finalYuzdeUser = 100 - vizeYuzdeUser;
                textBoxFinalY.Text = finalYuzdeUser.ToString();
                finalYuzde = (double)finalYuzdeUser / 100;

                gecmeNotu = Convert.ToDouble(textBoxGecmeN.Text);
                ort = vize * vizeYuzde + final * finalYuzde;

                if (ort >= gecmeNotu && final >= gecmeNotu)
                {
                    durum = "Geçtiniz";
                }
                else
                {
                    durum = "Kaldınız";
                }

                labelOrtValue.Text = ort.ToString();
                labelDurumValue.Text = durum;
            }
        }
    }
}