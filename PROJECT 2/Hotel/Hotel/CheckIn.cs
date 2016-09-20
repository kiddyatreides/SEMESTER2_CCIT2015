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
    public partial class CheckIn : Form
    {
        FileStream F;
        //StreamReader R;
        StreamWriter W;

        public CheckIn()
        {
            InitializeComponent();
        }

        public string newCheckInCode()
        {
            string Str, CheckInCode;
            int CheckInInt;
            string[] strArray = new string[6];
            try
            {
                if (new FileInfo("Transaction.txt").Length == 0)
                {
                    CheckInCode = "I001";
                    return CheckInCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Transaction.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    CheckInCode = strArray[0].Substring(1, 3);
                    CheckInInt = Convert.ToInt32(CheckInCode) + 1;
                    if (CheckInInt <= 9)
                    {
                        CheckInCode = "I00" + CheckInInt.ToString();
                    }
                    else if (CheckInInt <= 99)
                    {
                        CheckInCode = "I0" + CheckInInt.ToString();
                    }
                    else if (CheckInInt <= 999)
                    {
                        CheckInCode = "I" + CheckInInt.ToString();
                    }
                    return CheckInCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                CheckInCode = "I001";
                return CheckInCode;
            }
        }
        private void CheckIn_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code, CustomerCode, RoomCode, CheckInDate, DaysOfStay, CheckOutDate, Status;
            DateTime CID,COD;
            // for update room
            string cari, Str;
            Boolean find = false;
            int Pos;
            string alltext = "";
            string txtsimpan = "";
            //

            if (ValidateData() == 0)
            {
                error_checkin.Clear();
                try
                {
                    F = new FileStream("Transaction.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);
                    FileStream F1 = new FileStream("Room.txt", FileMode.Open, FileAccess.Read);
                    StreamReader R = new StreamReader(F1);

                    CID = DateTime.Parse(dt_checkindate.Text).Date;
                    COD = DateTime.Parse(dt_checkoutdate.Text).Date;
                    TimeSpan t = COD - CID;
                    Double NrOfDays = t.TotalDays;
                    
                    Code = tbox_code.Text;
                    CustomerCode = cmb_customercode.SelectedItem.ToString();
                    RoomCode = cmb_roomcode.SelectedItem.ToString();
                    CheckInDate = dt_checkindate.Value.ToShortDateString();
                    CheckOutDate = dt_checkoutdate.Value.ToShortDateString();
                    Status = "Reserved";
                    string Status2 = "Not Available";


                    while ((Str = R.ReadLine()) != null)
                    {
                        Pos = Str.IndexOf("#");
                        String Chkstr1 = Str.Substring(0, Pos);
                        if ((RoomCode.CompareTo(Chkstr1) == 0))
                        {
                            string[] elemen = Str.Split('#');
                            find = true;
                            elemen[0] = elemen[0];
                            elemen[1] = elemen[1];
                            elemen[2] = elemen[2];
                            elemen[3] = Status2;
                            txtsimpan = elemen[0] + "#" + elemen[1] + "#" + elemen[2] + "#" + elemen[3] + "#" + "\n";
                            alltext += txtsimpan;
                            //MessageBox.Show("Data Has Been Updated");
                        }
                        else
                        {
                            alltext = alltext + Str + "\n";
                        }
                    }
                    if (!find)
                    {
                        MessageBox.Show("Sorry Data Not Found");
                    }
                    F1.Close();
                    R.Close();
                    File.WriteAllText("Room.txt", alltext);
                    //

                    W.WriteLine(Code + "#" + CustomerCode + "#" + RoomCode + "#" + CheckInDate + "#" + NrOfDays + "#" + CheckOutDate + "#" + Status + "#" );
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    isiDataGridView();
                    //refreshDataGrid();
                    //refreshControl();
                    tbox_code.Text = newCheckInCode();
                    clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

            else
            {
                MessageBox.Show("Please Correct The Error Above!");
            }
            this.Close();
        }
         private int ValidateData()
        {
            int flag = 0;
            if (tbox_code.Text == "")
            {
                tbox_code.Focus();
                error_checkin.SetError(tbox_code, "Please Fill in The Code Box Number");
                flag = 1;
            }
            if (cmb_customercode.Text == "")
            {
                cmb_customercode.Focus();
                error_checkin.SetError(cmb_customercode, "Please Fill in The Customer Code");
                flag = 1;
            }
            if (dt_checkindate.Value < DateTime.Today)
            {
                dt_checkindate.Focus();
                error_checkin.SetError(dt_checkindate, "Please Fill in Check in Date");
                flag = 1;
            }
            if (cmb_roomcode.Text == "")
            {
                cmb_roomcode.Focus();
                error_checkin.SetError(cmb_roomcode, "Please Fill in The Room Code");
                flag = 1;
            }
            if (dt_checkoutdate.Value.Day <= DateTime.Now.Day)
            {
                dt_checkoutdate.Focus();
                error_checkin.SetError(dt_checkoutdate, "Checkout must be bigger than checkin");
                flag = 1;
            }
            return flag;
        }

        public void clear()
        {
            cmb_customercode.Text = "";
            cmb_roomcode.Text = "";
            dt_checkindate.Value = DateTime.Today;
            
            dt_checkoutdate.Value = DateTime.Today;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            string line = "";
            int row = 0;

            FileStream fs = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(tbox_code.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');

                    cmb_customercode.Items.Clear();
                    elemen[1] = cmb_customercode.SelectedText;
                    isicombocustomer();
                    cmb_roomcode.Items.Clear();
                    elemen[2] = cmb_roomcode.SelectedText;
                    isicomboroom();
                    elemen[3] = dt_checkindate.Text;
                    elemen[4] = line;
                    elemen[5] = dt_checkoutdate.Text;
                    elemen[6] = "Reserved";
                    
                    for (int i = 0; i < elemen.Length - 1; i++)
                    {
                        dataGridViewCheckIn[i, row].Value = elemen[i];
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
        public void isiDataGridView()
        {
            string line = "";
            int row = 0;

            dataGridViewCheckIn.ColumnCount = 7;
            dataGridViewCheckIn.Columns[0].Name = "Code";
            dataGridViewCheckIn.Columns[1].Name = "Customer Code";
            dataGridViewCheckIn.Columns[2].Name = "Room Code";
            dataGridViewCheckIn.Columns[3].Name = "Check In Date";
            dataGridViewCheckIn.Columns[4].Name = "Days of Stay";
            dataGridViewCheckIn.Columns[5].Name = "Check Out Date";
            dataGridViewCheckIn.Columns[6].Name = "Status";
           


            FileStream F = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dataGridViewCheckIn.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dataGridViewCheckIn[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            F.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
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
                var oldline = System.IO.File.ReadAllLines("Transaction.txt");
                var newline = oldline.Where(line => !line.Contains(tbox_code.Text + "#"));
                System.IO.File.WriteAllLines("Transaction.txt", newline);
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

                cmb_customercode.Text = "";
                cmb_roomcode.Text = "";
                dt_checkindate.Value = DateTime.Today;
                //numericUpDownDaysOfStay.Value = 0;
                dt_checkoutdate.Value = DateTime.Today;


            }
            else
            {


            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void CheckIn_Load_1(object sender, EventArgs e)
        {
            isicombocustomer();
            isicomboroom();
            tbox_code.Text = newCheckInCode();
            isiDataGridView();
        }
        public void isicombocustomer()
        {

            string[] lineOfContents = File.ReadAllLines("Customer.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('#');
                cmb_customercode.Items.Add(tokens[0]);
            }

        }
        public void isicomboroom()
        {

            string[] lineOfContents = File.ReadAllLines("Room.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split('#');
                if (tokens[3] == "Available")
                {

                    cmb_roomcode.Items.Add(tokens[0]);
                }
            }

        }

        private void cmb_roomcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_customercode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            string line = "";
            int row = 0;

            FileStream fs = new FileStream("Transaction.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(tbox_code.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');



                    cmb_customercode.Items.Clear();
                    cmb_customercode.SelectedText=elemen[1];
                    isicombocustomer();
                    cmb_roomcode.Items.Clear();
                    cmb_roomcode.SelectedText=elemen[2];
                    isicomboroom();
                    dt_checkindate.Text=elemen[3];
                    line=elemen[4];
                    dt_checkoutdate.Text=elemen[5];
                    
                    for (int i = 0; i < elemen.Length - 1; i++)
                    {
                        dataGridViewCheckIn[i, row].Value = elemen[i];
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

        private void button4_Click(object sender, EventArgs e)
        {
            TransReport objtr = new TransReport();
            objtr.Show();
        }

        private void dt_checkindate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
 