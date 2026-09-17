using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public string Manufacturer { get; set; }
        public Supply() { }
        
        // Navya Gupta
        public Supply(int itemNo, string desc, decimal price, string manufacturer) : base(itemNo, desc, price)
        {
            Manufacturer = manufacturer;
        }

        // Navya Gupta
        public override string GetDisplayText()
        {
            return $"{ItemNo} {Manufacturer} {Description} ({Price})";
        }
    }
}
