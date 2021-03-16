namespace MHighSchool
{
    partial class Staff_records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_records));
            this.subasd = new System.Windows.Forms.Button();
            this.staffdetails = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // subasd
            // 
            this.subasd.BackColor = System.Drawing.Color.LightGray;
            this.subasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subasd.Location = new System.Drawing.Point(554, 52);
            this.subasd.Name = "subasd";
            this.subasd.Size = new System.Drawing.Size(180, 27);
            this.subasd.TabIndex = 62;
            this.subasd.Text = "Subjects Assigned";
            this.subasd.UseVisualStyleBackColor = false;
            this.subasd.Click += new System.EventHandler(this.subasd_Click);
            // 
            // staffdetails
            // 
            this.staffdetails.BackColor = System.Drawing.Color.LightGray;
            this.staffdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.staffdetails.Location = new System.Drawing.Point(212, 52);
            this.staffdetails.Name = "staffdetails";
            this.staffdetails.Size = new System.Drawing.Size(180, 27);
            this.staffdetails.TabIndex = 63;
            this.staffdetails.Text = "Staff Details";
            this.staffdetails.UseVisualStyleBackColor = false;
            this.staffdetails.Click += new System.EventHandler(this.staffdetails_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(13, 136);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.Size = new System.Drawing.Size(1029, 323);
            this.gridview.TabIndex = 64;
            // 
            // Staff_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 471);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.staffdetails);
            this.Controls.Add(this.subasd);
            this.Name = "Staff_records";
            this.Text = "Staff_records";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subasd;
        private System.Windows.Forms.Button staffdetails;
        private System.Windows.Forms.DataGridView gridview;
    }
}