using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }
        //Loc
        // Add a statement here that declares the inventory item.
        private InvItem invItem = null;
        //Loc
        // Add a method here that gets and returns a new item.

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                invItem = new InvItem
                {
                    ItemNo = Convert.ToInt16(txtItemNo.Text),
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text)
                };
            }
            //Save a list
            // and closes the form.
            this.Close();
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Loc
        //displays the form as a dialog box and returns an InvItem object.
        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return invItem;
        }
    }
}
