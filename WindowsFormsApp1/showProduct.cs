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
    public partial class showProduct : Form
    {
        String type;
        OleDbConnection con = Settings.con;

        public showProduct()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "SELECT * FROM " + type + " WHERE productID=? AND lessorID='"+Settings.user.getID()+"';";
              cmd.Parameters.Add(new OleDbParameter { Value = comboBox2.SelectedItem.ToString() });
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            OleDbDataReader reader = cmd.ExecuteReader();


            String message = "";
            if (reader.Read())
            {
                message = "Product ID: ";
                message += reader.GetValue(0).ToString() +
                "\nRental Cost: " + reader.GetValue(2).ToString() +
               "\nMinimal Rental Time: " + reader.GetValue(3).ToString() +
                "\nApproval Approach: " + reader.GetValue(4).ToString() +
                "\nIs Only Part Of Package: " + reader.GetValue(5).ToString() +
                "\nCancel Policy: " + reader.GetValue(6).ToString() +
                "\nDeposit: " + reader.GetValue(8).ToString() +
                "\nAverage Score: " + reader.GetValue(9).ToString() +
                "\nNumber Of Views: " + reader.GetValue(10).ToString() +
                "\nCan Be Traded: " + reader.GetValue(11).ToString();

                
            }
            if (type.Equals("RealEstate"))
            {
                 message += "\nEstate Type: " + reader.GetValue(12).ToString()
                    + "\nCapacity: " + reader.GetValue(13).ToString();

                if (reader.GetValue(4).ToString().Equals("שמרנית"))
                    message += "\nMinimal approval rating: " + reader.GetValue(14).ToString();
            }
            else if (type.Equals("Vehicle"))
            {

                message += "\nVehicle Type: " + reader.GetValue(12).ToString() +
                    "\nModel: " + reader.GetValue(13).ToString() +
                    "\nManufacture: " + reader.GetValue(14).ToString() +
                    "\nYear: " + reader.GetValue(15).ToString() +
                    "\nIs Automatic: " + reader.GetValue(16).ToString();

                if (reader.GetValue(4).ToString().Equals("שמרנית"))
                    message += "\nMinimal approval rating: " + reader.GetValue(17).ToString();

            }
            else if (type.Equals("Pets"))
            {
                message += "\nAnimal Type: " + reader.GetValue(12).ToString() +
                    "\nGender: " + reader.GetValue(13).ToString() +
                    "\nAge: " + reader.GetValue(14).ToString() +
                    "\nBreed: " + reader.GetValue(15).ToString();

                if (reader.GetValue(4).ToString().Equals("שמרנית"))
                    message += "\nMinimal approval rating: " + reader.GetValue(16).ToString();
            }
            else if (type.Equals("SecondHandProduct"))
            {
                message += "\nSubcategory: " + reader.GetValue(12).ToString() +
                    "\nCondition: " + reader.GetValue(13).ToString();

                if (reader.GetValue(4).ToString().Equals("שמרנית"))
                    message += "\nMinimal approval rating: " + reader.GetValue(14).ToString();
            }
             else if (type.Equals("Package"))
             {
                message += "\nThe Package Contains The Following Products: ";
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText="SELECT * FROM ProductsInPackage WHERE PackageID=?;" ;
                cmd1.Parameters.Add(new OleDbParameter { Value = comboBox2.SelectedItem.ToString() });
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                OleDbDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    message += "\nProduct ID: " + reader1.GetValue(2).ToString();
                }

                if (reader.GetValue(4).ToString().Equals("שמרנית"))
                    message += "\nMinimal approval rating: " + reader.GetValue(12).ToString();
            }
            DialogResult ddd = MessageBox.Show(message, "צפה", MessageBoxButtons.OK);
          /*  PictureBox p = new PictureBox();
            p.Image = Image.FromFile(reader.GetValue(7).ToString());
            Form view = new Form();
            TextBox txt = new TextBox();
            txt.Text += message;
            view.Controls.Add(p);
            view.Controls.Add(txt);
            view.ShowDialog();*/

            con.Close();
        }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            /* foreach (Product p in Settings.user.myProducts)
             {
                 if (comboBox1.SelectedItem.Equals("נדלן"))
                 {
                     if (p is RealEstate)
                     {
                         comboBox2.Items.Insert(0, p.productId);
                         type = "RealEstate";
                     }
                 }
                 else if (comboBox1.SelectedItem.Equals("רכב"))
                 {
                     if (p is Vehicle)
                     {
                         comboBox2.Items.Insert(0, p.productId);
                         type = "Vehicle";
                     }
                 }
                 else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
                 {
                     if (p is Pets)
                     {
                         comboBox2.Items.Add(p.productId);
                         type = "Pets";
                     }
                 }
                 else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
                 {
                     if (p is SecondHandProduct)
                     {
                         comboBox2.Items.Add(p.productId);
                         type = "SecondHandProduct";
                     }
                 }
                 else if (comboBox1.SelectedItem.Equals("חבילה"))
                 {
                     if (p is Package)
                     {
                         comboBox2.Items.Add(p.productId);
                         type = "Package";
                     }
                 }

             }*/
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem.Equals("נדלן"))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                comboBox2.Items.Clear();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM RealEstate WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    type = "RealEstate";

                }
                con.Close();


            }
            else if (comboBox1.SelectedItem.Equals("רכב"))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                comboBox2.Items.Clear();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM Vehicle WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    type = "Vehicle";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("חיות מחמד"))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Pets WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                comboBox2.Items.Clear();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM Pets WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    type = "Pets";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("מוצרי יד שנייה"))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                comboBox2.Items.Clear();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM SecondHandProduct WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    type = "SecondHandProduct";

                }
                con.Close();
            }
            else if (comboBox1.SelectedItem.Equals("חבילה"))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ProductID FROM Package WHERE lessorID='" + Settings.user.getID() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                comboBox2.Items.Clear();
                OleDbCommand cmd1 = new OleDbCommand("SELECT COUNT(*) FROM Package WHERE lessorID='" + Settings.user.getID() + "'", con);
                cmd1.ExecuteNonQuery();
                int total = (Int32)cmd1.ExecuteScalar();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows && total > 0)
                {
                    total--;
                    reader.Read();
                    comboBox2.Items.Add(reader.GetValue(0));
                    type = "Package";

                }
                con.Close();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
