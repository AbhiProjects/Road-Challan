namespace RoadChallanApplication
{
    partial class frmRoadChallan
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
            this.lblInvoice = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.lblIDate = new System.Windows.Forms.Label();
            this.txtIDate = new System.Windows.Forms.TextBox();
            this.lblDistributor = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblCartoons = new System.Windows.Forms.Label();
            this.lblDDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDDate = new System.Windows.Forms.TextBox();
            this.txtCartoons = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbDistributorName = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(15, 90);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(59, 13);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Invoice No";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(98, 87);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(100, 20);
            this.txtInvoice.TabIndex = 3;
            this.txtInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoice_KeyPress);
            // 
            // lblIDate
            // 
            this.lblIDate.AutoSize = true;
            this.lblIDate.Location = new System.Drawing.Point(206, 90);
            this.lblIDate.Name = "lblIDate";
            this.lblIDate.Size = new System.Drawing.Size(68, 13);
            this.lblIDate.TabIndex = 2;
            this.lblIDate.Text = "Invoice Date";
            // 
            // txtIDate
            // 
            this.txtIDate.Location = new System.Drawing.Point(280, 87);
            this.txtIDate.Name = "txtIDate";
            this.txtIDate.Size = new System.Drawing.Size(100, 20);
            this.txtIDate.TabIndex = 4;
            this.txtIDate.Leave += new System.EventHandler(this.txtIDate_Leave);
            // 
            // lblDistributor
            // 
            this.lblDistributor.AutoSize = true;
            this.lblDistributor.Location = new System.Drawing.Point(15, 51);
            this.lblDistributor.Name = "lblDistributor";
            this.lblDistributor.Size = new System.Drawing.Size(85, 13);
            this.lblDistributor.TabIndex = 4;
            this.lblDistributor.Text = "Distributor Name";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(15, 124);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Quantity";
            // 
            // lblCartoons
            // 
            this.lblCartoons.AutoSize = true;
            this.lblCartoons.Location = new System.Drawing.Point(15, 162);
            this.lblCartoons.Name = "lblCartoons";
            this.lblCartoons.Size = new System.Drawing.Size(80, 13);
            this.lblCartoons.TabIndex = 6;
            this.lblCartoons.Text = "No Of Cartoons";
            // 
            // lblDDate
            // 
            this.lblDDate.AutoSize = true;
            this.lblDDate.Location = new System.Drawing.Point(204, 162);
            this.lblDDate.Name = "lblDDate";
            this.lblDDate.Size = new System.Drawing.Size(75, 13);
            this.lblDDate.TabIndex = 7;
            this.lblDDate.Text = "Dispatch Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(206, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(280, 124);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(98, 121);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtDDate
            // 
            this.txtDDate.Location = new System.Drawing.Point(280, 159);
            this.txtDDate.Name = "txtDDate";
            this.txtDDate.Size = new System.Drawing.Size(100, 20);
            this.txtDDate.TabIndex = 8;
            this.txtDDate.Leave += new System.EventHandler(this.txtDDate_Leave);
            // 
            // txtCartoons
            // 
            this.txtCartoons.Location = new System.Drawing.Point(98, 159);
            this.txtCartoons.MaxLength = 2;
            this.txtCartoons.Name = "txtCartoons";
            this.txtCartoons.Size = new System.Drawing.Size(100, 20);
            this.txtCartoons.TabIndex = 7;
            this.txtCartoons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartoons_KeyPress);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(18, 202);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbDistributorName
            // 
            this.cmbDistributorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDistributorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDistributorName.FormattingEnabled = true;
            this.cmbDistributorName.Location = new System.Drawing.Point(103, 48);
            this.cmbDistributorName.Name = "cmbDistributorName";
            this.cmbDistributorName.Size = new System.Drawing.Size(277, 21);
            this.cmbDistributorName.TabIndex = 2;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(15, 13);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(82, 13);
            this.lblCompany.TabIndex = 15;
            this.lblCompany.Text = "Company Name";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(106, 10);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(274, 21);
            this.cmbCompanyName.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(165, 202);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(301, 202);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmRoadChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 237);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.cmbCompanyName);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbDistributorName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtCartoons);
            this.Controls.Add(this.txtDDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDDate);
            this.Controls.Add(this.lblCartoons);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDistributor);
            this.Controls.Add(this.txtIDate);
            this.Controls.Add(this.lblIDate);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.lblInvoice);
            this.KeyPreview = true;
            this.Name = "frmRoadChallan";
            this.Text = "Road Challan";
            this.Load += new System.EventHandler(this.frmRoadChallan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoadChallan_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label lblIDate;
        private System.Windows.Forms.TextBox txtIDate;
        private System.Windows.Forms.Label lblDistributor;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblCartoons;
        private System.Windows.Forms.Label lblDDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDDate;
        private System.Windows.Forms.TextBox txtCartoons;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbDistributorName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;

    }
}

