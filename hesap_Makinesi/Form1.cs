using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result;
        double constant = 0.0124;
        double constant2 = 0.074;
        double constant3 = 1.0;
        double constant4 = 6.2;
        double n;
        double s;
        double l;
        private void Clear()
        {
            txtL.Clear();
            txtN.Clear();
            txtS.Clear();
            cmbfase.Text = "";
            cmbSystemVarient.Text = "";
            cmbvoltage.Text = "";
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                int voltage = Convert.ToInt32(cmbvoltage.Text);
                int fase = Convert.ToInt32(cmbfase.Text);
   
                if (txtN.Text.Contains("."))
                {
                    MessageBox.Show("LÜTFEN , KULLANINIZ");
                    Clear();
                   
                }
                else
                {
                     n = Convert.ToDouble(txtN.Text);
                }

                if (txtL.Text.Contains("."))
                {
                    MessageBox.Show("LÜTFEN , KULLANINIZ");
                    Clear();

                }
                else
                {
                    l = Convert.ToDouble(txtL.Text);
                }



                if (txtS.Text.Contains("."))
                {
                    MessageBox.Show("LÜTFEN , KULLANINIZ");
                    Clear();

                }
                else
                {
                    s = Convert.ToDouble(txtS.Text);
                }



                //380V ve trifaze olduğu zaman
                if (voltage == 380 && fase == 3)
                {

                    result = (constant * l * n) / s;
                }
                if (cmbSystemVarient.Text == "AYDINLATMA VE PRİZ")
                {
                    if (result < 1.5)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }
                if (cmbSystemVarient.Text == "MOTOR")
                {
                    if (result < 3.0)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }


                //220V ve monofaze olduğu zaman

                if (voltage == 220 && fase == 1)
                {

                    result = (constant2 * l * n) / s;
                }

                if (cmbSystemVarient.Text == "AYDINLATMA VE PRİZ")
                {
                    if (result < 1.5)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }
                if (cmbSystemVarient.Text == "MOTOR")
                {
                    if (result < 3.0)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }


                //42V ve trifaze olduğu zaman                

                if (voltage == 42 && fase == 3)
                {

                    result = (constant3 * l * n) / s;
                }

                if (cmbSystemVarient.Text == "AYDINLATMA VE PRİZ")
                {
                    if (result < 1.5)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }
                if (cmbSystemVarient.Text == "MOTOR")
                {
                    if (result < 3.0)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }

                //24V ve monofaze olduğu zaman

                if (voltage == 24 && fase == 1)
                {

                    result = (constant4 * l * n) / s;
                }

                if (cmbSystemVarient.Text == "AYDINLATMA VE PRİZ")
                {
                    if (result < 1.5)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }
                if (cmbSystemVarient.Text == "MOTOR")
                {
                    if (result < 3.0)
                    {
                        txtResult.Text = "KABLO KESİTİ UYGUN";
                        lblresult.Text = result.ToString();
                    }
                    else
                    {
                        txtResult.Text = "KABLO KESİTİNİ ARTTIRINIZ";
                        lblresult.Text = result.ToString();
                    }
                }

                //Hatalar
                if (voltage == 380 && fase == 1)
                {
                    MessageBox.Show("YANLIŞ FAZ SEÇİMİ !", "HATA !");
                    Clear();
                }

                if (voltage == 220 && fase == 3)
                {
                    MessageBox.Show("YANLIŞ FAZ SEÇİMİ !", "HATA !");
                    Clear();
                }

                if (voltage == 42 && fase == 1)
                {
                    MessageBox.Show("YANLIŞ FAZ SEÇİMİ !", "HATA !");
                    Clear();
                }

                if (voltage == 24 && fase == 3)
                {
                    MessageBox.Show("YANLIŞ FAZ SEÇİMİ !", "HATA !");
                    Clear();
                }

            }

            catch
            {
                MessageBox.Show("Lütfen değerleri eksiksiz giriniz!", "Hata!");
                Clear();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://noktamakina.com");
            ////}

            /*AYDINLATMA VE PRİZ
    MOTOR*/
        }
    }
}
