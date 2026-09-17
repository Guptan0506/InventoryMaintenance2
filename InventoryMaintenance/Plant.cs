using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        public string Size { get; set; }

        public Plant() { }

        public Plant(int itemNo, string desc, decimal price, string size) : base(itemNo, desc, price)
        {
            Size = size;
        }

        public override string GetDisplayText()
        {
            return $"{ItemNo} {Size} {Description} ({Price})";
        }
    }
}
