namespace MHighSchool
{
    partial class Master_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master_Records));
            this.disp = new System.Windows.Forms.DataGridView();
            this.classdetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.disp2 = new System.Windows.Forms.DataGridView();
            this.disp3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp3)).BeginInit();
            this.SuspendLayout();
            // 
            // disp
            // 
            this.disp.AllowUserToAddRows = false;
            this.disp.AllowUserToDeleteRows = false;
            this.disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.disp.Location = new System.Drawing.Point(1, 116);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(320, 342);
            this.disp.TabIndex = 0;
            // 
            // classdetails
            // 
            this.classdetails.BackColor = System.Drawing.Color.LightGray;
            this.classdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classdetails.Location = new System.Drawing.Point(52, 83);
            this.classdetails.Name = "classdetails";
            this.classdetails.Size = new System.Drawing.Size(180, 27);
            this.classdetails.TabIndex = 64;
            this.classdetails.Text = "Class Details";
            this.classdetails.UseVisualStyleBackColor = false;
            this.classdetails.Click += new System.EventHandler(this.classdetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(407, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 27);
            this.button1.TabIndex = 65;
            this.button1.Text = " Subject Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(779, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 27);
            this.button2.TabIndex = 66;
            this.button2.Text = "FeeType Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // disp2
            // 
            this.disp2.AllowUserToAddRows = false;
            this.disp2.AllowUserToDeleteRows = false;
            this.disp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.disp2.Location = new System.Drawing.Point(332, 116);
            this.disp2.Name = "disp2";
            this.disp2.Size = new System.Drawing.Size(375, 342);
            this.disp2.TabIndex = 67;
            // 
            // disp3
            // 
            this.disp3.AllowUserToAddRows = false;
            this.disp3.AllowUserToDeleteRows = false;
            this.disp3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.disp3.Location = new System.Drawing.Point(713, 116);
            this.disp3.Name = "disp3";
            this.disp3.Size = new System.Drawing.Size(320, 342);
            this.disp3.TabIndex = 68;
            // 
            // Master_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 470);
            this.Controls.Add(this.disp3);
            this.Controls.Add(this.disp2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classdetails);
            this.Controls.Add(this.disp);
            this.Name = "Master_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master_Records";
            ((System.ComponentModel.ISupportInitialize)(this.disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView disp;
        private System.Windows.Forms.Button classdetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView disp2;
        private System.Windows.Forms.DataGridView disp3;
    }
}