using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }
        //Loc
        // Add a statement here that declares the list of items.
        private List<InvItem> itemList = null;
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            itemList = InvItemDB.GetItems();
            FillItemListBox();
        }
        //Loc
        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            foreach (InvItem i in itemList)
            {
                lstItems.Items.Add(i.GetDisplayText("\t"));
            }
        }
        //Loc
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            frmNewItem itemForm = new();
            // and then gets a new item from that form.
            InvItem newItem = itemForm.GetNewItem();

            if (newItem != null)
            {
                //Add item to list
                itemList.Add(newItem);
                //Save a list
                InvItemDB.SaveItems(itemList);
            }
            FillItemListBox();
        }
        //Loc
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;

            if (i != -1)
            {
                InvItem item = itemList[i];
                // Add code here that displays a dialog box to confirm
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item" + item.Description, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        // the deletion and then removes the item from the list,
                        itemList.Remove(item);
                    }
                }
                // saves the list of products, and refreshes the list box
                InvItemDB.SaveItems(itemList);
                FillItemListBox();
                // if the deletion is confirmed.
                DialogResult confirm = MessageBox.Show("Confirm Deleted", "Deletion");
            }
        }
        //Loc
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
