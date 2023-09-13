using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryMaintenance
{   //Loc
    //This class demonstrates encapsulation as it puts all methods into a class. And these methods operate in that class.
    public class InvItem
    {
        public InvItem()
        {

        }
        //Loc
        //These methods below are to set or get specific class attribute
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }  
        public string GetDisplayText(string sep)
        {
            return $"{ItemNo.ToString()} {sep} {Description} {sep} {Price.ToString("c")}";
        }
        //Loc
        //Constructor which is to create an item with specific attribute.
        public InvItem(int ItemNo, string Description, decimal Price) 
        {
            this.ItemNo = ItemNo;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
