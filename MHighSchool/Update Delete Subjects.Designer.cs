namespace MHighSchool
{
    partial class Update_Delete_Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Delete_Subjects));
            this.label4 = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.ComboBox();
            this.classname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pclass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(105, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "ASSIGNED TEACHER :";
            // 
            // teachername
            // 
            this.teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.teachername.FormattingEnabled = true;
            this.teachername.Location = new System.Drawing.Point(317, 329);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(220, 26);
            this.teachername.TabIndex = 57;
            // 
            // classname
            // 
            this.classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.FormattingEnabled = true;
            this.classname.Location = new System.Drawing.Point(317, 273);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 26);
            this.classname.TabIndex = 56;
            this.classname.SelectedIndexChanged += new System.EventHandler(this.classname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(223, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "CLASS :";
            // 
            // subname
            // 
            this.subname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subname.Location = new System.Drawing.Point(317, 152);
            this.subname.Multiline = true;
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(220, 29);
            this.subname.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(145, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "SUBJECT NAME :";
            // 
            // subcode
            // 
            this.subcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subcode.Location = new System.Drawing.Point(317, 90);
            this.subcode.Multiline = true;
            this.subcode.Name = "subcode";
            this.subcode.Size = new System.Drawing.Size(220, 29);
            this.subcode.TabIndex = 52;
            this.subcode.TextChanged += new System.EventHandler(this.subcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(145, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "SUBJECT CODE :";
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(317, 400);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 40);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 59;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(452, 400);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 43);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 60;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label5.Location = new System.Drawing.Point(223, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "CLASS :";
            // 
            // pclass
            // 
            this.pclass.Enabled = false;
            this.pclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pclass.Location = new System.Drawing.Point(317, 212);
            this.pclass.Multiline = true;
            this.pclass.Name = "pclass";
            this.pclass.Size = new System.Drawing.Size(220, 29);
            this.pclass.TabIndex = 62;
            // 
            // Update_Delete_Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 492);
            this.Controls.Add(this.pclass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subcode);
            this.Controls.Add(this.label1);
            this.Name = "Update_Delete_Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Delete_Subjects";
            this.Load += new System.EventHandler(this.Update_Delete_Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox teachername;
        private System.Windows.Forms.ComboBox classname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pclass;
    }
}