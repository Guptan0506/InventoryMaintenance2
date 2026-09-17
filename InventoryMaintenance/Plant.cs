using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Plant : InvItem signifies that plant is a child class inheriting the parent class, InvItem. 
    // Then the use of base when including values that are being inherited from InvItem also signifies that this is a child class
    // There's also the use of override in GetDisplayText method that signifies inheritance.
    public class Plant : InvItem
    {
        public string Size { get; set; }

        // Navya Gupta
        public Plant() { }

        public Plant(int itemNo, string desc, decimal price, string size) : base(itemNo, desc, price)
        {
            Size = size;
        }

        //Navya Gupta
        public override string GetDisplayText()
        {
            return $"{ItemNo} {Size} {Description} ({Price})";
        }
    }
}
