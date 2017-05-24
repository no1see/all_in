namespace allin
{
    partial class NewService
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
            this.Stock = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Assort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Stock
            // 
            this.Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assort,
            this.Count});
            this.Stock.Location = new System.Drawing.Point(48, 12);
            this.Stock.Name = "Stock";
            this.Stock.RowHeadersVisible = false;
            this.Stock.Size = new System.Drawing.Size(240, 150);
            this.Stock.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(127, 316);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Assort
            // 
            this.Assort.HeaderText = "Product";
            this.Assort.Name = "Assort";
            this.Assort.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // NewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 402);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Stock);
            this.Name = "NewService";
            this.Text = "NewService";
            ((System.ComponentModel.ISupportInitialize)(this.Stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Stock;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}