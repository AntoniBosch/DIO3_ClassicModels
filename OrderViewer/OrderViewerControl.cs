using OrderLineViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderViewer
{
    public partial class OrderViewerControl : UserControl
    {

        private int _searchOrderNumber;
        List<OrderDetail> orderDetail = new List<OrderDetail>();
        List<OrderLine> orderLines = new List<OrderLine>();

        public int OrderNumber
        {
            get { return _searchOrderNumber; }
            set { _searchOrderNumber = value; }
        }

        public void OnOrderChanged()
        {
            orderNumberLabel.Text = "Order number: " + OrderNumber.ToString();
            DataAcess db = new DataAcess();
            orderDetail = db.GetOrderDetail(_searchOrderNumber);
            orderDateLabel.Text = "Order Date:" + orderDetail[0].OrderDate.ToShortDateString();
            requiredDateLabel.Text = "Required Date:" + orderDetail[0].RequiredDate.ToShortDateString();
            shippedDateLabel.Text = "Shipped Date:" + orderDetail[0].ShippedDate.ToShortDateString();
            orderStatusLabel.Text = "Status:" + orderDetail[0].Status;
            getOrderLine();
        }

        public void getOrderLine()
        {
            flowLayoutPanel.Controls.Clear();
            DataAcess db = new DataAcess();
            orderLines = db.GetOrdersLines(_searchOrderNumber);
            foreach(OrderLine line in orderLines)
            {
                OrderLineViewerControl olv = new OrderLineViewerControl();
                olv.ProductName = line.ProductName;
                olv.PriceEach = line.PriceEach;
                olv.QuantityOrdered = line.QuantityOrdered;
                //MemoryStream ms = new MemoryStream(line.Image);
                //Image orderImage = Image.FromStream(ms);
                //olv.OrderImage = orderImage;
                olv.OnOrderLineCreated();
                flowLayoutPanel.Controls.Add(olv);

            }
            
            //olv.ProductName = "Test Product";
            //olv.QuantityOrdered = 10;
            //olv.PriceEach = 3.5;
            //olv.OnOrderLineCreated();
            //flowLayoutPanel.Controls.Add(olv);
        }

        public OrderViewerControl()
        {
            InitializeComponent();
        }
    }
}
