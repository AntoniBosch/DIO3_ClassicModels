
namespace DIO3_ClassicModelsUI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ordersFoundComboBox = new System.Windows.Forms.ComboBox();
            this.namesFoundListBox = new System.Windows.Forms.ListBox();
            this.customerNameLbael = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderViewerControl = new OrderViewer.OrderViewerControl();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(51, 47);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // ordersFoundComboBox
            // 
            this.ordersFoundComboBox.FormattingEnabled = true;
            this.ordersFoundComboBox.Location = new System.Drawing.Point(536, 47);
            this.ordersFoundComboBox.Name = "ordersFoundComboBox";
            this.ordersFoundComboBox.Size = new System.Drawing.Size(121, 21);
            this.ordersFoundComboBox.TabIndex = 1;
            this.ordersFoundComboBox.SelectedIndexChanged += new System.EventHandler(this.ordersFoundComboBox_SelectedIndexChanged);
            // 
            // namesFoundListBox
            // 
            this.namesFoundListBox.FormattingEnabled = true;
            this.namesFoundListBox.HorizontalScrollbar = true;
            this.namesFoundListBox.Location = new System.Drawing.Point(210, 47);
            this.namesFoundListBox.Name = "namesFoundListBox";
            this.namesFoundListBox.Size = new System.Drawing.Size(251, 95);
            this.namesFoundListBox.TabIndex = 2;
            this.namesFoundListBox.SelectedIndexChanged += new System.EventHandler(this.namesFoundListBox_SelectedIndexChanged);
            // 
            // customerNameLbael
            // 
            this.customerNameLbael.Location = new System.Drawing.Point(48, 31);
            this.customerNameLbael.Name = "customerNameLbael";
            this.customerNameLbael.Size = new System.Drawing.Size(103, 13);
            this.customerNameLbael.TabIndex = 0;
            this.customerNameLbael.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orders found:";
            // 
            // orderViewerControl
            // 
            this.orderViewerControl.Location = new System.Drawing.Point(12, 211);
            this.orderViewerControl.Name = "orderViewerControl";
            this.orderViewerControl.OrderNumber = 0;
            this.orderViewerControl.Size = new System.Drawing.Size(940, 476);
            this.orderViewerControl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 699);
            this.Controls.Add(this.orderViewerControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameLbael);
            this.Controls.Add(this.namesFoundListBox);
            this.Controls.Add(this.ordersFoundComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox ordersFoundComboBox;
        private System.Windows.Forms.ListBox namesFoundListBox;
        private System.Windows.Forms.Label customerNameLbael;
        private System.Windows.Forms.Label label1;
        private OrderViewer.OrderViewerControl orderViewerControl;
    }
}

