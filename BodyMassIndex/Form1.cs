using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class Form1 : Form
    {

        float bmi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Male");

            for (int i = 6; i <= 120; i++)
            {
                cmbAge.Items.Add(i);
            }

            for (int i = 30; i <= 240; i++)
            {
                cmbWeight.Items.Add(i);
            }

            for (int i = 100; i <= 260; i++)
            {
                cmbTall.Items.Add(i);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //lbBMI.Text = Convert.ToString(Convert.ToDouble(cmbWeight.Text) / (float)Math.Pow(Convert.ToInt32(cmbTall.Text) / 100, 2));

            var boyKare = (float)Math.Pow((Convert.ToDouble(cmbTall.Text) / 100), 2);
            var agirlik = Convert.ToDouble(cmbWeight.Text);
            var sonuc = agirlik / boyKare;
            lbBMI.Text = "Boy Kilo Endeksiniz (BMI) "+ string.Format("{0:0.#}",sonuc) + " kg/m2";

            int age = Convert.ToInt32(cmbAge.Text);
            if (age>=19 || age<=24)
            {
                if (sonuc >= 19 || sonuc <= 24)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }
            else if (age >= 25 || age <= 34)
            {
                if (sonuc >= 20 || sonuc <= 25)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }
            else if (age >= 35 || age <= 44)
            {
                if (sonuc >= 21 || sonuc <= 26)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }
            else if (age >= 45 || age <= 54)
            {
                if (sonuc >= 22 || sonuc <= 27)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }
            else if (age >= 55 || age <= 65)
            {
                if (sonuc >= 23 || sonuc <= 28)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }
            else //+65 Age
            {
                if (sonuc >= 24 || sonuc <= 29)
                {
                    lbDesicion.Text = "Harikasın! Tam da ideal kilondasın!";
                }
                else
                {
                    lbDesicion.Text = "İdeal Kilonun Üzerinde";
                }
            }

        }
    }
}
