namespace MHighSchool
{
    partial class Payment_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Records));
            this.disp = new System.Windows.Forms.DataGridView();
            this.paydate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.collection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).BeginInit();
            this.SuspendLayout();
            // 
            // disp
            // 
            this.disp.AllowUserToAddRows = false;
            this.disp.AllowUserToDeleteRows = false;
            this.disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp.Location = new System.Drawing.Point(353, 1);
            this.disp.Name = "disp";
            this.disp.ReadOnly = true;
            this.disp.Size = new System.Drawing.Size(693, 458);
            this.disp.TabIndex = 0;
            // 
            // paydate
            // 
            this.paydate.CustomFormat = "dd/MM/yyyy";
            this.paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paydate.Location = new System.Drawing.Point(147, 36);
            this.paydate.Name = "paydate";
            this.paydate.Size = new System.Drawing.Size(200, 24);
            this.paydate.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 75;
            this.label9.Text = "DATE:";
            // 
            // collection
            // 
            this.collection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.collection.Location = new System.Drawing.Point(147, 87);
            this.collection.Name = "collection";
            this.collection.Size = new System.Drawing.Size(149, 28);
            this.collection.TabIndex = 76;
            this.collection.Text = "Daily Collection";
            this.collection.UseVisualStyleBackColor = true;
            this.collection.Click += new System.EventHandler(this.collection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "COLLECTION IS";
            // 
            // mo
            // 
            this.mo.AutoSize = true;
            this.mo.BackColor = System.Drawing.Color.Transparent;
            this.mo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mo.Location = new System.Drawing.Point(173, 169);
            this.mo.Name = "mo";
            this.mo.Size = new System.Drawing.Size(18, 18);
            this.mo.TabIndex = 78;
            this.mo.Text = "::";
            // 
            // Payment_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 471);
            this.Controls.Add(this.mo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paydate);
            this.Controls.Add(this.disp);
            this.Name = "Payment_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Records";
            ((System.ComponentModel.ISupportInitialize)(this.disp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView disp;
        private System.Windows.Forms.DateTimePicker paydate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button collection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mo;
    }
}