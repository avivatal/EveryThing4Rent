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
    public partial class TradeIn : Form
    {
        DataGridViewRow tradewith;
        string Type;
        double productId;
        double cost;
        public TradeIn(DataGridViewRow str)
        {
            tradewith = str;
            InitializeComponent();
            OleDbConnection con = Settings.con;
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
            while (reader.HasRows && total > 0)
            {
                total--;
                reader.Read();
                checkedListBox1.Items.Add(reader.GetValue(0)+ " Vehicle");
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
                checkedListBox1.Items.Add(reader1.GetValue(0)+ " RealEstate");
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
                checkedListBox1.Items.Add(reader2.GetValue(0) + " Pets");
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
                checkedListBox1.Items.Add(reader3.GetValue(0)+ " SecondHandProduct");
            }
            label6.Visible = false;
            label5.Visible = false;
            con.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label5.Visible = true;
            productId = double.Parse(checkedListBox1.SelectedItem.ToString().Substring(0, checkedListBox1.SelectedItem.ToString().IndexOf(" ")));
            Type = checkedListBox1.SelectedItem.ToString().Substring(checkedListBox1.SelectedItem.ToString().IndexOf(" ") + 1);

            OleDbConnection con = Settings.con;
            con.Open();

            OleDbCommand selectedProductToTrade = new OleDbCommand("SELECT rentalCost FROM " + Type + " WHERE productID='" + productId + "' AND lessorID='" + Settings.user.getID() + "'", con);
            selectedProductToTrade.ExecuteNonQuery();

            OleDbDataReader selectedReader = selectedProductToTrade.ExecuteReader();
            if(selectedReader.HasRows && selectedReader.Read() && selectedReader.GetValue(0) != DBNull.Value)
            {
                cost = double.Parse(tradewith.Cells[4].FormattedValue.ToString()) - double.Parse(selectedReader.GetValue(0).ToString());
                label6.Text = cost.ToString();
            }
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = Settings.con;
            con.Open();

            OleDbCommand selectedProductToTrade = new OleDbCommand("SELECT canBeTraded FROM " + Type + " WHERE productID='" +productId + "' AND lessorID='" + Settings.user.getID() + "'", con);
            selectedProductToTrade.ExecuteNonQuery();

            OleDbDataReader selectedReader = selectedProductToTrade.ExecuteReader();
            if (selectedReader.HasRows)
            {
                if (selectedReader.Read() && selectedReader.GetValue(0) != DBNull.Value)
                {
                    OleDbCommand createRequest;
                    if (cost > 0)
                    {
                         createRequest = new OleDbCommand("INSERT INTO tradeRequest ([productID],[MyproductID],[requestedByID],[lessorID],[tradeStartDate],[tradeEndDate],[status],[submitRequestDate],[additionalPaymentRequestor],[additionalPaymentReceiver])VALUES("+double.Parse(tradewith.Cells[2].FormattedValue.ToString())+"," + productId + ",'" + Settings.user.getID() + "','" + tradewith.Cells[3].FormattedValue.ToString() + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','wait','" + DateTime.Now.Date + "'," + cost + "," + 0 + ")", con);
                    }
                    else
                    {
                         createRequest = new OleDbCommand("INSERT INTO tradeRequest ([productID],[MyproductID],[requestedByID],[lessorID],[tradeStartDate],[tradeEndDate],[status],[submitRequestDate],[additionalPaymentRequestor],[additionalPaymentReceiver])VALUES(" + double.Parse(tradewith.Cells[2].FormattedValue.ToString()) + "," + productId + ",'" + Settings.user.getID() + "','" + tradewith.Cells[3].FormattedValue.ToString() + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','wait','" + DateTime.Now.Date + "'," + 0 + "," + -cost + ")", con);
                    }
                  //  createRequest.CommandType = System.Data.CommandType.Text;
                    createRequest.ExecuteNonQuery();
                    MessageBox.Show("הבקשה נשלחה בהצלחה");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("לא ניתן לבצע החלפה עם המוצר שבחרת");
                }
            }
            con.Close();
        }
    }
}
