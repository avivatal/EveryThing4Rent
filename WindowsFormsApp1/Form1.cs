using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        OleDbConnection con = Settings.con;
        User correntUser;
        string type="";
        public Form1()
        {
        
            InitializeComponent();
            correntUser = new User();

            secondhand.Hide();
            car.Hide();
            pets.Hide();
            RealEstate.Hide();
            checkedListBox1.Hide();


            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "SELECT * FROM RegisteredUser WHERE ID=@ID AND password=@password";
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            OleDbDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Error");
            }
            else
            {
                linkLabel6.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;

                linkLabel4.Visible = true;
                linkLabel5.Visible = true;

                groupBox2.Visible = false;
                reader.Read();
                label5.Visible = true;
                label5.Text = ":ברוך הבא";
                label6.Visible = true;
                label6.Text = reader.GetValue(1) + "";
                Settings.user = new RegisteredUser(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(6).ToString(), reader.GetValue(8).ToString(), reader.GetValue(12).ToString());//,reader.GetDateTime(7));
                Settings.user.myProducts = new List<Product>();
                reader.Close();

            }
            con.Close();


            //show Requests
            con.Open();
            OleDbCommand request = new OleDbCommand("SELECT * FROM tradeRequest WHERE lessorID='" + Settings.user.getID() + "'", con);
            request.ExecuteNonQuery();

            ///checkedListBox1.Items.Add(read.GetValue(1));
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.CommandText = "SELECT COUNT(*) FROM tradeRequest WHERE lessorID='" + Settings.user.getID() + "'";
            cmd1.Connection = con;
            cmd1.ExecuteNonQuery();
            int total = (Int32)cmd1.ExecuteScalar();
            OleDbDataReader reader1 = request.ExecuteReader();
            while (reader1.HasRows && total > 0)
            {
                checkedListBox1.Visible = true;
                total--;
                reader1.Read();
                checkedListBox1.Items.Add(reader1.GetValue(1));
            }


            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createProduct product = new createProduct();
            product.ShowDialog();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deleteProduct register = new deleteProduct();
            register.ShowDialog();


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updateProduct register = new updateProduct();
            register.ShowDialog();


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showProduct register = new showProduct();
            register.ShowDialog();


        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;

            linkLabel4.Visible = false;
            linkLabel5.Visible = false;

            groupBox2.Visible = true;
            label5.Visible = false;
            label6.Visible = false;

            Settings.user = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("נדלן"))
            {
                type = "RealEstate";
                RealEstate.Show();
                car.Hide();
                pets.Hide();
                secondhand.Hide();
            }
            else if (comboBox1.SelectedItem.Equals("רכב"))
            {
                type = "Vehicle";
                car.Location = RealEstate.Location;
                RealEstate.Hide();
                car.Show();
                pets.Hide();
                secondhand.Hide();
            } else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
            {
                type = "Pets";
                pets.Location = RealEstate.Location;
                RealEstate.Hide();
                car.Hide();
                pets.Show();
                secondhand.Hide();
            }
            else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
            {
                type = "SecondHandProduct";
                secondhand.Location = RealEstate.Location;
                RealEstate.Hide();
                car.Hide();
                pets.Hide();
                secondhand.Show();
            }
            else if (comboBox1.SelectedItem.Equals("חבילה"))
            {
                type = "Package";            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime check1,check2;
            bool valid1 = DateTime.TryParse(dateTimePicker1.Text, out check1);
            bool valid2 = DateTime.TryParse(dateTimePicker2.Text, out check2);


            string myQuery = "select * from " + type + " where ";
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                myQuery += "rentalCost between " + double.Parse(textBox3.Text) + " and " + double.Parse(textBox4.Text) + "";
            }
            if (nimTime.Text != "" && nimTimeCheck.SelectedIndex != -1)
            {
                ///FUNCTION THAT CHECK TIMES
            }
            /*if(!((valid1&&(check1>=DateTime.Now))&& (valid2 && (check2 >= DateTime.Now))&&(check1<check2)))
            {
                ///check today... cant change query beacuse times in calender
                MessageBox.Show("error in the dates");
            }*/
            else
            {
                if (type.Equals("Pets"))
                {
                    if (animalType.SelectedIndex != -1)
                        myQuery += "and animalType='" + animalType.SelectedItem.ToString() + "'";
                    if(gender.SelectedIndex!=-1)
                        myQuery+= "and gender='" + gender.SelectedItem.ToString() + "'";
                    if (textBox15.Text != "")
                        myQuery += "and age=" + double.Parse(textBox15.ToString()) + "";
                    if (textBox16.Text != "")
                        myQuery += "and breed='" + textBox16.ToString() + "'";
                }
                else if (type.Equals("SecondHandProduct"))
                {
                    if (secondHandType.SelectedIndex != -1)
                        myQuery += "and subCategory='" + secondHandType.SelectedItem.ToString() + "'";
                    if(condition.SelectedIndex!=-1)
                        myQuery += "and condition='" + condition.SelectedItem.ToString() + "'";
                }
                else if (type.Equals("Vehicle"))
                {
                    if (carType.SelectedIndex != -1)
                        myQuery += "and type='" + carType.SelectedItem.ToString() + "'";
                    if (carModel.Text!="")
                        myQuery += "and model='" + carModel.Text + "'";
                    if (carManu.Text != "")
                        myQuery += "and manufacture=" + carManu.Text + "";
                    if (carYear.Text != "")
                        myQuery += "and yearOfManufacture='" + carYear.Text + "'";
               /*     if(isAutomatic.Checked)
                        myQuery += "and isAutomatic='true'";
                    else myQuery += "and isAutomatic='false'";*/

                }
                else if (type.Equals("RealEstate"))
                {
                    if (realestateType.SelectedIndex != -1)
                        myQuery += "and type='" + realestateType.SelectedItem.ToString() + "'";
                    if (textBox11.Text != "")
                        myQuery += "and capacity=" + double.Parse(textBox11.Text) + "";
                }
                if (myQuery.EndsWith("where "))
                    MessageBox.Show("Must enter one filter");
                else
                {
                    SearchResults r = new SearchResults();
                    r.setQuery(myQuery);
                    r.ShowDialog();
                }
            }
        }
    }
}
