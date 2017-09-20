namespace SavingGrace
{
    partial class main
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
            this.CostMngButton = new System.Windows.Forms.Button();
            this.QuoteButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.InvoicingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CostMngButton
            // 
            this.CostMngButton.BackColor = System.Drawing.Color.Gray;
            this.CostMngButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostMngButton.ForeColor = System.Drawing.Color.White;
            this.CostMngButton.Location = new System.Drawing.Point(99, 16);
            this.CostMngButton.Name = "CostMngButton";
            this.CostMngButton.Size = new System.Drawing.Size(100, 100);
            this.CostMngButton.TabIndex = 0;
            this.CostMngButton.Text = "Cost Management";
            this.CostMngButton.UseVisualStyleBackColor = false;
            // 
            // QuoteButton
            // 
            this.QuoteButton.BackColor = System.Drawing.Color.Gray;
            this.QuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteButton.ForeColor = System.Drawing.Color.White;
            this.QuoteButton.Location = new System.Drawing.Point(205, 16);
            this.QuoteButton.Name = "QuoteButton";
            this.QuoteButton.Size = new System.Drawing.Size(100, 100);
            this.QuoteButton.TabIndex = 1;
            this.QuoteButton.Text = "Quotation";
            this.QuoteButton.UseVisualStyleBackColor = false;
            this.QuoteButton.Click += new System.EventHandler(this.QuoteButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.BackColor = System.Drawing.Color.Gray;
            this.ScheduleButton.FlatAppearance.BorderSize = 10;
            this.ScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleButton.ForeColor = System.Drawing.Color.White;
            this.ScheduleButton.Location = new System.Drawing.Point(311, 16);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(100, 100);
            this.ScheduleButton.TabIndex = 2;
            this.ScheduleButton.Text = "Scheduling";
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.Gray;
            this.CustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Location = new System.Drawing.Point(417, 16);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(100, 100);
            this.CustomersButton.TabIndex = 3;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // InvoicingButton
            // 
            this.InvoicingButton.BackColor = System.Drawing.Color.Gray;
            this.InvoicingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoicingButton.ForeColor = System.Drawing.Color.White;
            this.InvoicingButton.Location = new System.Drawing.Point(523, 16);
            this.InvoicingButton.Name = "InvoicingButton";
            this.InvoicingButton.Size = new System.Drawing.Size(100, 100);
            this.InvoicingButton.TabIndex = 4;
            this.InvoicingButton.Text = "Invoicing";
            this.InvoicingButton.UseVisualStyleBackColor = false;
            this.InvoicingButton.Click += new System.EventHandler(this.InvoicingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.CostMngButton);
            this.panel1.Controls.Add(this.InvoicingButton);
            this.panel1.Controls.Add(this.QuoteButton);
            this.panel1.Controls.Add(this.CustomersButton);
            this.panel1.Controls.Add(this.ScheduleButton);
            this.panel1.Location = new System.Drawing.Point(-4, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 136);
            this.panel1.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(629, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 100);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(801, 229);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CostMngButton;
        private System.Windows.Forms.Button QuoteButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button InvoicingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
    }
}