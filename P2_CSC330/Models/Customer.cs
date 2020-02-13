using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CSC330.Models
{

    class Customer:Person
    {
        public Customer(int Id, string Name,string Address, string Phone, double spending ):base(Id,Name,Address,Phone)
        {
            Spending = spending;
        }
        public double Spending { get; set; }
        public override string ToString()
        {
            return "" + Id + ", " + Name + "," + Address + "," + Address + "," + Spending + " ";
        }
        public  bool Add(Customer TempCustomer)
        {
            
            return false;
        }
        public bool update(Customer TempCustomer)
        {
            return true;
        }
        public bool Remove(Customer TempCustomer)
        {
            return false;
        }
        public double ViewSpendinds(int TempId)
        {
            return 2.0;
        }
        public void ViewCutsomers()
        {

        }
    }
}
