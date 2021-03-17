
namespace OrderViewer
{
    partial class OrderViewerControl
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.shippedDateLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.requiredDateLabel = new System.Windows.Forms.Label();
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(871, 255);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(21, 43);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(35, 13);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "label1";
            // 
            // shippedDateLabel
            // 
            this.shippedDateLabel.AutoSize = true;
            this.shippedDateLabel.Location = new System.Drawing.Point(432, 43);
            this.shippedDateLabel.Name = "shippedDateLabel";
            this.shippedDateLabel.Size = new System.Drawing.Size(35, 13);
            this.shippedDateLabel.TabIndex = 1;
            this.shippedDateLabel.Text = "label2";
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(147, 43);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(35, 13);
            this.orderDateLabel.TabIndex = 1;
            this.orderDateLabel.Text = "label2";
            // 
            // requiredDateLabel
            // 
            this.requiredDateLabel.AutoSize = true;
            this.requiredDateLabel.Location = new System.Drawing.Point(288, 43);
            this.requiredDateLabel.Name = "requiredDateLabel";
            this.requiredDateLabel.Size = new System.Drawing.Size(35, 13);
            this.requiredDateLabel.TabIndex = 2;
            this.requiredDateLabel.Text = "label4";
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Location = new System.Drawing.Point(569, 43);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.orderStatusLabel.TabIndex = 3;
            this.orderStatusLabel.Text = "label5";
            // 
            // OrderViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderStatusLabel);
            this.Controls.Add(this.requiredDateLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Controls.Add(this.shippedDateLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "OrderViewerControl";
            this.Size = new System.Drawing.Size(877, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label shippedDateLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label requiredDateLabel;
        private System.Windows.Forms.Label orderStatusLabel;
    }
}
