namespace SimplePOS_GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.comboProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // comboProducts
            this.comboProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboProducts.Location = new System.Drawing.Point(30, 50);
            this.comboProducts.Name = "comboProducts";
            this.comboProducts.Size = new System.Drawing.Size(180, 25);

            // label1
            this.label1.Text = "Select Product:";
            this.label1.Location = new System.Drawing.Point(50, 25);

            // label2
            this.label2.Text = "Quantity:";
            this.label2.Location = new System.Drawing.Point(50, 90);

            // txtQty
            this.txtQty.Location = new System.Drawing.Point(30, 110);
            this.txtQty.Size = new System.Drawing.Size(100, 23);

            // btnCalculate
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.Location = new System.Drawing.Point(30, 150);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // txtReceipt
            this.txtReceipt.Multiline = true;
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Location = new System.Drawing.Point(30, 200);
            this.txtReceipt.Size = new System.Drawing.Size(260, 200);

            // Form1
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.comboProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtReceipt);
            this.Name = "Form1";
            this.Text = "Simple POS";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtReceipt;
    }
}
