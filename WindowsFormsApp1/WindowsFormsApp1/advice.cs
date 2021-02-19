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
namespace WindowsFormsApp1
{
    public partial class advice : Form
    {
        public advice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             window newForm = new window();
             newForm.Show();
            
            this.Hide();
            newForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*создать файл txt и из него рандомно вытягивать строку*/
           
            
                Random rand = new Random();
                string[] strs = File.ReadAllLines("advice.txt");
                string s = strs[rand.Next(strs.Length)];
                textBox1.Text = Convert.ToString(s);
            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }
  
