namespace MHighSchool
{
    partial class RecordofStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordofStudents));
            this.disp = new System.Windows.Forms.DataGridView();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.details = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // disp
            // 
            this.disp.AllowUserToAddRows = false;
            this.disp.AllowUserToDeleteRows = false;
            this.disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp.Location = new System.Drawing.Point(2, 107);
            this.disp.Name = "disp";
            this.disp.ReadOnly = true;
            this.disp.Size = new System.Drawing.Size(1016, 371);
            this.disp.TabIndex = 0;
            // 
            // searchbox
            // 
            this.searchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.searchbox.Location = new System.Drawing.Point(32, 44);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(200, 27);
            this.searchbox.TabIndex = 46;
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(247, 44);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(42, 27);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 48;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.LightGray;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.details.Location = new System.Drawing.Point(355, 44);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(180, 27);
            this.details.TabIndex = 64;
            this.details.Text = "Student Details";
            this.details.UseVisualStyleBackColor = false;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label8.Location = new System.Drawing.Point(28, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 19);
            this.label8.TabIndex = 71;
            this.label8.Text = "Search by Student Name";
            // 
            // RecordofStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 478);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.details);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.disp);
            this.Name = "RecordofStudents";
            this.Text = "RecordofStudents";
            //this.Load += new System.EventHandler(this.RecordofStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView disp;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Label label8;
    }
}