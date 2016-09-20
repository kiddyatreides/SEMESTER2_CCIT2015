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
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Room : Form
    {
        FileStream F;
        StreamReader R;
        StreamWriter W;
        //string line;
        public Room()
        {
            InitializeComponent();
        }
        public string newRoomCode()
        {
            string Str, RoomCode;
            int RoomInt;
            string[] strArray = new string[6];
            try
            {
                if (new FileInfo("Room.txt").Length == 0)
                {
                    RoomCode = "R001";
                    return RoomCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Room.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    RoomCode = strArray[0].Substring(1, 3);
                    RoomInt = Convert.ToInt32(RoomCode) + 1;
                    if (RoomInt <= 9)
                    {
                        RoomCode = "R00" + RoomInt.ToString();
                    }
                    else if (RoomInt <= 99)
                    {
                        RoomCode = "R0" + RoomInt.ToString();
                    }
                    else if (RoomInt <= 999)
                    {
                        RoomCode = "R" + RoomInt.ToString();
                    }
                    return RoomCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                RoomCode = "R001";
                return RoomCode;
            }
        }
        private void Room_Load(object sender, EventArgs e)
        {
            isicombo();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void isicombo()
        {

            string[] lineOfContents = File.ReadAllLines("Class.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('#');
                cb_classtype.Items.Add(tokens[1]);
            }

        }
        public void isiDataGridView()
        {
            string line = "";
            int row = 0;

            dataGridRoom.ColumnCount = 4;
            dataGridRoom.Columns[0].Name = "Room Code";
            dataGridRoom.Columns[1].Name = "Class Type";
            dataGridRoom.Columns[2].Name = "Price";
            dataGridRoom.Columns[3].Name = "Status";
            



            FileStream F = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dataGridRoom.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dataGridRoom[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            F.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            string line = "";
            int row = 0;

            FileStream fs = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(tbox_roomcode.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');


                    
                    cb_classtype.Items.Clear();
                    cb_classtype.SelectedText = elemen[1];
                    isicombo();

                    tb_price.Text = elemen[2];
                    elemen[3] = "Availables" ;
                    for (int i = 0; i < elemen.Length - 1; i++)
                    {
                        dataGridRoom[i, row].Value = elemen[i];
                    }
                    row++;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                error_room.Clear();
                string RoomCode, ClassType, Price, Status;
                try
                {

                    F = new FileStream("Room.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    RoomCode = tbox_roomcode.Text;
                    ClassType = cb_classtype.SelectedItem.ToString();
                    Price = tb_price.Text;
                    Status = "Available";
                   

                    W.WriteLine(RoomCode + "#" + ClassType + "#" + Price + "#" + Status +  "#");
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    isiDataGridView();
                    //refreshDataGrid();
                    //refreshControl();
                    tbox_roomcode.Text = newRoomCode();
                    clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            } //

            else 
            {
                MessageBox.Show("Please Correct The Error Above!");
            }
        }
        public void clear()
        {
            cb_classtype.Text = "";
            tb_price.Text = "";

        }
        private int ValidateData()
        {
            int flag = 0;
            if (cb_classtype.Text == "")
            {
                cb_classtype.Focus();
                error_room.SetError(cb_classtype, "Please Fill in The Class Name");
                flag = 1;
            }
            return flag;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            string[] strArray = new string[4];
            string Str;
            //Boolean update = false;
            int Pos;
            String alltext = "";
            String txtSimpan = "";
            String Status = "Availables";

            FileStream F = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);
            DialogResult dialogResult = MessageBox.Show("Do you want to update the data?", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                while ((Str = sr.ReadLine()) != null)
                {
                    Pos = Str.IndexOf("#");
                    String Chkstr2 = Str.Substring(0, Pos);
                    if (tbox_roomcode.Text.CompareTo(Chkstr2) == 0)
                    {
                        //string category = Convert.ToString(Jobs_Value.Text).Substring(0, 3);
                        txtSimpan = tbox_roomcode.Text + "#" + cb_classtype.Text + "#" + tb_price.Text + "#" + Status + "#";
                        alltext += txtSimpan + "\n";
                        MessageBox.Show("All data has been update");

                        cb_classtype.Text = "";
                        tb_price.Text = "";
                       

                        isiDataGridView();
                    }
                    else
                    {
                        alltext = alltext + Str + "\n";
                    }
                }

            }
            F.Close();
            sr.Close();
            File.WriteAllText("Room.txt", alltext);
            isiDataGridView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete();
        }
        public void delete()
        {
            //FileStream F = new FileStream("Client.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(F);

            // Str;
            //String newLine = "";
            //int Pos;
            //String alltext = "";
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var oldline = System.IO.File.ReadAllLines("Room.txt");
                var newline = oldline.Where(line => !line.Contains(tbox_roomcode.Text + "#"));
                System.IO.File.WriteAllLines("Room.txt", newline);
                /*while ((Str = sr.ReadLine()) != null)
                {
                    Pos = Str.IndexOf("#");
                    String Chkstr2 = Str.Substring(0, Pos);
                    if ((ID_Client_Value.Text.CompareTo(Chkstr2) == 0))
                    {
                        string[] data = Str.Split('#');
                        if (!Str.Contains(ID_Client_Value.Text))
                        {
                            for (int a = 0; a < data.Length; a++)
                            {
                                newLine = newLine + "#" + data[a];

                            }
                            alltext += newLine + "\n";

                        }
                        Str = sr.ReadLine();*/




                //sr.Close();
                //File.WriteAllText("Client.txt", alltext);
                MessageBox.Show("Data Deleted");
                isiDataGridView();

                
                cb_classtype.Text = "";
                tb_price.Text = "";


            }
            else
            {


            }

        }


        private void Room_Load_1(object sender, EventArgs e)
        {
            isicombo();
            tbox_roomcode.Text = newRoomCode();
            isiDataGridView();
        }

        private void cb_classtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_price.Text = searchPrice();
        }
        public string searchPrice()
        {
            string line, cari, strPrice = "";
            string[] strArray = new string[6];
            F = new FileStream("Class.txt", FileMode.Open, FileAccess.Read);
            R = new StreamReader(F);
            cari = cb_classtype.SelectedItem.ToString();
            while ((line = R.ReadLine()) != null)
            {
                //int stringStartPos = line.IndexOf('#');
                strArray = line.Split(new string[] { "#" }, StringSplitOptions.None);
                if (cari.Equals(strArray[1]))
                {
                    strPrice = strArray[2];
                }
               // strPrice = strArray[1];
            }
            R.Close();
            F.Close();
            return strPrice;
            
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           RoomReport objrr = new RoomReport();
           objrr.Show();
        }
    }
}
