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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            CheckOut newForm = new CheckOut();
            newForm.Show();
           // this.Hide();
        }

        private void ItemMenuBtn_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            // this.Hide();
        }

        private void CustomerMenuBtn_Click(object sender, EventArgs e)
        {
            Customer newForm = new Customer();
            newForm.Show();
           // this.Hide();
        }
    }
}
