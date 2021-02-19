using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class water : Form
    {
       
        

        public water()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string a1 = "0";
            textBox1.Text = a1;
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);


            int sum = 0;
            for (int i = 0; i <= 5; i++)
            { 
                sum = a + b;
                textBox1.Text = Convert.ToString(sum);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            window frm = new window();
            this.Hide();
            frm.Show();
        }

        private void water_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
          //   string text = textBox2.Text;
            //int numb = Convert.ToInt32(text);
            //int.Parse(text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            //char ch = e.KeyChar;
            //if (!Char.IsDigit(ch) && ch != 8)
            //{
              //  e.Handled = true;
            //}
        }
    }
}
