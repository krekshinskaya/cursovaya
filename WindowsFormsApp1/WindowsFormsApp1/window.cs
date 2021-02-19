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
    public partial class window : Form
    {
        
        public window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu newForm = new menu();
            newForm.Show();
            this.Hide();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            advice frm = new advice();
            this.Hide();
            frm.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            water Form3 = new water();
            Form3.Show();
            this.Hide();
            Form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
