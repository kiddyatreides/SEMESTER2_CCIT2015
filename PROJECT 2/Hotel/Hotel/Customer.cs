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
    public partial class Customer : Form
    {
        FileStream F;
        //StreamReader R;
        StreamWriter W;
        public Customer()
        {
            InitializeComponent();
        }
        public string newCustomerCode()
        {
            string Str, CustomerCode;
            int CustomerInt;
            string[] strArray = new string[6];
            try
            {
                if (new FileInfo("Customer.txt").Length == 0)
                {
                    CustomerCode = "C001";
                    return CustomerCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Customer.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    CustomerCode = strArray[0].Substring(1, 3);
                    CustomerInt = Convert.ToInt32(CustomerCode) + 1;
                    if (CustomerInt <= 9)
                    {
                        CustomerCode = "C00" + CustomerInt.ToString();
                    }
                    else if (CustomerInt <= 99)
                    {
                        CustomerCode = "C0" + CustomerInt.ToString();
                    }
                    else if (CustomerInt <= 999)
                    {
                        CustomerCode = "C" + CustomerInt.ToString();
                    }
                    return CustomerCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                CustomerCode = "C001";
                return CustomerCode;
            }
        }
       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            string[] strArray = new string[7];
            string Str;
            //Boolean update = false;
            int Pos;
            String alltext = "";
            String txtSimpan = "";

            FileStream F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);
            DialogResult dialogResult = MessageBox.Show("Do you want to update the data?", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                while ((Str = sr.ReadLine()) != null)
                {
                    Pos = Str.IndexOf("#");
                    String Chkstr2 = Str.Substring(0, Pos);
                    if (tbox_custcode.Text.CompareTo(Chkstr2) == 0)
                    {
                        //string category = Convert.ToString(Jobs_Value.Text).Substring(0, 3);
                        txtSimpan = tbox_custcode.Text + "#" + tbox_idnum.Text + "#" + tbox_name.Text + "#" + dt_birthdate.Text + "#" +
                             tbox_phone.Text + "#" + tbox_address.Text + "#";
                        alltext += txtSimpan + "\n";
                        MessageBox.Show("All data has been update");

                        tbox_idnum.Text = "";
                        tbox_name.Text = "";
                        tbox_phone.Text = "";
                        tbox_address.Text = "";



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
            File.WriteAllText("Customer.txt", alltext);
            isiDataGridView();

        }
        private void Customer_Load(object sender, EventArgs e)
        {
            tbox_custcode.Text = newCustomerCode();
            isiDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                error_customer.Clear();
                string CustomerCode, IDNum, CustomerName, Birthdate, Phone, Address;
                try
                {

                    F = new FileStream("Customer.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    CustomerCode = tbox_custcode.Text;
                    IDNum = tbox_idnum.Text;
                    CustomerName = tbox_name.Text;
                    Birthdate = dt_birthdate.Text;
                    Phone = tbox_phone.Text;
                    Address = tbox_address.Text;

                    W.WriteLine(CustomerCode + "#" + IDNum + "#" + CustomerName + "#" + Birthdate + "#" + Phone + "#" + Address + "#");
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    isiDataGridView();
                    //refreshDataGrid();
                    //refreshControl();
                    tbox_custcode.Text = newCustomerCode();
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
        private int ValidateData()
        {
            int flag = 0;
            if (tbox_idnum.Text == "")
            {
                tbox_idnum.Focus();
                error_customer.SetError(tbox_idnum, "Please Fill in The Class Name");
                flag = 1;
            }
            if (tbox_name.Text == "")
            {
                tbox_name.Focus();
                error_customer.SetError(tbox_name, "Please Fill in The Type");
                flag = 1;
            }
            if (tbox_phone.Text == "")
            {
                tbox_phone.Focus();
                error_customer.SetError(tbox_phone, "Please Fill in The Type");
                flag = 1;
            }
            if (tbox_address.Text == "")
            {
                tbox_address.Focus();
                error_customer.SetError(tbox_address, "Please Fill in The Type");
                flag = 1;
            }
            if (dt_birthdate.Value.Year > 1999)
            {
                dt_birthdate.Focus();
                error_customer.SetError(dt_birthdate, "Customer Must Above 17 Years Old");
                flag = 1;
            }
            return flag;
        }
        public void clear()
        {
            tbox_idnum.Text = "";
            tbox_name.Text = "";
            tbox_phone.Text = "";
            tbox_address.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
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
                var oldline = System.IO.File.ReadAllLines("Customer.txt");
                var newline = oldline.Where(line => !line.Contains(tbox_custcode.Text + "#"));
                System.IO.File.WriteAllLines("Customer.txt", newline);
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

                tbox_idnum.Text = "";
                tbox_name.Text = "";
                tbox_phone.Text = "";
                tbox_address.Text = "";


            }
            else
            {


            }

        }
        public void isiDataGridView()
        {
            string line = "";
            int row = 0;

            dataGridCustomer.ColumnCount = 6;
            dataGridCustomer.Columns[0].Name = "Customer Code";
            dataGridCustomer.Columns[1].Name = "ID Number";
            dataGridCustomer.Columns[2].Name = "Customer Name";
            dataGridCustomer.Columns[3].Name = "Birthdate";
            dataGridCustomer.Columns[4].Name = "Phone";
            dataGridCustomer.Columns[5].Name = "Address";
           



            FileStream F = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dataGridCustomer.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dataGridCustomer[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            F.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            string line = "";
            int row = 0;

            FileStream fs = new FileStream("Customer.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(tbox_custcode.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');


                    tbox_idnum.Text = elemen[1];
                    tbox_name.Text = elemen[2];
                    dt_birthdate.Text = elemen[3];
                    tbox_phone.Text = elemen[4];
                    tbox_address.Text = elemen[5];
                    
                    for (int i = 0; i < elemen.Length - 1; i++)
                    {
                        dataGridCustomer[i, row].Value = elemen[i];
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

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerReport objcsr = new CustomerReport();
            objcsr.Show();
        }

        private void dt_birthdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
