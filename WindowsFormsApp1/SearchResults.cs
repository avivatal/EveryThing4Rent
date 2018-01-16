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
        DataGridViewRow selectedRow;
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

                if (e.ColumnIndex == 1)
                {
                    //Write code
                }
            
            // ... do something ...
        }
        private void SearchResults_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            try//TODDDDDDDDDDDDDDDDDDDDDDDDDFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
            {
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

                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns.Insert(0, selectcolunm);
                    dataGridView1.Columns.Insert(1, seeProduct);
                    dataGridView1.Columns.Remove("image");
                    dataGridView1.Columns.Remove("cancelPolicy");
                    dataGridView1.Columns.Remove("avgScore");
                    dataGridView1.Columns.Remove("viewCount");
                    //    dataGridView1.Columns.Remove("productID");
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
            catch {
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String owenerId = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value!=null&&(bool)cell.Value)
                {
                    owenerId = row.Cells[3].FormattedValue.ToString();
                    selectedRow = row;
                    break;
                }
             }
            if (selectedRow.Cells[8].FormattedValue.ToString().ToLower() == "TRUE".ToLower())
            {
                if (Settings.user != null)
                {
                    if (!Settings.user.getID().Equals(owenerId))
                    {
                        TradeIn tradein = new TradeIn(selectedRow);
                        tradein.ShowDialog();
                    }
                    else {
                        MessageBox.Show("אינך יכול להחליף עם מוצר זה- מוצר זה בבעלותך");
                    }
                }
                else
                {
                    MessageBox.Show("רק משתמשים מחוברים יכולים לבצע החלפה");
                }
            }
            else
            {
                MessageBox.Show("לא ניתן לבצע החלפה עם המוצר הנבחר");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String owenerId = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != null && (bool)cell.Value)// cell.TrueValue)
                {
                    owenerId=row.Cells[3].FormattedValue.ToString();
                    selectedRow = row;

                    break;
                }
            }
           
            if (Settings.user != null)
            {
                if (!Settings.user.getID().Equals(owenerId))
                {
                    RequestForRent requestForRent = new RequestForRent();
                    requestForRent.setProductids(selectedRow);
                    requestForRent.ShowDialog();
                }

                else {
                    MessageBox.Show("אינך יכול לשכור מוצר שבבעלותך");
                }
            }
            else
            {
                MessageBox.Show("רק משתמשים מחוברים יכולים לבצע השכרה");
            }

        }
    }
}
