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
    public partial class MainMenuX : Form
    {
        public MainMenuX()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn objci = new CheckIn();
            objci.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOut objco = new CheckOut();
            objco.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer objcust = new Customer();
            objcust.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room objroom = new Room();
            objroom.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class objclass = new Class();
            objclass.Show();
        }

        private void MainMenuX_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
