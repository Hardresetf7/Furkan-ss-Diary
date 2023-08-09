using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Furkan" && textBox2.Text == "Hardresetf7")
            {
                Form2 mainDairy = new Form2();
                mainDairy.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Geçersiz Giriş Bilgileri.");
                textBox1.Clear();
                textBox2.Clear();
            }

        }
    }
}
