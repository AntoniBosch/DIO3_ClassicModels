using OrderViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIO3_ClassicModelsUI
{
    public partial class Form1 : Form
    {
        
        public event EventHandler<OrderSelectedEventArgs> OrderSelected;

        List<Customer> customers = new List<Customer>();
        List<Order> orders = new List<Order>();
        public Form1()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            String toSearch = searchTextBox.Text;
            customers = db.getClientNames(toSearch);

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            namesFoundListBox.DataSource = customers;
            namesFoundListBox.DisplayMember = "Info";           
        }

        private void namesFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = namesFoundListBox.SelectedIndex;
            string name = customers[selectedIndex].getCustomerName();

            DataAccess db = new DataAccess();
            orders = db.getOrdersByName(name);
            ordersFoundComboBox.Items.Clear();
            
            for(int i = 0; i < orders.Count; i++)
            {
                ordersFoundComboBox.Items.Add(orders[i].getOrderNumber().ToString());
            }
        }

        private void ordersFoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderViewerControl.OrderNumber = int.Parse(ordersFoundComboBox.Text);
            orderViewerControl.OnOrderChanged();
            orderViewerControl.Visible = true;
        }
        protected virtual void OnOrderChanged(OrderSelectedEventArgs e)
        {
            OrderSelected?.Invoke(this, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderViewerControl.Visible = false;
        }
    }
}
