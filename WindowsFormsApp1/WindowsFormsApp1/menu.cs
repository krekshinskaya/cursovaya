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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            window frm = new window();
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("menu.txt");
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
