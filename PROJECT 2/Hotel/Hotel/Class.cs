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
    public partial class Class : Form
    {
        FileStream F;
        //StreamReader R;
        StreamWriter W;

        public Class()
        {
            InitializeComponent();
        }
        public string newClassCode()
        {
            string Str, ClassCode;
            int ClassInt;
            string[] strArray = new string[7];
            try
            {
                if (new FileInfo("Class.txt").Length == 0)
                {
                    ClassCode = "L001";
                    return ClassCode;
                }
                else
                {
                    Str = System.IO.File.ReadLines("Class.txt").Last();
                    strArray = Str.Split(new string[] { "#" }, StringSplitOptions.None);
                    ClassCode = strArray[0].Substring(1, 3);
                    ClassInt = Convert.ToInt32(ClassCode) + 1;
                    if (ClassInt <= 9)
                    {
                        ClassCode = "L00" + ClassInt.ToString();
                    }
                    else if (ClassInt <= 99)
                    {
                        ClassCode = "L0" + ClassInt.ToString();
                    }
                    else if (ClassInt <= 999)
                    {
                        ClassCode = "L" + ClassInt.ToString();
                    }
                    return ClassCode;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Data, Creating File.....");
                ClassCode = "L001";
                return ClassCode;
            }
        }
        private void Class_Load(object sender, EventArgs e)
        {
            tbox_classcode.Text = newClassCode();
            isiDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateData() == 0)
            {
                error_class.Clear();
                string ClassCode, ClassName, Price, BedType, RoomSize, Bathroom, Facility;
                try
                {

                    F = new FileStream("Class.txt", FileMode.Append, FileAccess.Write);
                    W = new StreamWriter(F);

                    ClassCode = tbox_classcode.Text;
                    ClassName = tbox_classname.Text;
                    Price = tbox_price.Text;
                    BedType = cbox_bed.SelectedItem.ToString();
                    RoomSize = cbox_roomsize.SelectedItem.ToString();
                    Bathroom = cbox_bathroom.SelectedItem.ToString();
                    Facility = cbox_facility.SelectedItem.ToString();
                    
                    W.WriteLine(ClassCode + "#" + ClassName + "#" + Price + "#" + BedType + "#" + RoomSize + "#" + Bathroom + "#" + Facility + "#");
                    W.Flush();
                    W.Close();
                    F.Close();
                    MessageBox.Show("Data Has Been Succesfully Saved");
                    isiDataGridView();
                    //refreshDataGrid();
                    //refreshControl();
                    tbox_classcode.Text = newClassCode();
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
            if (tbox_classname.Text == "")
            {
                tbox_classname.Focus();
                error_class.SetError(tbox_classname, "Please Fill in The Class Name");
                flag = 1;
            }
            if (tbox_price.Text == "")
            {
                tbox_price.Focus();
                error_class.SetError(tbox_price, "Please Fill in The Type");
                flag = 1;
            }
            return flag;
        }
        public void clear()
        {
            tbox_classname.Text = "";
            tbox_price.Text = "";
            cbox_bathroom.Text = "";
            cbox_bed.Text = "";
            cbox_facility.Text = "";
            cbox_roomsize.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean find = false;
            string line = "";
            int row = 0;

            FileStream fs = new FileStream("Class.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(tbox_classcode.Text))
                {
                    find = true;
                    MessageBox.Show("Data Found");
                    string[] elemen = line.Split('#');

                    
                    tbox_classname.Text = elemen[1];
                    tbox_price.Text = elemen[2];
                    cbox_bed.SelectedItem = elemen[3]; 
                    cbox_roomsize.SelectedItem = elemen[4];
                    cbox_bathroom.SelectedItem = elemen[5];
                    cbox_facility.SelectedItem = elemen[6];
                    
                    for (int i = 0; i < elemen.Length - 1; i++)
                    {
                        dataGridViewClass[i, row].Value = elemen[i];
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

            dataGridViewClass.ColumnCount = 7;
            dataGridViewClass.Columns[0].Name = "Class Code";
            dataGridViewClass.Columns[1].Name = "Class Name";
            dataGridViewClass.Columns[2].Name = "Price";
            dataGridViewClass.Columns[3].Name = "Bed Type";
            dataGridViewClass.Columns[4].Name = "Room Size";
            dataGridViewClass.Columns[5].Name = "Bathroom";
            dataGridViewClass.Columns[6].Name = "Facility";
           


            FileStream F = new FileStream("Class.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);

            while ((line = sr.ReadLine()) != null)
            {
                string[] elemen = line.Split('#');
                dataGridViewClass.Rows.Add();
                for (int i = 0; i < elemen.Length - 1; i++)
                {
                    dataGridViewClass[i, row].Value = elemen[i];
                }
                row++;
            }
            sr.Close();
            F.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
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

            FileStream F = new FileStream("Class.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(F);
            DialogResult dialogResult = MessageBox.Show("Do you want to update the data?", "Update", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                while ((Str = sr.ReadLine()) != null)
                {
                    Pos = Str.IndexOf("#");
                    String Chkstr2 = Str.Substring(0, Pos);
                    if (tbox_classcode.Text.CompareTo(Chkstr2) == 0)
                    {
                        //string category = Convert.ToString(Jobs_Value.Text).Substring(0, 3);
                        txtSimpan = tbox_classcode.Text + "#" + tbox_classname.Text + "#" + tbox_price.Text + "#" + cbox_bed.Text + "#" +
                             cbox_roomsize.Text + "#" + cbox_bathroom.Text + "#" + cbox_facility.Text +"#";
                        alltext += txtSimpan + "\n";
                        MessageBox.Show("All data has been update");

                        tbox_classcode.Text = "";
                        tbox_classname.Text = "";
                        tbox_price.Text = "";
                        cbox_bed.Text = "";
                        cbox_roomsize.Text = "";
                        cbox_bathroom.Text = "";
                        cbox_facility.Text = "";
                      


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
            File.WriteAllText("Class.txt", alltext);
            isiDataGridView();

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
                var oldline = System.IO.File.ReadAllLines("Class.txt");
                var newline = oldline.Where(line => !line.Contains(tbox_classcode.Text + "#"));
                System.IO.File.WriteAllLines("Class.txt", newline);
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

                tbox_classname.Text = "";
                tbox_price.Text = "";
                cbox_bed.Text = "";
                cbox_roomsize.Text = "";
                cbox_bathroom.Text = "";
                cbox_facility.Text = "";


            }
            else
            {


            }

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
         ClassReport objclsr = new ClassReport();
         objclsr.Show();
        }
    }
}
