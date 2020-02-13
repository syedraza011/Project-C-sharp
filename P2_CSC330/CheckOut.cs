using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace P2_CSC330
{
    public partial class CheckOut : Form
    {
        string input = string.Empty;
        static string connetionString = "Data Source=DESKTOP-9P17GOR;Initial Catalog=POS; Integrated Security = SSPI;";
        static SqlConnection Con = new SqlConnection(connetionString);
        public CheckOut()
        {
            InitializeComponent();
        }

        private void textItemSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSCheckoutDataSet.POS_CheckoutTB' table. You can move, or remove it, as needed.
            //this.pOS_CheckoutTBTableAdapter.Fill(this.pOSCheckoutDataSet.POS_CheckoutTB);
            this.GetAllCartItems();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtQty.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                txtName.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

                txtUnitPrice.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                txtNetPrice.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
            }

        }
        private void One_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "1";
            this.textItemSearch.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "2";
            this.textItemSearch.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "3";
            this.textItemSearch.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "4";
            this.textItemSearch.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "5";
            this.textItemSearch.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "6";
            this.textItemSearch.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "7";
            this.textItemSearch.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {

            this.textItemSearch.Text = "";
            input += "8";
            this.textItemSearch.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "9";
            this.textItemSearch.Text += input;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += "0";
            this.textItemSearch.Text += input;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            this.textItemSearch.Text = "";
            input += ".";
            this.textItemSearch.Text += input;
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBoxTotalPayment.Text = "";
            this.input = string.Empty;


        }

        private void Enter_Click(object sender, EventArgs e)
        {

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            this.textBoxTotalPayment.Text = "";
            this.input = string.Empty;


        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            //textItemSearch.Text;
            // int n = input.Length;
            //this.textBox1.Text = input.Remove(n, 1);
        }

        private void F4Btn_Click(object sender, EventArgs e)
        {
            //Code goes here
        }

        private void F5Btn_Click(object sender, EventArgs e)
        {

        }

        private void F6Btn_Click(object sender, EventArgs e)
        {

        }

        private void F7Btn_Click(object sender, EventArgs e)
        {

        }

        private void F8Btn_Click(object sender, EventArgs e)
        {

        }

        private void F9Btn_Click(object sender, EventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, EventArgs e)

        {

            TextBox txtb = (sender as TextBox);

            // remember cursor location

            int loc = txtb.SelectionStart;

            // do something with txtb.Text;

            txtb.Text = txtb.Text.Replace('$', '%');

            // set old location

            txtb.SelectionStart = loc;


        }

     
        private bool IsValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Item Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //else if (txtSellPrice.Text == string.Empty)
            //{
            //    MessageBox.Show("Item Sell Price is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //else if (.Text == string.Empty)
            //{
            //    MessageBox.Show("Item Sell Price is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }
    
         //---------

        private void txtDisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuickItemMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void QuickCutsomerMenuBtn_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer();
            frm.Show();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {

                        dataGridView.Rows.RemoveAt(row.Index);

                    }

                    MessageBox.Show("Item Successfully REMOVED", "REMOVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                

                 else
                 {
                        MessageBox.Show("Cart Must have at least one item added to REMOVE", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }
                }
            catch (Exception ex)
            {
                var Message = ex.ToString();
            }
           
        }


        private void texTotalCount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GetAllCartItems()
        {
            SqlCommand cmd = new SqlCommand("select * from POS_CheckoutTB", Con);
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
                dataGridView.DataSource = dt;


                double total = this.dataGridView.Rows.Cast<DataGridViewRow>()
                 .Sum(t => Convert.ToDouble(t.Cells[3].Value));

                int count = this.dataGridView.Rows.Cast<DataGridViewRow>()
                 .Sum(t => Convert.ToInt32(t.Cells[0].Value));

                if (total > 0)
                {
                    this.UpdateFinalNumbers(total, count);
                }
            }
           
        }

        public void UpdateFinalNumbers(double total, int count)
        {
            try
            {
                texTotalCount.Text = count.ToString();
                textBoxSubTotal.Text = total.ToString();
                var discount = total * (0.01);

                textBoxTotalDiscount.Text = discount.ToString();

                var remainingTotal = total - discount;
                var tax = remainingTotal * (0.05);

                textTotalTax.Text = tax.ToString();

                remainingTotal = remainingTotal - tax;

                textBoxTotalDue.Text = remainingTotal.ToString();
                var payment= Convert.ToDouble(textBoxTotalPayment.Text);
                if (payment >= remainingTotal)
                {
                    textBoxTotalChange.Text = (payment - remainingTotal).ToString();
                }
                else
                {
                    MessageBox.Show("Payment amount is not enough.");
                }
            }
            catch (Exception ex)
            {
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query;
            try
            {
                var searchVal = Convert.ToInt32(textItemSearch.Text);
                query="select* from POS_ItemsTB where id = " + textItemSearch.Text;
            }
            catch (Exception)
            {

                query = "select * from POS_ItemsTB where upper(Name)=upper('" + textItemSearch.Text + "')";
            }
            finally
            {
               // this.pOS_CheckoutTBTableAdapter.Fill(this.pOSCheckoutDataSet.POS_CheckoutTB);
            }

            //var query = " OR Name ='" + textItemSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                //var table = sdr.GetSchemaTable();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        var Name=sdr.GetString(1);
                        var unitPrice=sdr.GetSqlMoney(3);
                        Con.Close();
                        this.InsertIntoCart(Name, Convert.ToDouble(unitPrice.ToString()));
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
                //dt.Load(sdr);
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Error!");
            }
            finally
            {
                Con.Close();
            }

            this.GetAllCartItems();

        }

        private bool SearchAndUpdateItemInCart(string Name)
        {
            string query;
            query = "select * from POS_CheckoutTB where upper([Product Name])=upper('" + Name + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        var quantity = sdr.GetInt32(0);
                        var unitPrice = sdr.GetSqlMoney(2);
                        quantity += 1;
                        var updateQuery = "Update POS_CheckoutTB set Qunatity=" + quantity + ", [Product Total]= " + quantity * unitPrice + " where upper([Product Name])=upper('" + Name + "')";
                        cmd = new SqlCommand(updateQuery, Con);
                        Con.Close();
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Error!");
            }
            finally
            {
                Con.Close();
            }
            return false;
        }
        //------Insert Data-
        private void InsertIntoCart(string ProductName, double ProductUnitPrice)
        {
                if (this.SearchAndUpdateItemInCart(ProductName))
                {

                    return;
                }
       
                int Quantity = 1;
                SqlCommand cmd = new SqlCommand("Insert INTO POS_CheckoutTB Values(@Quantity,@Name, @SellPrice,@Total )", Con);
                try
                {
                    Con.Open();
                    var Total = Quantity * ProductUnitPrice;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", ProductName);
                    cmd.Parameters.AddWithValue("@SellPrice", ProductUnitPrice);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@Total", Total); 
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

                }
                MessageBox.Show("Item Successfully Added to Cart", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.allItemsTableAdapter.Fill(this.itemsData.allItems);

            
        }


        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if (textBoxTotalPayment.Text == "")
            {
                MessageBox.Show("Enter the amount.");
                return;
            }

            var spending = Convert.ToDouble(textBoxTotalDue.Text);
           var flag= this.UpdateCustomerSpending(spending);

            if (flag)
            {
                MessageBox.Show(txtCustomerName.Text+"'s spendings updated successfully!");
            }
            else
            {
                MessageBox.Show("Spendings not updated successfully!");
            }

            this.btnCalcChange_Click(sender, e);
        }

        private bool UpdateCustomerSpending(double spending)
        {
            try
            {
                spending += Convert.ToDouble(txtCusSpendings.Text);
                var updateQuery = "Update [POS_CustomerTB] set [Spendings]=" + spending + " where Id=upper('" + lblCustId.Text + "')";
                var cmd = new SqlCommand(updateQuery, Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Con.Close();
            }
        }

        private void SearchCustomerBtn_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            string query;
            query = "select * from [POS_CustomerTB] where upper(Name)=upper('" + txtCustomerName.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        lblCustId.Text = sdr.GetSqlInt32(0).ToString();
                        var spending = sdr.GetSqlMoney(4);
                        txtCusSpendings.Text = spending.ToString();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Customer doesn't exist in the system.");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection Error!");
            }
            finally
            {
                Con.Close();
            }

        }

        private void btnCalcChange_Click(object sender, EventArgs e)
        {
            var remainingTotal = Convert.ToDouble(textBoxTotalDue.Text);

            var payment = Convert.ToDouble(textBoxTotalPayment.Text);

            if (payment >= remainingTotal)

            {

                textBoxTotalChange.Text = Math.Round(payment - remainingTotal, 2).ToString();

            }

            else

            {

                MessageBox.Show("Payment amount is not enough.");

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to clear cart?", "Warning Message", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                var updateQuery = "Delete from [POS_CheckoutTB]";
                var cmd = new SqlCommand(updateQuery, Con);
                Con.Open();
                cmd.ExecuteNonQuery();
                texTotalCount.Text = "";
                txtCusSpendings.Text = "";
                txtCustomerName.Text = "";
                MessageBox.Show("Cart is cleared.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cart is not cleared.");
            }
            finally
            {
                Con.Close();
                
                this.GetAllCartItems();
            }

        }
    }
}
