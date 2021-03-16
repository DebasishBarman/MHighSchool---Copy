namespace MHighSchool
{
    partial class Update_delete_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_delete_Class));
            this.classname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            this.SuspendLayout();
            // 
            // classname
            // 
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.Location = new System.Drawing.Point(308, 110);
            this.classname.Multiline = true;
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 29);
            this.classname.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(133, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "CLASS NAME :";
            // 
            // classcode
            // 
            this.classcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classcode.Location = new System.Drawing.Point(308, 48);
            this.classcode.Multiline = true;
            this.classcode.Name = "classcode";
            this.classcode.Size = new System.Drawing.Size(220, 29);
            this.classcode.TabIndex = 57;
            this.classcode.TextChanged += new System.EventHandler(this.classcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(133, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "CLASS CODE :";
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(448, 176);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 43);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 70;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(308, 176);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 40);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 69;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Update_delete_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 454);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classcode);
            this.Controls.Add(this.label1);
            this.Name = "Update_delete_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_delete_Class";
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox update;
    }
}