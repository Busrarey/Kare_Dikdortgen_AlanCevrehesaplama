using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //karenin alan ve çevresini hesaplama

            int birkenar, karealan, karecevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            karealan = birkenar * birkenar;
            karecevre = birkenar * 4;
            label4.Text = karealan.ToString();
            label5.Text = karecevre.ToString();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
            label2.Text = "Bir Kenar:";
            button4.Visible = true;
            button3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdörtgen";
            panel1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            label2.Text = "Kısa Kenar:";
            button3.Visible = true;
            button4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dikdörtgenin alan ve çevresini hesaplama

            int kisakenar, uzunkenar, dikalan, cevre;
            kisakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);
            dikalan = kisakenar * uzunkenar;
            cevre = (2 * kisakenar) + (2 * uzunkenar);
            label4.Text = dikalan.ToString();
            label5.Text = cevre.ToString();

        }
    }
}
