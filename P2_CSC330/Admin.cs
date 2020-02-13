using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_CSC330
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            CheckOut newForm = new CheckOut();
            newForm.Show();
            //this.Hide();

        }
        private void ItemMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
           // this.Hide();
        }

        private void CutomerMenuBtn_Click(object sender, EventArgs e)
        {
            Customer newForm = new Customer();
            newForm.Show();
           // this.Hide();
        }

        private void EmployeeMenuBtn_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
           // this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
