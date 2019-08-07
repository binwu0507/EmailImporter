namespace EmailParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReceiveEmail = new System.Windows.Forms.Button();
            this.dgvEmailHeaders = new System.Windows.Forms.DataGridView();
            this.webBrowserEmailBody = new System.Windows.Forms.WebBrowser();
            this.btnScrap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPONumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShipTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.dtSince = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtPriceBreakdown = new System.Windows.Forms.TextBox();
            this.cbIsAutoForwarded = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReceiveEmail
            // 
            this.btnReceiveEmail.Location = new System.Drawing.Point(2111, 45);
            this.btnReceiveEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceiveEmail.Name = "btnReceiveEmail";
            this.btnReceiveEmail.Size = new System.Drawing.Size(230, 67);
            this.btnReceiveEmail.TabIndex = 1;
            this.btnReceiveEmail.Text = "Check Emails";
            this.btnReceiveEmail.UseVisualStyleBackColor = true;
            this.btnReceiveEmail.Click += new System.EventHandler(this.btnReceiveEmail_Click);
            // 
            // dgvEmailHeaders
            // 
            this.dgvEmailHeaders.AllowUserToOrderColumns = true;
            this.dgvEmailHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmailHeaders.Location = new System.Drawing.Point(12, 121);
            this.dgvEmailHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmailHeaders.Name = "dgvEmailHeaders";
            this.dgvEmailHeaders.RowTemplate.Height = 33;
            this.dgvEmailHeaders.Size = new System.Drawing.Size(2328, 456);
            this.dgvEmailHeaders.TabIndex = 2;
            this.dgvEmailHeaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmailHeaders_CellContentClick);
            // 
            // webBrowserEmailBody
            // 
            this.webBrowserEmailBody.Location = new System.Drawing.Point(12, 631);
            this.webBrowserEmailBody.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowserEmailBody.MinimumSize = new System.Drawing.Size(20, 19);
            this.webBrowserEmailBody.Name = "webBrowserEmailBody";
            this.webBrowserEmailBody.Size = new System.Drawing.Size(2328, 613);
            this.webBrowserEmailBody.TabIndex = 3;
            // 
            // btnScrap
            // 
            this.btnScrap.Enabled = false;
            this.btnScrap.Location = new System.Drawing.Point(12, 1275);
            this.btnScrap.Margin = new System.Windows.Forms.Padding(4);
            this.btnScrap.Name = "btnScrap";
            this.btnScrap.Size = new System.Drawing.Size(326, 69);
            this.btnScrap.TabIndex = 4;
            this.btnScrap.Text = "Retrieve Order Information";
            this.btnScrap.UseVisualStyleBackColor = true;
            this.btnScrap.Click += new System.EventHandler(this.btnScrap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 60);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 31);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "nothingwu2000@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Passord";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(614, 56);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 31);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "paradise0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(908, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(992, 56);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(673, 31);
            this.txtFrom.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 1391);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "PO Number";
            // 
            // txtPONumber
            // 
            this.txtPONumber.Location = new System.Drawing.Point(156, 1389);
            this.txtPONumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(227, 31);
            this.txtPONumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 1391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(844, 1389);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(972, 1391);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1055, 1389);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 31);
            this.txtPrice.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1183, 1391);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ship To";
            // 
            // txtShipTo
            // 
            this.txtShipTo.Location = new System.Drawing.Point(1292, 1389);
            this.txtShipTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtShipTo.Name = "txtShipTo";
            this.txtShipTo.Size = new System.Drawing.Size(404, 31);
            this.txtShipTo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1710, 1391);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(1834, 1389);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(500, 31);
            this.txtCompany.TabIndex = 20;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(1894, 1275);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(446, 71);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 1391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Invoice Date";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(575, 1389);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(132, 31);
            this.txtInvoiceDate.TabIndex = 23;
            // 
            // dtSince
            // 
            this.dtSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSince.Location = new System.Drawing.Point(1830, 58);
            this.dtSince.Name = "dtSince";
            this.dtSince.Size = new System.Drawing.Size(200, 31);
            this.dtSince.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1745, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Since";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(952, 1319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Item #";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(1047, 1313);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(649, 31);
            this.txtItemNumber.TabIndex = 27;
            // 
            // txtPriceBreakdown
            // 
            this.txtPriceBreakdown.Location = new System.Drawing.Point(1759, 1313);
            this.txtPriceBreakdown.Name = "txtPriceBreakdown";
            this.txtPriceBreakdown.Size = new System.Drawing.Size(100, 31);
            this.txtPriceBreakdown.TabIndex = 28;
            // 
            // cbIsAutoForwarded
            // 
            this.cbIsAutoForwarded.AutoSize = true;
            this.cbIsAutoForwarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsAutoForwarded.Location = new System.Drawing.Point(435, 1291);
            this.cbIsAutoForwarded.Name = "cbIsAutoForwarded";
            this.cbIsAutoForwarded.Size = new System.Drawing.Size(275, 29);
            this.cbIsAutoForwarded.TabIndex = 30;
            this.cbIsAutoForwarded.Text = "Auto Forwarded Email";
            this.cbIsAutoForwarded.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2372, 1442);
            this.Controls.Add(this.cbIsAutoForwarded);
            this.Controls.Add(this.txtPriceBreakdown);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtSince);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShipTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnScrap);
            this.Controls.Add(this.webBrowserEmailBody);
            this.Controls.Add(this.dgvEmailHeaders);
            this.Controls.Add(this.btnReceiveEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Order Retriever";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailHeaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReceiveEmail;
        private System.Windows.Forms.DataGridView dgvEmailHeaders;
        private System.Windows.Forms.WebBrowser webBrowserEmailBody;
        private System.Windows.Forms.Button btnScrap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPONumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtShipTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtSince;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtPriceBreakdown;
        private System.Windows.Forms.CheckBox cbIsAutoForwarded;
    }
}

