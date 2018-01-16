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
    public partial class AddEquipment : Form
    {
        OleDbConnection con = Settings.con;
        List<string> listboxItems;
        OleDbCommand cmdCounter;
        OleDbDataReader reader1;
        OleDbCommand cmd;
        int productID;

        public AddEquipment()
        {
            InitializeComponent();
            listboxItems = new List<string>();
            listBox1.DataSource = listboxItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get counter
            cmdCounter = new OleDbCommand("SELECT ProductsCounter FROM RegisteredUser WHERE ID='" + Settings.user.getID() + "'", con);
            con.Open();
            cmdCounter.ExecuteNonQuery();
            reader1 = cmdCounter.ExecuteReader();
            reader1.Read();
            productID = int.Parse(reader1.GetValue(0).ToString());
            con.Close();


            //add record to DB
            if (comboBox1.SelectedItem!= null&& !comboBox1.SelectedItem.Equals(""))
            {
                cmd = new OleDbCommand("INSERT INTO Equipment ([RealEstate_ID],[Lessor_id],[Equipment],[Quantity])VALUES('" + productID + "','" + Settings.user.getID() + "','" + comboBox1.SelectedItem + "','" + numericUpDown1.Value + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //add item to listbox
                listboxItems.Add(comboBox1.SelectedItem + ", " + numericUpDown1.Value);
                listBox1.DataSource = null;
                listBox1.DataSource = listboxItems;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            string item = "";

            // Remove the item in the listbox

            try
            {
                if (selectedIndex == -1)
                    {
                        MessageBox.Show("אנא בחר מוצר להסרה");
                    }
                    else
                    {
                        item = listboxItems.ElementAt(selectedIndex);
                        listboxItems.RemoveAt(selectedIndex);


                        listBox1.DataSource = null;
                        listBox1.DataSource = listboxItems;

                        //remove from DB
                        cmd = new OleDbCommand("DELETE FROM Equipment WHERE RealEstate_ID=@productID AND Lessor_id=@lessorID AND Equipment=@equipment AND Quantity=@quantity", con);
                        cmd.Parameters.AddWithValue("@productID", productID.ToString());
                        cmd.Parameters.AddWithValue("@lessorID", Settings.user.getID());
                        cmd.Parameters.AddWithValue("@equipment", item.Substring(0, item.IndexOf(',')));
                        cmd.Parameters.AddWithValue("@quantity", (item.Substring(item.IndexOf(',') + 2).ToString()));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
        }
        catch{
        }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
