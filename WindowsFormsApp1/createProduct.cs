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
using Microsoft.VisualBasic;


namespace WindowsFormsApp1
{

    public partial class createProduct : Form
    {
        OleDbConnection con = Settings.con;
        public createProduct()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox6.Hide();
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox4.Hide();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.Equals("רכב"))
            {
                groupBox1.Location = groupBox4.Location;
                groupBox5.Hide();
                groupBox4.Hide();
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
            }
            else if (comboBox1.SelectedItem.Equals("נדלן"))
            {
                groupBox2.Location = groupBox4.Location;
                groupBox5.Hide();
                groupBox4.Hide();
                groupBox2.Show();
                groupBox1.Hide();
                groupBox3.Hide();
            }
            else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
            {
                groupBox3.Location = groupBox4.Location;
                groupBox3.Focus();
                groupBox5.Hide();
                groupBox4.Hide();
                groupBox3.Show();
                groupBox1.Hide();
                groupBox2.Hide();
            }
            else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
            {
                groupBox4.Focus();
                groupBox5.Hide();
                groupBox4.Show();
                groupBox3.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
            } else if (comboBox1.SelectedItem.Equals("חבילה"))
            {
                groupBox5.Focus();
                OleDbCommand cmd = new OleDbCommand();
                con.Open();

                //vehilce
                cmd.CommandText = "SELECT productID FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = "SELECT COUNT(*) FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'";
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows&& total > 0)
                {
                    total--;
                    reader.Read();
                    checkedListBox1.Items.Add(reader.GetValue(0));
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
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader1.Read();
                    checkedListBox1.Items.Add(reader1.GetValue(0));
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
                    checkedListBox1.Items.Add(reader2.GetValue(0));
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
                    checkedListBox1.Items.Add(reader3.GetValue(0));
                }
                groupBox5.Location = groupBox4.Location;
                groupBox5.Show();
                groupBox4.Hide();
                groupBox3.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                con.Close();
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (cost.Text == "" || nimTime.Text == "" || nimTimeCheck.SelectedIndex == -1 || aproval.SelectedIndex == -1 || cancel.Text == "" || pictureBox1.ImageLocation== null || deposit.Text == "")
            {
                MessageBox.Show("קיימים פרטים חסרים, אנא מלא את כלל השדות");
            }
            else
            {
                if ((checkedListBox1.CheckedItems.Count==0)&& (carType.SelectedIndex== -1 || carModel.Text == "" || carManu.Text == "" || carYear.Text == "") && (textBox11.Text == "" || realestateType.SelectedIndex== -1) && (condition.SelectedIndex == -1|| secondHandType.SelectedIndex == -1) && (gender.SelectedIndex == -1 || animalType.SelectedIndex== -1 || textBox15.Text == "" || textBox16.Text == ""))
                {
                    MessageBox.Show("קיימים פרטים חסרים, אנא מלא את כלל השדות");
                }
                else
                {
                    if (double.Parse(cost.Text) > 0 && double.Parse(deposit.Text) > 0)
                    {
                        MessageBox.Show("לא ניתן להזין פיקדון עבור עלות מוצר שגדולה מ0");
                    }
                    else
                    {
                        OleDbCommand cmdCounter = new OleDbCommand("SELECT ProductsCounter FROM RegisteredUser WHERE ID='" + Settings.user.getID() + "'", con);
                        con.Open();
                        cmdCounter.ExecuteNonQuery();
                        OleDbDataReader reader1 = cmdCounter.ExecuteReader();
                        reader1.Read();
                        int counter = int.Parse(reader1.GetValue(0).ToString());
                        con.Close();

                        if (comboBox1.SelectedItem.Equals("רכב"))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            con.Open();
                            cmd.CommandText = "INSERT INTO Vehicle ([productID],[lessorID],[rentalCost],[minimalRentTime],[approvalApproach],[isOnlyPartOfPackage],[cancelPolicy],[image],[deposit],[avgScore],[viewCount],[canBeTraded],[type],[model],[manufacture],[yearOfManufacture],[isAutomatic],[rankCons])VALUES('" + counter + "','" + Settings.user.getID() + "','" + int.Parse(cost.Text) + "','" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "','" + aproval.SelectedItem.ToString() + "','" + isPackage.Checked.ToString() + "','" + cancel.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + int.Parse(deposit.Text) + "','" + 0 + "','" + 0 + "','" + isTraded.Checked.ToString() + "','" + carType.SelectedItem.ToString() + "','" + carModel.Text + "','" + carManu.Text + "','" + double.Parse(carYear.Text) + "','" + isAutomatic.Checked.ToString() + "','" + numericUpDown1.Value  + "')";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();

                            Vehicle temp = new Vehicle(counter, Settings.user.getID(), double.Parse(cost.Text), nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString(), aproval.SelectedItem.ToString(), isPackage.Checked.ToString(), cancel.Text, pictureBox1.ImageLocation.ToString(), int.Parse(deposit.Text), 0, 0, isTraded.Checked.ToString(), carType.SelectedItem.ToString(), carModel.Text, carManu.Text, double.Parse(carYear.Text), isAutomatic.Checked.ToString());
                            Settings.user.myProducts.Add(temp);
                            counter++;
                            MessageBox.Show("SUCCESED");
                            con.Close();
                            this.Close();
                        }
                        else if (comboBox1.SelectedItem.Equals("נדלן"))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            con.Open();
                            cmd.CommandText = "INSERT INTO RealEstate ([productID],[lessorID],[rentalCost],[minimalRentTime],[approvalApproach],[isOnlyPartOfPackage],[cancelPolicy],[image],[deposit],[avgScore],[viewCount],[canBeTraded],[type],[capacity],[rankCons])VALUES('" + counter + "','" + Settings.user.getID() + "','" + int.Parse(cost.Text) + "','" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "','" + aproval.SelectedItem.ToString() + "','" + isPackage.Checked.ToString() + "','" + cancel.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + int.Parse(deposit.Text) + "','" + 0 + "','" + 0 + "','" + isTraded.Checked.ToString() + "','" + realestateType.SelectedItem.ToString() + "','" + int.Parse(textBox11.Text) + "','" + numericUpDown1.Value + "')";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();

                            RealEstate temp = new RealEstate(counter, Settings.user.getID(), double.Parse(cost.Text), nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString(), aproval.SelectedItem.ToString(), isPackage.Checked.ToString(), cancel.Text, pictureBox1.ImageLocation.ToString(), int.Parse(deposit.Text), 0, 0, isTraded.Checked.ToString(), realestateType.SelectedItem.ToString(), int.Parse(textBox11.Text));
                            Settings.user.myProducts.Add(temp);
                            counter++;
                            MessageBox.Show("SUCCESED");
                            con.Close();
                            this.Close(); ;
                        }
                        else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            con.Open();
                            cmd.CommandText = "INSERT INTO SecondHandProduct ([productID],[lessorID],[rentalCost],[minimalRentTime],[approvalApproach],[isOnlyPartOfPackage],[cancelPolicy],[image],[deposit],[avgScore],[viewCount],[canBeTraded],[subCategory],[condition],[rankCons])VALUES('" + counter + "','" + Settings.user.getID() + "','" + int.Parse(cost.Text) + "','" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "','" + aproval.SelectedItem.ToString() + "','" + isPackage.Checked.ToString() + "','" + cancel.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + int.Parse(deposit.Text) + "','" + 0 + "','" + 0 + "','" + isTraded.Checked.ToString() + "','" + secondHandType.SelectedItem.ToString() + "','" + condition.SelectedItem.ToString() + "','"+numericUpDown1.Value +  "')";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();


                            SecondHandProduct temp = new SecondHandProduct(counter, Settings.user.getID(), double.Parse(cost.Text), nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString(), aproval.SelectedItem.ToString(), isPackage.Checked.ToString(), cancel.Text, pictureBox1.ImageLocation.ToString(), int.Parse(deposit.Text), 0, 0, isTraded.Checked.ToString(), secondHandType.SelectedItem.ToString(), condition.SelectedItem.ToString());
                            Settings.user.myProducts.Add(temp);
                            counter++;
                            MessageBox.Show("SUCCESED");
                            con.Close();
                            this.Close();
                        }
                        else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            con.Open();
                            cmd.CommandText = "INSERT INTO Pets ([productID],[lessorID],[rentalCost],[minimalRentTime],[approvalApproach],[isOnlyPartOfPackage],[cancelPolicy],[image],[deposit],[avgScore],[viewCount],[canBeTraded],[animalType],[gender],[age],[breed],[rankCons])VALUES('" + counter + "','" + Settings.user.getID() + "','" + int.Parse(cost.Text) + "','" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "','" + aproval.SelectedItem.ToString() + "','" + isPackage.Checked.ToString() + "','" + cancel.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + int.Parse(deposit.Text) + "','" + 0 + "','" + 0 + "','" + isTraded.Checked.ToString() + "','" + animalType.SelectedItem.ToString() + "','" + gender.SelectedItem.ToString() + "','" + int.Parse(textBox15.Text) + "','" + textBox16.Text + "','" + numericUpDown1.Value  +"')";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();

