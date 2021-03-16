namespace MHighSchool
{
    partial class Subjects_Assigned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects_Assigned));
            this.save = new System.Windows.Forms.PictureBox();
            this.classname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.ComboBox();
            this.teacher = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(265, 293);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 40);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 52;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // classname
            // 
            this.classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.FormattingEnabled = true;
            this.classname.Location = new System.Drawing.Point(265, 172);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 26);
            this.classname.TabIndex = 51;
            this.classname.SelectedIndexChanged += new System.EventHandler(this.classname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(181, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "CLASS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(103, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "TEACHER NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(103, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "SUBJECT NAME :";
            // 
            // subname
            // 
            this.subname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.subname.FormattingEnabled = true;
            this.subname.Location = new System.Drawing.Point(265, 230);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(220, 26);
            this.subname.TabIndex = 54;
            // 
            // teacher
            // 
            this.teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.teacher.FormattingEnabled = true;
            this.teacher.Location = new System.Drawing.Point(270, 112);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(220, 26);
            this.teacher.TabIndex = 55;
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 39);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 56;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.code.Location = new System.Drawing.Point(265, 57);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(220, 29);
            this.code.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(181, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "CODE :";
            // 
            // Subjects_Assigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 458);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.back);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.subname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Subjects_Assigned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects_Assigned";
            this.Load += new System.EventHandler(this.Subjects_Assigned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.ComboBox classname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subname;
        private System.Windows.Forms.ComboBox teacher;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label4;
    }
}