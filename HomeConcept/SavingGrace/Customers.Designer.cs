namespace SavingGrace
{
    partial class Customers
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CustomerOwes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumber,
            this.CustomersFirstName,
            this.CustomersLastName,
            this.CustomerAddress,
            this.CustomerCity,
            this.CustomerState,
            this.CustomerOwes});
            this.CustomersGrid.Location = new System.Drawing.Point(12, 101);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(779, 470);
            this.CustomersGrid.TabIndex = 8;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.HeaderText = "Customer Number";
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Width = 75;
            // 
            // CustomersFirstName
            // 
            this.CustomersFirstName.HeaderText = "First Name";
            this.CustomersFirstName.Name = "CustomersFirstName";
            this.CustomersFirstName.Width = 110;
            // 
            // CustomersLastName
            // 
            this.CustomersLastName.HeaderText = "Last Name";
            this.CustomersLastName.Name = "CustomersLastName";
            this.CustomersLastName.Width = 110;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Width = 200;
            // 
            // CustomerCity
            // 
            this.CustomerCity.HeaderText = "City";
            this.CustomerCity.Name = "CustomerCity";
            this.CustomerCity.Width = 80;
            // 
            // CustomerState
            // 
            this.CustomerState.HeaderText = "State";
            this.CustomerState.Name = "CustomerState";
            this.CustomerState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CustomerState.Width = 60;
            // 
            // CustomerOwes
            // 
            this.CustomerOwes.HeaderText = "Outstanding Balance";
            this.CustomerOwes.Name = "CustomerOwes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(685, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer Directory";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCity;
        private System.Windows.Forms.DataGridViewComboBoxColumn CustomerState;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerOwes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}