                            Pets temp = new Pets(counter, Settings.user.getID(), double.Parse(cost.Text), nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString(), aproval.SelectedItem.ToString(), isPackage.Checked.ToString(), cancel.Text, pictureBox1.ImageLocation.ToString(), int.Parse(deposit.Text), 0, 0, isTraded.Checked.ToString(), animalType.SelectedItem.ToString(), gender.SelectedItem.ToString(), int.Parse(textBox15.Text), textBox16.Text);
                            Settings.user.myProducts.Add(temp);
                            counter++;
                            MessageBox.Show("SUCCESED");
                            con.Close();
                            this.Close();
                        }
                        else if (comboBox1.SelectedItem.Equals("חבילה"))
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            con.Open();
                            cmd.CommandText = "INSERT INTO Package ([productID],[lessorID],[rentalCost],[minimalRentTime],[approvalApproach],[isOnlyPartOfPackage],[cancelPolicy],[image],[deposit],[avgScore],[viewCount],[canBeTraded],[rankCons])VALUES('" + counter + "','" + Settings.user.getID() + "','" + int.Parse(cost.Text) + "','" + nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString() + "','" + aproval.SelectedItem.ToString() + "','" + isPackage.Checked.ToString() + "','" + cancel.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + int.Parse(deposit.Text) + "','" + 0 + "','" + 0 + "','" + isTraded.Checked.ToString() + "','" + numericUpDown1.Value  +"')";
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();

                            Package temp = new Package(counter, Settings.user.getID(), double.Parse(cost.Text), nimTime.Text + " " + nimTimeCheck.SelectedItem.ToString(), aproval.SelectedItem.ToString(), isPackage.Checked.ToString(), cancel.Text, pictureBox1.ImageLocation.ToString(), int.Parse(deposit.Text), 0, 0, isTraded.Checked.ToString());
                            foreach (object s in checkedListBox1.CheckedItems)
                            {
                                //DataRowView castedItem = s as DataRowView;
                                int productid = int.Parse(s.ToString());
                                Product p = Settings.user.getProductById(productid);
                                temp.products.Add(p);

                                cmd.CommandText = "INSERT INTO ProductsInPackage ([lessorID],[PackageID],[ProductID])VALUES('" + Settings.user.getID() + "','" + counter + "','" + productid + "')";
                                cmd.Connection = con;
                                cmd.ExecuteNonQuery();

                            }
                            Settings.user.myProducts.Add(temp);
                            counter++;
                            MessageBox.Show("SUCCESED");
                            con.Close();
                            this.Close();
                        }


                        OleDbCommand cmd1 = new OleDbCommand();
                        con.Open();
                        cmd1.CommandText = "UPDATE RegisteredUser SET ProductsCounter = '" + counter + "' WHERE ID = '" + Settings.user.getID() + "'";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ImageLocation = dlg.FileName;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void nimTimeCheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void isPackage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void isTraded_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aproval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aproval.SelectedItem.Equals("שמרנית"))
                {
                groupBox6.Show();
                groupBox6.Focus();
             
            }
            else
                groupBox6.Hide();
               
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nimTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddEquipment add = new AddEquipment();
            add.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
