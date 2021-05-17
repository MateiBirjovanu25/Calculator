using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool on = false;
        double nr;
        double nr1;
        int k = 0;
        int t = 0;
        
        private void butonof_Click(object sender, EventArgs e)
        {
            text.Text = "";
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 1;

        }

        private void buton2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 2;

        }

        private void buton3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 3;

        }

        private void buton4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 4;

        }

        private void buton5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 5;

        }

        private void buton6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 6;

        }

        private void buton7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 7;

        }

        private void buton8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 8;
        }

        private void buton9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 9;
        }

        private void buton0_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + 0;
        }


        private void butonpl_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0)
                {
                    butonpl.BackColor = button.BackColor;
                    nr1 = Convert.ToDouble(text.Text);
                    text.Text = "";
                    k = 1;
                }
            }
            catch { }
        }

        private void butonmi_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0)
                {
                    butonmi.BackColor = button.BackColor;
                    nr1 = Convert.ToDouble(text.Text);
                    text.Text = "";
                    k = 2;
                }
            }
            catch {  }
        }



        private void butonin_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0)
                {
                    butonin.BackColor = button.BackColor;
                    nr1 = Convert.ToDouble(text.Text);
                    text.Text = "";
                    k = 3;
                }
            }
            catch { }
        }

        private void butondi_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0)
                {
                    butondi.BackColor = button.BackColor;
                    nr1 = Convert.ToDouble(text.Text);
                    text.Text = "";
                    k = 4;
                }
            }
            catch { }
        }

        private void butonmo_Click(object sender, EventArgs e)
        {
            try
            {
                if (k == 0)
                {
                    butonmo.BackColor = button.BackColor;
                    nr1 = Convert.ToDouble(text.Text);
                    text.Text = "";
                    k = 5;
                }
            }
            catch { }
        }

        private void butonln_Click(object sender, EventArgs e)
        {
            //nr = Convert.ToInt32(text.Text);
            //text.Text=Convert.ToString(Math.Log(nr)); 
            try
            {
                if (text.Text.Length > 0 && text.Text[text.Text.Length - 1] != '.' && t == 0)
                {
                    text.Text = text.Text + '.';
                    t = 1;
                }
            }
            catch { }

        }

        private void butonsq_Click(object sender, EventArgs e)
        {
            nr = Convert.ToDouble(text.Text);
            text.Text = Convert.ToString(Math.Sqrt(nr));
        }

        private void butonfa_Click(object sender, EventArgs e)
        {
            try
            {
                nr = Convert.ToDouble(text.Text);
                text.Text = Convert.ToString(factorial.f(nr));
            }
            catch { }
        }

        private void butoneg_Click(object sender, EventArgs e)
        {
            try
            {
                nr = Convert.ToDouble(text.Text);
                if (k == 1)
                    nr1 = nr1 + nr;
                if (k == 2)
                    nr1 = nr1 - nr;
                if (k == 3)
                    nr1 = nr1 * nr;
                if (k == 4)
                    nr1 = nr1 / nr;
                if (k == 5)
                    nr1 = nr1 % nr;

                k = 0;

                t = 0;

                text.Text = Convert.ToString(nr1);

                butonpl.BackColor = Color.Orange;
                butonmi.BackColor = Color.Orange;
                butondi.BackColor = Color.Orange;
                butonmo.BackColor = Color.Orange;
                butonin.BackColor = Color.Orange;
            }
            catch { }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
