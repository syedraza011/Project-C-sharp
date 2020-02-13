using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace P2_CSC330
{
    public partial class UserChoice : Form
    {
        static int attempt = 3;
        static string connetionString = "Data Source=DESKTOP-9P17GOR;Initial Catalog=POS; Integrated Security = SSPI;";
        static SqlConnection Con = new SqlConnection(connetionString);
        public UserChoice()
        {
            InitializeComponent();
            //Form2 newForm = new Form2();
            //newForm.Show();
            //this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(textUserName.Text=="")
            {
                MessageBox.Show("Please Enter User Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textUserName.Focus();
            }
            if(textPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPassword.Focus();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("select count (*) as cnt  * from POS_UChoic where UserName=@user and Password=@pwd", Con);
                if (attempt == 0)
                {
                    MessageBox.Show("ALL ATTEMPTS HAVE FAILED - CONTACT ADMIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
               
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user", textUserName.Text);
                cmd.Parameters.AddWithValue("@pwd", textPassword.Text);
                Con.Open();

               // if (cmd.ExecuteScalar().ToString() == "1")
               if(textUserName.Text == "admin" && textPassword.Text == "admin")
               { 
                    MessageBox.Show("Granted Access", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin newForm = new Admin();
                    newForm.Show();
                    this.Hide();
               }
                else if (textUserName.Text == "cashier" && textPassword.Text == "cash")
                {
                    MessageBox.Show("Granted Access", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cashier newForm = new Cashier();
                    newForm.Show();
                    this.Hide();
                }

                else
                {


                    MessageBox.Show("Access Denied", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    --attempt;
                    textUserName.Clear();
                    textPassword.Clear();
                }
                
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
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
