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
    public partial class Register : Form
    {
        OleDbConnection con = Settings.con;
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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
                    //PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox1.Image =  new Bitmap(dlg.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ImageLocation = dlg.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if password already exist
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || dateTimePicker1.Value.Date == null || pictureBox1.ImageLocation == null)
            {
                MessageBox.Show("you have to enter all the details");
            }
            else
            {
                //insert
                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.CommandText = "INSERT INTO RegisteredUser ([ID],[firstName],[surName],[phoneNumber],[email],[password],[image],[dateOfBirth],[payPalAcount],[isDangerous],[authorazation],[avgScore],[isReligous],[isBusinessClient],[isBroker],[ProductsCounter])VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + pictureBox1.ImageLocation.ToString() + "','" + dateTimePicker1.Value.Date + "','" + textBox6.Text + "','false','user','" + 0 + "','" + checkBox1.Checked.ToString() + "','false','false','"+0+"')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUCCESED");
                con.Close();


                //send mail
                var messageEmail = new MailMessage();
                messageEmail.To.Add(new MailAddress(textBox5.Text));
                messageEmail.From = new MailAddress("everything4rentnotonlyplace@gmail.com");
                messageEmail.Subject = "Confirmation";
                messageEmail.Body = "you register successfully";
                messageEmail.IsBodyHtml = false;
                using (var smtp = new SmtpClient())
                {
                    smtp.Credentials = new NetworkCredential("everything4rentnotonlyplace", "Y12n3t4a");
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(messageEmail);
                }

                this.Close();
            }
          }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
