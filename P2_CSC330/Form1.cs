using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace P2_CSC330
{
    public partial class Form1 : Form
    {

        static string connetionString = "Data Source=DESKTOP-9P17GOR;Initial Catalog=POS; Integrated Security = SSPI;";
        static SqlConnection Con = new SqlConnection(connetionString);

        public Form1()
        {

            InitializeComponent();
            //UserChoice newForm = new UserChoice();
            //newForm.Show();
            //this.Hide();

        }
       
        public int ItemId;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllItems();

            // TODO: This line of code loads data into the 'pOSItemDataSet.POS_ItemsTB' table. You can move, or remove it, as needed.
           // this.pOS_ItemsTBTableAdapter.Fill(this.pOSItemDataSet.POS_ItemsTB);
            // TODO: This line of code loads data into the 'itemsData.allItems' table. You can move, or remove it, as needed.

        }
        
        private void GetAllItems()
        {
            
            SqlCommand cmd = new SqlCommand("select * from POS_ItemsTB", Con);
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Error!");
            }
            finally
            {
                Con.Close();
            }
           
            Con.Close();
            dataGridView1.DataSource = dt;

        }
        //to insert Data
        private void txtInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                //this.allItemsTableAdapter.Fill(this.itemsData.allItems);
                SqlCommand cmd = new SqlCommand("Insert INTO POS_ItemsTB Values(@Name, @CostPrice, @SellPrice, @Quantity)", Con);
                try
                {
                    Con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@CostPrice", txtCostPrice.Text);
                    cmd.Parameters.AddWithValue("@SellPrice", txtSellPrice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Connection Error!" + ex.ToString());
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Con.Close();
                    this.GetAllItems();
                }
              MessageBox.Show("Item Successfully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.allItemsTableAdapter.Fill(this.itemsData.allItems);
                ResetControls();
                txtName.Focus();
            }
        }
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Item Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtSellPrice.Text==string.Empty)
            {
                MessageBox.Show("Item Sell Price is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtQuantity.Text == string.Empty)
            {
                MessageBox.Show("Item Sell Price is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetControls();
            txtName.Focus();
        }

        private void ResetControls()
        {
            ItemId = 0;
            txtName.Clear();
            txtCostPrice.Clear();
            txtSellPrice.Clear();
            txtQuantity.Clear();
        }

        private void ItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCostPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtSellPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        //Updating Function
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (ItemId > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE POS_ItemsTB set Name=@Name, Cost=@CostPrice, Sell=@SellPrice, Quantity=@Quantity where id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@CostPrice", txtCostPrice.Text);
                    cmd.Parameters.AddWithValue("@SellPrice", txtSellPrice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Id", ItemId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Item Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GetAllItems();
                }
                else
                {
                    MessageBox.Show("Please Select an Item to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Item Table Must have at least one item available to UPDATE", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //to Delete an Item
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (ItemId > 0)
                {

                    SqlCommand cmd = new SqlCommand("Delete FROM POS_ItemsTB where Id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", ItemId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    this.GetAllItems();
                    MessageBox.Show("Item Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please Select an Item to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Item Table Must have at least one item available to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // this.pOS_ItemsTBTableAdapter.Fill(this.pOSItemDataSet.POS_ItemsTB);

            this.ItemDataGridView_CellClick(sender,e);
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtCostPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtSellPrice.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception es)
            {

               
            }
          

        }

        private void Item_Load(object sender, EventArgs e)
        {
            this.GetAllItems();
        }
    }
}
