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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class RequestForRent : Form
    {
       string productID;
        DataGridViewRow selectedProduct;

        OleDbConnection con = Settings.con;
        public RequestForRent()
        {
            InitializeComponent();
            productID = "";
        }

        public void setProductids(DataGridViewRow selectedProducts)
        {
             productID = selectedProducts.Cells[2].FormattedValue.ToString();
             selectedProduct = selectedProducts;


        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void הגש_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == null && dateTimePicker2.Text == null)
            {
                //show error
            }
            else
            {
                //get product approval approach
                //get product type

                OleDbCommand cmd1 = new OleDbCommand("SELECT Type FROM ProductTypes WHERE (LessorID=@lessorID AND ProductID=@productID)", con);
                cmd1.Parameters.AddWithValue("@lessorID", selectedProduct.Cells[3].FormattedValue.ToString());
                cmd1.Parameters.AddWithValue("@productID", productID.ToString());
                con.Open();
                cmd1.ExecuteNonQuery();
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                


                string status = "";
                if (reader1.Read() && reader1.GetValue(0) != DBNull.Value) {
                    //get approvalApproach
                    OleDbCommand cmd2 = new OleDbCommand("SELECT approvalApproach FROM " + reader1.GetValue(0).ToString() + " WHERE LessorID='" + selectedProduct.Cells[3].FormattedValue.ToString() + "' AND ProductID='" + productID + "'", con);               // con.Open();
                    cmd2.ExecuteNonQuery();
                OleDbDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                 
                if(reader2.GetValue(0).Equals("כל הקודם זוכה"))
                {
                    status = "approved";
                }
                else if (reader2.GetValue(0).Equals("בטוחה"))
                {
                    status = "pending";
                }
                else if (reader2.GetValue(0).Equals("שמרנית"))
                {
                    status = "approved"; /////////צריך להיות מאושר ע"פ סף אמינות כלשהו
                        OleDbCommand cmd5 = new OleDbCommand("SELECT avgScore FROM RegisteredUser WHERE ID=@ID", con);
                        cmd5.Parameters.AddWithValue("@ID", Settings.user.getID());
                        
                        cmd5.ExecuteNonQuery();
                        OleDbDataReader reader5 = cmd5.ExecuteReader();
                        reader5.Read();
                        double avgscore = double.Parse(reader5.GetValue(0).ToString());
                        
                        OleDbCommand cmd6 = new OleDbCommand("SELECT rankCons FROM " + reader1.GetValue(0).ToString() + " WHERE LessorID='" + selectedProduct.Cells[3].FormattedValue.ToString() + "' AND ProductID='" + productID + "'", con);
                        cmd6.ExecuteNonQuery();
                        OleDbDataReader reader6 = cmd6.ExecuteReader();
                        reader6.Read();
                        double rankCons = double.Parse(reader6.GetValue(0).ToString());
                        
                       if (avgscore >= rankCons)
                       {
                           status = "approved";
                       }
                        else
                         {
                            status = "denied";
                                                  }
                    }

                }
                string lessorID = selectedProduct.Cells[3].FormattedValue.ToString();
                //add to DB
                OleDbCommand cmd3 = new OleDbCommand();
                // con.Open();
                cmd3.CommandText = "INSERT INTO RentalRequests ([LesseID],[ProductID],[StartDate],[EndDate],[Status],[LessorID])VALUES('" + Settings.user.getID() + "','" + productID + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','" + status + "','" + lessorID + "')";
                cmd3.Connection = con;
                cmd3.ExecuteNonQuery();
                //  con.Close();

                //get lessor email
                lessorID = selectedProduct.Cells[3].FormattedValue.ToString(); ///////check index
                string email = "";
                OleDbCommand cmd4 = new OleDbCommand("SELECT email FROM RegisteredUser WHERE ID='" + lessorID + "'", con);
               // con.Open();
                cmd4.ExecuteNonQuery();
                OleDbDataReader reader4 = cmd4.ExecuteReader();
                reader4.Read();
               // con.Close();
                email = reader4.GetValue(0).ToString();


                //send email to lessor that has received a request
                if (status.Equals("approved"))
                {
                    var messageEmail = new MailMessage();
                    messageEmail.To.Add(new MailAddress(email));
                    messageEmail.From = new MailAddress("everything4rentnotonlyplace@gmail.com");
                    messageEmail.Subject = "Rental Request";
                    messageEmail.Body = "You have received a new rental request. It has been automatically approved and the requestor has received a request to complete the order payment.";
                    messageEmail.IsBodyHtml = false;
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Credentials = new NetworkCredential("everything4rentnotonlyplace", "Y12n3t4a");
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(messageEmail);
                    }
                }
                else if (status.Equals("pending"))
                {
                    var messageEmail = new MailMessage();
                    messageEmail.To.Add(new MailAddress(email));
                    messageEmail.From = new MailAddress("everything4rentnotonlyplace@gmail.com");
                    messageEmail.Subject = "Rental Request";
                    messageEmail.Body = "You have received a new rental request. You may review it by entering your account.";
                    messageEmail.IsBodyHtml = false;
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Credentials = new NetworkCredential("everything4rentnotonlyplace", "Y12n3t4a");
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(messageEmail);
                    }
                }
                con.Close();
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
