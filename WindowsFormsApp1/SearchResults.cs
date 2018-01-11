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
    public partial class SearchResults : Form
    {
        string query;
        public void setQuery(string q)
        {
            query = q;
        }
        public SearchResults()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // here you can have column reference by using e.ColumnIndex
            //    DataGridViewImageCell cell = (DataGridViewImageCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.RowIndex == 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }
            
            // ... do something ...
        }
        private void SearchResults_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            OleDbCommand show = new OleDbCommand(query, Settings.con);
            Settings.con.Open();
            show.ExecuteNonQuery();
            DataTable ds = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(show);
            adapter.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                dataGridView1.Show();
                error.Hide();
                dataGridView1.DataSource = ds;

                

                DataGridViewCheckBoxColumn selectcolunm = new DataGridViewCheckBoxColumn();
                selectcolunm.Name = "Select Product";
                DataGridViewLinkColumn seeProduct = new DataGridViewLinkColumn();
                seeProduct.Text = "More Deatils";
                seeProduct.UseColumnTextForLinkValue = true;
               // seeProduct.LinkBehavior.
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns.Insert(0, selectcolunm);
                dataGridView1.Columns.Insert(1, seeProduct);
                dataGridView1.Columns.Remove("image");
                dataGridView1.Columns.Remove("cancelPolicy");
                dataGridView1.Columns.Remove("avgScore");
                dataGridView1.Columns.Remove("viewCount");
                dataGridView1.Columns.Remove("productID");
                dataGridView1.Columns.Remove("isOnlyPartOfPackage");

                Settings.con.Close();

                dataGridView1.Height = dataGridView1.Rows.Count * 40;
            }
            else
            {
                dataGridView1.Hide();
                error.Location = dataGridView1.Location;
                error.Text = "Couldnt find products with this filters";
                error.Show();
                Settings.con.Close();

            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.petsTableAdapter.FillBy3(this.everything4RentDataSet.Pets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
