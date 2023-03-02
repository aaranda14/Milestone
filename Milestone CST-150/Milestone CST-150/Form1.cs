using System.Collections.Generic;

namespace Milestone_CST_150
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string item = txtItemName.Text;
            inventory.AddItem(item);
            txtItemName.Text = "";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string item = txtItemName.Text;
            inventory.RemoveItem(item);
            txtItemName.Text = "";
        }

        private void btnShowInventory_Click(object sender, EventArgs e)
        {
            List<string> items = inventory.GetAllItems();
            string inventoryText = "Current Inventory:\n";
            foreach (string item in items)
            {
                inventoryText += item + "\n";
            }
            MessageBox.Show(inventoryText, "Inventory");
        }
    }
}