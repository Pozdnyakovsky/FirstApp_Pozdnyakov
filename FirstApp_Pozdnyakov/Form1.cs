using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp_Pozdnyakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Активация private void textBox_MC при нажатии кнопки мыши
            textBox1.MouseClick += textBox1_MC;
            textBox2.MouseClick += textBox2_MC;
            textBox3.MouseClick += textBox3_MC;
            textBox4.MouseClick += textBox4_MC;
            textBox5.MouseClick += textBox5_MC;
            Resize += Form1_Resize;
        }
        private void textBox1_MC(object sender, MouseEventArgs e) // Номерует textBox
        {
            textBox1.Text = "1";
        }
        private void textBox2_MC(object sender, MouseEventArgs e)
        {
            textBox2.Text = "2";
        }
        private void textBox3_MC(object sender, MouseEventArgs e)
        {
            textBox3.Text = "3";
        }
        private void textBox4_MC(object sender, MouseEventArgs e)
        {
            textBox4.Text = "4";
        }
        private void textBox5_MC(object sender, MouseEventArgs e)
        {
            textBox5.Text = "5";
        }
        private void Form1_Resize(object sender, EventArgs e) // Очищает textBox
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
