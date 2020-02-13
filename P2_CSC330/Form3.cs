using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace P2_CSC330
{
    public partial class Customer : Form
    {
        static string connetionString = "Data Source=DESKTOP-9P17GOR;Initial Catalog=POS; Integrated Security = SSPI;";
        static SqlConnection Con = new SqlConnection(connetionString);
        public int CustomerId;
        public Customer()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSCustomerSet.POS_CustomerTB' table. You can move, or remove it, as needed.
            //this.pOS_CustomerTBTableAdapter.Fill(this.pOSCustomerSet.POS_CustomerTB);
            GetAllCustomers();
           // ResetControls();
        }
        private void GetAllItems()
        {

            SqlCommand cmd = new SqlCommand("select * from POS_CustomerTB", Con);
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
        // Method for adding a customer
        private void TextInsert_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {

       
                SqlCommand cmd = new SqlCommand("Insert INTO POS_CustomerTB Values(@Name, @Address, @Phone, @Spending)", Con);
                try
                {
                    Con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@Spending", textSpendings.Text);
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
                    this.GetAllCustomers();
                    ResetControls();
                }
                MessageBox.Show("Customer Successfully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // this.allItemsTableAdapter.Fill(this.itemsData.allItems);
                // ResetControls();
                textName.Focus();
            }
            bool IsValid()
            {
                if (textName.Text == string.Empty)
                {
                    MessageBox.Show("Customer Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            //---------
           
            //---------------

        }
        // fucntion to update Customer's information
        private void textUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                CustomerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (CustomerId > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE POS_CustomerTB set Name=@Name, Address=@Address, Phone=@Phone, Spendings=@Spending where id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@Spending", textSpendings.Text);
                    cmd.Parameters.AddWithValue("@Id", CustomerId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("Customer Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GetAllCustomers();

                }

                else
                {
                    MessageBox.Show("Please Select a customer to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Table Must have at least One Customer to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            this.dataGridView1_CellClick(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    CustomerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    textName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    textSpendings.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception es)
            {

            }

          //    private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
         //{
           
         //    }

        }

       

        private void GetAllCustomers()
        {
            SqlCommand cmd = new SqlCommand("select * from POS_CustomerTB", Con);
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
               cmd.ExecuteNonQuery();
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
        // fucntion to reset the form Boxes
        private void textReset_Click(object sender, EventArgs e)
        {
            
           
                ResetControls();
            
           
        }

            private void ResetControls()
            {
                CustomerId = 0;
                textName.Clear();
                textAddress.Clear();
                textPhone.Clear();
                textSpendings.Clear();
                  textName.Focus();
            }



        // function to remove a Customer from database 
        private void textRemove_Click(object sender, EventArgs e)
        {
            // this condition to make sure the table is not empty
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CustomerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (CustomerId > 0)
                {

                    SqlCommand cmd = new SqlCommand("Delete FROM POS_CustomerTB where Id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", CustomerId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    this.GetAllCustomers();
                    MessageBox.Show("Customer Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please Select a Customer to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Table Must have at least One Customer to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }// ending customer form 
}
