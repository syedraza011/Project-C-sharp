using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CSC330.Models
{
    class Person
    {
        public Person()
        {
        }

        public Person(int id, string name, string address, string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone; 
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public override string ToString()
        {
             return "" + Id + ", " + Name + "," + Address +"," + Address +",";
        }
      
    }
}
