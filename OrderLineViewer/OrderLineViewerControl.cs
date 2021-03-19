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

namespace OrderLineViewer
{
    public partial class OrderLineViewerControl : UserControl
    {
        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private int _quantityOrdered;

        public int QuantityOrdered
        {
            get { return _quantityOrdered; }
            set { _quantityOrdered = value; }
        }
        private double _priceEach;

        public double PriceEach
        {
            get { return _priceEach; }
            set { _priceEach = value; }
        }

        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private Image _image;

        public Image OrderImage
        {
            get { return _image; }
            set { _image = value; }
        }

        public OrderLineViewerControl()
        {
            InitializeComponent();
        }

        public void OnOrderLineCreated()
        {
            productNameLabel.Text = "Product: " + ProductName;
            quantityLabel.Text = "Quantity: " + QuantityOrdered.ToString();
            priceEachLabel.Text = "Price: " + PriceEach.ToString();
            totalLabel.Text = "Total: " + (PriceEach * QuantityOrdered).ToString();
            orderLinePictureBox.Image = OrderImage;
        }

        private void orderLinePictureBox_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var productLines = db.GetProductLines();
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, productLines.Count);
            String rndProductLine = productLines[rndIndex];

            var newPhoto = db.GetNewImage(rndProductLine);

            MemoryStream ms = new MemoryStream(newPhoto.Image);
            Image img = Image.FromStream(ms);
            orderLinePictureBox.Image = img;
        }
    }
}
