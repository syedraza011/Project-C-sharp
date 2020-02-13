using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CSC330.Models
{
    class Item: AbstractClass
    {
        public Item(int id, string name, double costPrice, double sellPrice, int quantity)
        {
            Id = id;
            Name = name;
            CostPrice = costPrice;
            SellPrice = sellPrice;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public double CostPrice { get; set; }
        public double SellPrice { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return "" + Id + ", " + Name + "," + CostPrice + "," + SellPrice + "," + Quantity + "";
        }
          public override bool Add()
        {
            return true;
        }
           public override bool Edit()
        {
            return true;
        }
         public override bool Remove()
         {
                return true;
         }
        
        public override bool Search()
        {
            return true;
        }

    }
}
