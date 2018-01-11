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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class deleteProduct : Form
    {
        OleDbConnection con = Settings.con;
        String type;
        public deleteProduct()
        {
            InitializeComponent();
        }

        private void deleteProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'everything4RentDataSet.Package' table. You can move, or remove it, as needed.
          //  this.packageTableAdapter.Fill(this.everything4RentDataSet.Package);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        //add the users items to the second combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        //delete the selected product
        private void button2_Click(object sender, EventArgs e)
        {

            //delete from users product array
            foreach(Product p in Settings.user.myProducts)
            {
                if (comboBox2.SelectedItem.Equals(p.productId)){
                    Settings.user.myProducts.Remove(p);
                    break;
                }
            }
            
            //delete from DB
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.CommandText = "DELETE FROM "+ type+" WHERE productID= ? lessorID='"+Settings.user.getID()+"'";
            cmd.Parameters.Add(new OleDbParameter { Value = comboBox2.SelectedItem });
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            DialogResult msg = MessageBox.Show("המוצר נמחק בהצלחה", "אישור מחיקה", MessageBoxButtons.OK);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
