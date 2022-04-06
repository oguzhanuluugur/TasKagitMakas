using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int skor = 0;
        int bot = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                bot++;
                label4.Text = bot.ToString();
                label2.Text = "Kaybettiniz";
                button4.BackColor = Color.Red;
            }
            else if (deger == 2)
            {
                skor++;
                label1.Text = skor.ToString();
                label2.Text = "Kazandınız";
                button5.BackColor = Color.Green;
               
            }
            else if (deger == 3)
            {
                label2.Text = "Beraberlik";
                button6.BackColor = Color.Gray;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1,4);
            if (deger == 1)
            {
                label2.Text = "Beraberlik";
                button4.BackColor = Color.Gray;
            }
            else if (deger == 2)
            {
                bot++;
                label4.Text = bot.ToString();
                label2.Text = "Kaybettiniz";
                button5.BackColor = Color.Red;
            }
            else if (deger == 3)
            {
                skor++;
                label1.Text = skor.ToString();
                label2.Text = "Kazandınız";
                button6.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                skor++;
                label1.Text = skor.ToString();
                label2.Text = "Kazandınız";
                button4.BackColor = Color.Green;
            }
            else if (deger == 2)
            {
                label2.Text = "Beraberlik";
                button5.BackColor = Color.Gray;
            }
            else if (deger == 3)
            {
                bot++;
                label4.Text = bot.ToString();
                label2.Text = "Kaybettiniz";
                button6.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bot == 3)
            {
                label2.Text = "Bilgisayar Kazandı";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else if (skor == 3)
            {
                label2.Text = "Oyuncu Kazandı";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }
    }
}
