using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class CheckOut : Form
    {
        FileStream F;
        //StreamReader R;
        StreamWriter W;
        string idroom;
        
        int price, day, total;
        public CheckOut()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            isicombocode();
            isiDataGridView();
        }

        public void isicombocode()
        {

            string[] lineOfContents = File.ReadAllLines("Transaction.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('#');
                if (tokens[6] == "Reserved")
                {
                    cbox_code.Items.Add(tokens[0]);
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
                
            Boolean find = false;
            string  line = "", line2 = "";
            int row = 0;

            FileStream fs = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(cbox_code.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');

                    idroom = elemen[2];
                   // textBox1.Text = elemen[2];
                    tbox_days.Text = elemen[4];
                    day = Convert.ToInt32(elemen[4]);
                    
                    //check price room//
                    FileStream fs1 = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr1 = new StreamReader(fs1);
                    while ((line2 = sr1.ReadLine()) != null)
                    {

                        if (line2.Contains(idroom))
                        {
                            find = true;
                            // MessageBox.Show("Data Found");
                            string[] elemen2 = line2.Split('#');

                            tbox_price.Text = elemen2[2];
                            //tbox_price.Text = elemen2[2];
                            price = Convert.ToInt32(elemen2[2]);

                        }
                        else
                        {
                            //MessageBox.Show("No Room");
                        }
                        total = (day * price);
                        tbox_total.Text = Convert.ToString(total);
                        if (!find)
                        {
                            MessageBox.Show("Data not Found");
                            isiDataGridView();
                        }
                        
                    }
                    //
                    sr1.Close();
                    fs1.Close();


                }
            }
            
            if (!find)
            {
                MessageBox.Show("Data not Found");
                isiDataGridView();
            }
            sr.Close();
            fs.Close();
        }
        public void isiDataGridView()
        {
            string line = "";
            int row = 0;

            dataGridTrans.ColumnCount = 7;
            dataGridTrans.Columns[0].Name = "Code";
            dataGridTrans.Columns[1].Name = "Customer Code";
            dataGridTrans.Columns[2].Name = "Room Code";
            dataGridTrans.Columns[3].Name = "Check In Date";
            dataGridTrans.Columns[4].Name = "Days of Stay";
            dataGridTrans.Columns[5].Name = "Check Out Date";
            dataGridTrans.Columns[6].Name = "Status";



            FileStream F = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dataGridTrans.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    if (elemen[6] == "Reserved")
                    {
                        dataGridTrans[i, row].Value = elemen[i];
                    }
                }
                row++;
            }
            sr.Close();
            F.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string Code, RoomPrice, TotalDays, TotalPrice, status, checkout;
                Boolean find = false;
                string line = "";
                int row = 0;
                StreamWriter w;
                // for update room
                string cari, Str, Str2;
                string[] strArray = new string[7];
                int Pos;
                string alltext = "", alltext2 = "" ;
                string txtsimpan = "", txtsimpan2 = "" ;
                //


                FileStream fs = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                //transaction
                
                RoomPrice = tbox_price.Text;
                TotalDays = tbox_days.Text;
                TotalPrice = tbox_total.Text;
               // checkout = "Checkout";
                //

                //room
                status = "Available";
                //

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(cbox_code.Text))
                    {
                        find = true;
                        string[] elemen = line.Split('#');

                        idroom = elemen[2];
                        status = "Available";
                        checkout = "Checkout";

                        //Code = cbox_code.Text;
                        
                        //    Pos = line.IndexOf("#");
                        //    String Chkstr1 = line.Substring(0, Pos);
                        //    //checkout = "Checkout";
                        //    if ((Code.CompareTo(Chkstr1) == 0))
                        //    {
                                find = true;
                                string[] elemen3 = line.Split('#');
                                elemen3[0] = elemen3[0];
                                elemen3[1] = elemen3[1];
                                elemen3[2] = elemen3[2];
                                elemen3[3] = elemen3[3];
                                elemen3[4] = elemen3[4];
                                elemen3[5] = elemen3[5];
                                elemen3[6] = checkout;
                                txtsimpan2 = elemen3[0] + "#" + elemen3[1] + "#" + elemen3[2] + "#" + elemen3[3] + "#" + elemen3[4] + "#" + elemen3[5] + "#" + elemen3[6] + "#";
                                alltext2 += txtsimpan2 + "\n";
                            //}
                            
                        //

                    }
                    else
                    {
                        alltext2 = alltext2 + line + "\n";
                    }
                }
                if (!find)
                {
                    MessageBox.Show("Data not Found");
                    isiDataGridView();
                }
                
                sr.Close();
                fs.Close();
                File.WriteAllText("Transaction.txt", alltext2);

                //update room
                FileStream fs1 = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fs1);

                while ((Str2 = sr1.ReadLine()) != null)
                {
                    Pos = Str2.IndexOf("#");
                    String Chkstr2 = Str2.Substring(0, Pos);

                    if ((idroom.CompareTo(Chkstr2) == 0))
                    {
                        string[] elemen2 = Str2.Split('#');
                        find = true;
                        elemen2[0] = elemen2[0];
                        elemen2[1] = elemen2[1];
                        elemen2[2] = elemen2[2];
                        elemen2[3] = status;
                        txtsimpan = elemen2[0] + "#" + elemen2[1] + "#" + elemen2[2] + "#" + elemen2[3] + "#";
                        alltext += txtsimpan + "\n";
                        //MessageBox.Show("Data Has Been Updated");

                    }
                    else
                    {
                        alltext = alltext + Str2 + "\n";
                    }
                }
                sr1.Close();
                fs1.Close();
                File.WriteAllText("Room.txt", alltext);

                if (!find)
                {
                    MessageBox.Show("Sorry Data Not Found");
                }
                //finish update room
                MessageBox.Show("Check Out Success");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransReport objtr = new TransReport();
            objtr.Show();

        }

        private void cbox_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
