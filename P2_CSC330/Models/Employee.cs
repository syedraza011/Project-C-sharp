using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CSC330.Models
{
    class Employee: Person
    {
        public Employee (int Id, String Name, String Address, String Phone, String ssn, double salary):base (Id,Name,Address,Phone)
        {
            SSN = ssn;
            Salary = salary;
        }
        public String SSN { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return "" + Id + ", " + Name + "," + Address + "," + Address + "," + SSN + "," + Salary+ ",";
        }
        public bool Add(Employee TempEmployee)
        {

            return false;
        }
        public bool update(Employee TempEmployee)
        {
            return true;
        }
        public bool Remove(Employee TempEmployee)
        {
            return false;
        }
        public bool Remove(int TempID)
        {
            //Employee temp = new Employee(12,raza,8600 address, 12343,101020020,2500);
           return true;
        }
        public double ViewSalary(int TempId)
        {
            return 2.0;
        }
        public void ViewEmployees()
        {

        }
    }
}
