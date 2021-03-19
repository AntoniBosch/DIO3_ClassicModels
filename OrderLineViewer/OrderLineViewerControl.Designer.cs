
namespace OrderLineViewer
{
    partial class OrderLineViewerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceEachLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.orderLinePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderLinePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(181, 34);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(35, 13);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "label1";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(436, 34);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(35, 13);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "label1";
            // 
            // priceEachLabel
            // 
            this.priceEachLabel.AutoSize = true;
            this.priceEachLabel.Location = new System.Drawing.Point(575, 34);
            this.priceEachLabel.Name = "priceEachLabel";
            this.priceEachLabel.Size = new System.Drawing.Size(35, 13);
            this.priceEachLabel.TabIndex = 2;
            this.priceEachLabel.Text = "label1";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(703, 34);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 13);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "label1";
            // 
            // orderLinePictureBox
            // 
            this.orderLinePictureBox.Location = new System.Drawing.Point(31, 3);
            this.orderLinePictureBox.Name = "orderLinePictureBox";
            this.orderLinePictureBox.Size = new System.Drawing.Size(107, 82);
            this.orderLinePictureBox.TabIndex = 4;
            this.orderLinePictureBox.TabStop = false;
            this.orderLinePictureBox.Click += new System.EventHandler(this.orderLinePictureBox_Click);
            // 
            // OrderLineViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderLinePictureBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.priceEachLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "OrderLineViewerControl";
            this.Size = new System.Drawing.Size(803, 88);
            ((System.ComponentModel.ISupportInitialize)(this.orderLinePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceEachLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox orderLinePictureBox;
    }
}
