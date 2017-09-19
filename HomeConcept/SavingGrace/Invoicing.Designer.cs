namespace SavingGrace
{
    partial class Invoicing
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOpenInvoices = new System.Windows.Forms.TabPage();
            this.tabNewInvoice = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.InvoiceNumber = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.invItemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabOpenInvoices.SuspendLayout();
            this.tabNewInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNumber,
            this.CreateDate,
            this.CustomerName,
            this.invTerms,
            this.InvoiceDue,
            this.InvoiceAmount,
            this.InvDueDate,
            this.InvoiceStatus,
            this.InvoiceCreator});
            this.dataGridView1.Location = new System.Drawing.Point(3, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1058, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoicing";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 562);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOpenInvoices);
            this.tabControl1.Controls.Add(this.tabNewInvoice);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 598);
            this.tabControl1.TabIndex = 5;
            // 
            // tabOpenInvoices
            // 
            this.tabOpenInvoices.Controls.Add(this.panel1);
            this.tabOpenInvoices.Location = new System.Drawing.Point(4, 22);
            this.tabOpenInvoices.Name = "tabOpenInvoices";
            this.tabOpenInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpenInvoices.Size = new System.Drawing.Size(1072, 572);
            this.tabOpenInvoices.TabIndex = 0;
            this.tabOpenInvoices.Text = "Open Invoices";
            this.tabOpenInvoices.UseVisualStyleBackColor = true;
            // 
            // tabNewInvoice
            // 
            this.tabNewInvoice.Controls.Add(this.dataGridView2);
            this.tabNewInvoice.Controls.Add(this.button1);
            this.tabNewInvoice.Controls.Add(this.comboBox2);
            this.tabNewInvoice.Controls.Add(this.label8);
            this.tabNewInvoice.Controls.Add(this.dateTimePicker1);
            this.tabNewInvoice.Controls.Add(this.label7);
            this.tabNewInvoice.Controls.Add(this.comboBox1);
            this.tabNewInvoice.Controls.Add(this.label6);
            this.tabNewInvoice.Controls.Add(this.label5);
            this.tabNewInvoice.Controls.Add(this.label4);
            this.tabNewInvoice.Controls.Add(this.label3);
            this.tabNewInvoice.Controls.Add(this.label2);
            this.tabNewInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabNewInvoice.Name = "tabNewInvoice";
            this.tabNewInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewInvoice.Size = new System.Drawing.Size(1072, 572);
            this.tabNewInvoice.TabIndex = 1;
            this.tabNewInvoice.Text = "Create New Invoice";
            this.tabNewInvoice.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(974, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvoiceNumber
            // 
            this.InvoiceNumber.HeaderText = "Invoice Number";
            this.InvoiceNumber.Name = "InvoiceNumber";
            this.InvoiceNumber.ReadOnly = true;
            this.InvoiceNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Date Created";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 210;
            // 
            // invTerms
            // 
            this.invTerms.HeaderText = "Terms";
            this.invTerms.Name = "invTerms";
            this.invTerms.ReadOnly = true;
            // 
            // InvoiceDue
            // 
            this.InvoiceDue.HeaderText = "Balance Due";
            this.InvoiceDue.Name = "InvoiceDue";
            this.InvoiceDue.ReadOnly = true;
            // 
            // InvoiceAmount
            // 
            this.InvoiceAmount.HeaderText = "Original Balance";
            this.InvoiceAmount.Name = "InvoiceAmount";
            this.InvoiceAmount.ReadOnly = true;
            // 
            // InvDueDate
            // 
            this.InvDueDate.HeaderText = "Payment Due";
            this.InvDueDate.Name = "InvDueDate";
            // 
            // InvoiceStatus
            // 
            this.InvoiceStatus.HeaderText = "Status";
            this.InvoiceStatus.Name = "InvoiceStatus";
            this.InvoiceStatus.ReadOnly = true;
            // 
            // InvoiceCreator
            // 
            this.InvoiceCreator.HeaderText = "Created By";
            this.InvoiceCreator.Name = "InvoiceCreator";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invItemNum,
            this.invDescrip,
            this.invUnitCost,
            this.invQty,
            this.invTotalPrice});
            this.dataGridView2.Location = new System.Drawing.Point(255, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(668, 150);
            this.dataGridView2.TabIndex = 23;
            // 
            // invItemNum
            // 
            this.invItemNum.HeaderText = "Item SKU";
            this.invItemNum.Name = "invItemNum";
            // 
            // invDescrip
            // 
            this.invDescrip.HeaderText = "Item Description";
            this.invDescrip.Name = "invDescrip";
            this.invDescrip.Width = 170;
            // 
            // invUnitCost
            // 
            this.invUnitCost.HeaderText = "Unit Cost";
            this.invUnitCost.Name = "invUnitCost";
            // 
            // invQty
            // 
            this.invQty.HeaderText = "Quantity";
            this.invQty.Name = "invQty";
            // 
            // invTotalPrice
            // 
            this.invTotalPrice.HeaderText = "Total Price";
            this.invTotalPrice.Name = "invTotalPrice";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(958, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "9-17-2017";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "00001";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Invoice Terms";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Invoice Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Invoice Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer";
            // 
            // Invoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 660);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Invoicing";
            this.Text = "Invoicing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabOpenInvoices.ResumeLayout(false);
            this.tabNewInvoice.ResumeLayout(false);
            this.tabNewInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOpenInvoices;
        private System.Windows.Forms.TabPage tabNewInvoice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewLinkColumn InvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceCreator;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn invItemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn invUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn invQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn invTotalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}