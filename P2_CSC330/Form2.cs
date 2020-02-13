using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P2_CSC330
{
    public partial class Form2 : Form
    {
        static string connetionString = "Data Source=DESKTOP-9P17GOR;Initial Catalog=POS; Integrated Security = SSPI;";
        static SqlConnection Con = new SqlConnection(connetionString);
        SqlCommand cmd = new SqlCommand("select * from POS_EmployeesTB", Con);

        public Form2()
        {
            InitializeComponent();
        }

        public int EmployeeId;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSItemDataSet.POS_ItemsTB' table. You can move, or remove it, as needed.
            this.pOS_EmployeesTBTableAdapter.Fill(this.pOSEmployeeSet.POS_EmployeesTB);
            GetAllIEmployees();

        }

        private void GetAllIEmployees()
        {

            SqlCommand cmd = new SqlCommand("select * from POS_EmployeesTB", Con);
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

                
                SqlCommand cmd = new SqlCommand("Insert INTO POS_EmployeesTB Values(@Name, @Address, @Phone, @SSN, @Salary)", Con);
                try
                {
                    Con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@SSN", textSSN.Text);
                    cmd.Parameters.AddWithValue("@Salary", textSalary.Text);
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
                    this.GetAllIEmployees();
                }
                MessageBox.Show("Employee Successfully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
                textName.Focus();
            }
        }
        private bool IsValid()
        {
            if (textName.Text == string.Empty)
            {
                MessageBox.Show("Employee Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

      
       
        //Updating Function
        private void txtUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                EmployeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (EmployeeId > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE POS_EmployeesTB set Name=@Name, Address=@Address, Phone=@Phone, SSN=@SSN, Salary=@Salary where id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@SSN", textSSN.Text);
                    cmd.Parameters.AddWithValue("@Salary", textSalary.Text);
                    cmd.Parameters.AddWithValue("@Id", EmployeeId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Employee Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GetAllIEmployees();
                }
                else
                {
                    MessageBox.Show("Please Select an Employee to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("At least one Employee needed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //to Delete an Item
        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                EmployeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                if (EmployeeId > 0)
                {

                    SqlCommand cmd = new SqlCommand("Delete FROM POS_EmployeesTB where Id=@Id", Con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", EmployeeId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    this.GetAllIEmployees();
                    MessageBox.Show("Employee Successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please Select an Employee to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("At least one Employee needed to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            EmployeeId = 0;
            textName.Clear();
            textAddress.Clear();
            textPhone.Clear();
            textSSN.Clear();
            textSalary.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textSSN.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textSalary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

       
        private void dataGridView1_RowStateChanged_1(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    EmployeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    textName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    textSSN.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    textSalary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
            catch(Exception es)
            {

            }
        }
    }
}
