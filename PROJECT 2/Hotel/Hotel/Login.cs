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


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        FileStream F;
        StreamReader R;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                MessageBox.Show("Username cant null", "NULL Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text.Length == 0)
            {
                MessageBox.Show("Password cant null", "NULL Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 F = new FileStream("Admin.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            Boolean find = false; //valid = false;
            string cari, line;
            cari = username.Text;

            while ((line = R.ReadLine()) != null)
            {
                find = true;
                int stringStartPos = line.IndexOf('#');
                if (cari.Equals(line.Substring(0, stringStartPos)))
                {
                    String[] elemen = line.Split('#');
                    if (password.Text.Equals(elemen[1]))
                    {
                        if (username.Text.Equals(elemen[0]) && elemen[2].Equals("1"))
                        {
                            MessageBox.Show("Welcome to Admin Panel");
                           this.Hide();
                            Form1 objadmin = new Form1();
                            objadmin.Show();
                        }
                        else if (username.Text.Equals(elemen[0]) && elemen[2].Equals("2"))
                        {
                            MessageBox.Show("Welcome to Receptionist Panel");
                            this.Hide();
                            ReceptionistPanel objrecept = new ReceptionistPanel();
                            objrecept.Show();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                    
                }

            }

            //if (!find)
            //{
              //  MessageBox.Show("Incorrect UserName or Password");
            //}
            R.Close();
            F.Close();
        }
            }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
        }
    }

