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
    public partial class updateProduct : Form
    {
        OleDbConnection con = Settings.con;
        public updateProduct()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("נדלן"))
            {
                groupBox2.Location = groupBox4.Location;
                groupBox1.Hide();
                groupBox2.Show();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();

                comboBox2.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                  //  type = "RealEstate";

                }
                con.Close();


            }
            else if (comboBox1.SelectedItem.Equals("רכב"))
            {
                groupBox1.Location = groupBox4.Location;
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Hide();

                comboBox2.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                   // type = "Vehicle";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
            {
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Show();
                groupBox5.Hide();

                comboBox2.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Pets WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM Pets WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                   // type = "Pets";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
            {
                groupBox3.Location = groupBox4.Location;
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Show();
                groupBox4.Hide();
                groupBox5.Hide();

                comboBox2.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    //type = "SecondHandProduct";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("חבילה"))
            {
                groupBox5.Location = groupBox4.Location;
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Show();


                //////////////////////
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Package WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                OleDbCommand cmdF = new OleDbCommand("SELECT COUNT(*) FROM Package WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmdF.ExecuteNonQuery();
                int total = (Int32)cmdF.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                comboBox2.Items.Clear();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));

                }
                con.Close();
                ////////////////


                checkedListBox1.Items.Clear();
                OleDbCommand cmdP = new OleDbCommand();
                con.Open();
                //vehilce
                cmdP.CommandText = "SELECT productID FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'";
                cmdP.Connection = con;
                cmdP.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = "SELECT COUNT(*) FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'";
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                 total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader readerP = cmdP.ExecuteReader();
                while (readerP.HasRows && total > 0)
                {
                    total--;
                    readerP.Read();
                    checkedListBox1.Items.Add(readerP.GetValue(0).ToString());
                }

                ////realestate
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandText = "SELECT productID FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'";
                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.CommandText = "SELECT COUNT(*) FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'";
                cmd3.Connection = con;
                cmd3.ExecuteNonQuery();
                total = (Int32)cmd3.ExecuteScalar();
                OleDbDataReader reader1 = cmd2.ExecuteReader();
                while (reader1.HasRows && total > 0)
                {
                    total--;
                    reader1.Read();
                    checkedListBox1.Items.Add(reader1.GetValue(0).ToString());
                }

                ////pets
                OleDbCommand cmd4 = new OleDbCommand();
                cmd4.CommandText = "SELECT productID FROM Pets WHERE lessorID='" + Settings.user.getID() + "'";
                cmd4.Connection = con;
                cmd4.ExecuteNonQuery();
                OleDbCommand cmd5 = new OleDbCommand();
                cmd5.CommandText = "SELECT COUNT(*) FROM Pets WHERE lessorID='" + Settings.user.getID() + "'";
                cmd5.Connection = con;
                cmd5.ExecuteNonQuery();
                total = (Int32)cmd5.ExecuteScalar();
                OleDbDataReader reader2 = cmd4.ExecuteReader();
                while (reader2.HasRows && total > 0)
                {
                    total--;
                    reader2.Read();
                    checkedListBox1.Items.Add(reader2.GetValue(0).ToString());
                }

                ////SecondHandProduct
                OleDbCommand cmd6 = new OleDbCommand();
                cmd6.CommandText = "SELECT productID FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'";
                cmd6.Connection = con;
                cmd6.ExecuteNonQuery();
                OleDbCommand cmd7 = new OleDbCommand();
                cmd7.CommandText = "SELECT COUNT(*) FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'";
                cmd7.Connection = con;
                cmd7.ExecuteNonQuery();
                total = (Int32)cmd7.ExecuteScalar();
                OleDbDataReader reader3 = cmd6.ExecuteReader();
                while (reader3.HasRows && total > 0)
                {
                    total--;
                    reader3.Read();
                    checkedListBox1.Items.Add(reader3.GetValue(0).ToString());
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type = null;
            if (double.Parse(cost.Text) > 0 && double.Parse(deposit.Text) > 0)
            {
                MessageBox.Show("לא ניתן להזין פיקדון עבור עלות מוצר שגדולה מ0");
            }
            else
            {
                if (comboBox1.SelectedItem.Equals("רכב"))
                {
                    type = "Vehicle";
                    if (carType.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [type] = '" + carType.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (carModel.Text != "")
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [model] = '" + carModel.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (carYear.Text != "")
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [yearOfManufacture] = '" + carYear.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (carManu.Text != "")
                    {

                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [manufacture] = '" + carManu.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedItem.Equals("נדלן"))
                {
                    type = "RealEstate";
                    if (realestateType.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [type] = '" + realestateType.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textBox11.Text != "")
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [capacity] = '" + textBox11.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
                {
                    type = "SecondHandProduct";
                    if (secondHandType.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [subCategory] = '" + secondHandType.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (condition.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [condition] = '" + condition.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
                {
                    type = "Pets";
                    if (animalType.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [animalType] = '" + animalType.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gender.SelectedIndex != -1)
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [gender] = '" + gender.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textBox15.Text != "")
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [age] = '" + int.Parse(textBox15.Text) + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                    if (textBox16.Text != "")
                    {
                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE " + type + " SET [breed] = '" + textBox16.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedItem.Equals("חבילה"))
                {
                    type = "Package";

                    /////DELETE EXISTING PRODUCTS AND ADD THE NEW PRODUCTS
                    OleDbCommand deleteProducts = new OleDbCommand("DELETE * FROM ProductsInPackage WHERE LessorID='" + Settings.user.getID() + "' AND PackageID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'", con);
                    con.Open();
                    deleteProducts.ExecuteNonQuery();
                    con.Close();

                    foreach (object s in checkedListBox1.CheckedItems)
                    {
                        int productid = int.Parse(s.ToString());
                        OleDbCommand insertPackage = new OleDbCommand();
                        insertPackage.CommandText = "INSERT INTO ProductsInPackage ([lessorID],[PackageID],[ProductID])VALUES('" + Settings.user.getID() + "','" + int.Parse(comboBox2.SelectedItem.ToString()) + "','" + productid + "')";
                        con.Open();
                        insertPackage.Connection = con;
                        insertPackage.ExecuteNonQuery();
                        con.Close();
                    }
                }
                if (comboBox4.SelectedIndex != -1)
                {
                    string temp = null;
                    if (comboBox4.SelectedItem.ToString().Equals("כן"))
                        temp = "true";
                    else temp = "false";

                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET isOnlyPartOfPackage = '" + temp + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (comboBox3.SelectedIndex != -1)
                {
                    string temp = null;
                    if (comboBox3.SelectedItem.ToString().Equals("כן"))
                        temp = "true";
                    else temp = "false";

                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET canBeTraded = '" + temp + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (nimTime.Text != "" && nimTimeCheck.SelectedIndex != -1)
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET minimalRentTime = '" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (aproval.SelectedIndex != -1)
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET approvalApproach = '" + aproval.SelectedItem.ToString() + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (cancel.Text != "")
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET cancelPolicy = '" + cancel.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (cost.Text != "")
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET rentalCost = '" + cost.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (deposit.Text != "")
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET deposit = '" + deposit.Text + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (pictureBox1.ImageLocation != null)
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET image = '" + pictureBox1.ImageLocation + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                if (pictureBox1.ImageLocation != null)
                {
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.CommandText = "UPDATE " + type + " SET image = '" + pictureBox1.ImageLocation + "' WHERE lessorID = '" + Settings.user.getID() + "' AND productID='" + int.Parse(comboBox2.SelectedItem.ToString()) + "'";
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                ///////////////////////is part of package//////is 

                MessageBox.Show("Success");
                this.Close();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
