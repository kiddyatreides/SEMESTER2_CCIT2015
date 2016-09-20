using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer objcust = new Customer();
            objcust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room objroom = new Room();
            objroom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class objclass = new Class();
            objclass.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login objlgn = new Login();
            this.Hide();
            objlgn.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
    }
}
