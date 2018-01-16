using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductDetails : Form
    {
        public ProductDetails(string type,string productid,string lessorid,string rentalcost,string approval,string cancel,string tradein,string deposit,string minTime,string isonlypackage,string image)
        {
            InitializeComponent();
            label19.Text = type;
            label13.Text = productid;
            label12.Text = lessorid;
            label11.Text = rentalcost;
            label14.Text = approval;
            label15.Text = cancel;
            label16.Text = tradein;
            label17.Text = deposit;
            label18.Text = minTime;
            label2.Text = isonlypackage;
            pictureBox1.ImageLocation = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
