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
    public partial class ReceptionistPanel : Form
    {
        public ReceptionistPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn objci = new CheckIn();
            objci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOut objco = new CheckOut();
            objco.Show();
        }

        private void ReceptionistPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login objlgn = new Login();
            this.Hide();
            objlgn.Show();
        }
    }
}
