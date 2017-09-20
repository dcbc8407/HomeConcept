namespace SavingGrace
{
    partial class Scheduling
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
            this.SchedulingGrid = new System.Windows.Forms.DataGridView();
            this.ScheduleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SchedulingGrid
            // 
            this.SchedulingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleDate,
            this.ScheduleCustomer,
            this.ScheduleDescription,
            this.ScheduleQuote});
            this.SchedulingGrid.Location = new System.Drawing.Point(12, 184);
            this.SchedulingGrid.Name = "SchedulingGrid";
            this.SchedulingGrid.Size = new System.Drawing.Size(781, 425);
            this.SchedulingGrid.TabIndex = 7;
            // 
            // ScheduleDate
            // 
            this.ScheduleDate.HeaderText = "Date";
            this.ScheduleDate.Name = "ScheduleDate";
            this.ScheduleDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ScheduleDate.Width = 75;
            // 
            // ScheduleCustomer
            // 
            this.ScheduleCustomer.HeaderText = "Customer";
            this.ScheduleCustomer.Name = "ScheduleCustomer";
            this.ScheduleCustomer.Width = 200;
            // 
            // ScheduleDescription
            // 
            this.ScheduleDescription.HeaderText = "Job Description";
            this.ScheduleDescription.Name = "ScheduleDescription";
            this.ScheduleDescription.Width = 360;
            // 
            // ScheduleQuote
            // 
            this.ScheduleQuote.HeaderText = "Quote Value";
            this.ScheduleQuote.Name = "ScheduleQuote";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scheduling";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SchedulingGrid);
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.SchedulingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SchedulingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}