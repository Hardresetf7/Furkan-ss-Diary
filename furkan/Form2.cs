using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace furkan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text;
            
            
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string note = richTextBox2.Text;

            string appFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Günlük Notları");
            Directory.CreateDirectory(appFolderPath);

            int fileCounter = 1;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = $"not_{currentDate}_{fileCounter}.txt";
            string filePath = Path.Combine(appFolderPath, fileName);

            while (File.Exists(filePath)) 
            {
                fileCounter++;
                fileName = $"not_{currentDate}_{fileCounter}.txt";
                filePath = Path.Combine(appFolderPath, fileName);
            }

            try
            {
                File.WriteAllText(filePath, note);
                MessageBox.Show("Not başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
    }
   
