namespace MHighSchool
{
    partial class Add_FeeTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_FeeTypes));
            this.classname = new System.Windows.Forms.ComboBox();
            this.feename = new System.Windows.Forms.TextBox();
            this.feeid = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.famt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // classname
            // 
            this.classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.FormattingEnabled = true;
            this.classname.Location = new System.Drawing.Point(335, 239);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 26);
            this.classname.TabIndex = 49;
            // 
            // feename
            // 
            this.feename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.feename.Location = new System.Drawing.Point(335, 115);
            this.feename.Multiline = true;
            this.feename.Name = "feename";
            this.feename.Size = new System.Drawing.Size(220, 29);
            this.feename.TabIndex = 48;
            // 
            // feeid
            // 
            this.feeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.feeid.Location = new System.Drawing.Point(335, 53);
            this.feeid.Multiline = true;
            this.feeid.Name = "feeid";
            this.feeid.Size = new System.Drawing.Size(220, 29);
            this.feeid.TabIndex = 47;
            this.feeid.TextChanged += new System.EventHandler(this.feeid_TextChanged);
            // 
            // save
            // 
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Location = new System.Drawing.Point(335, 300);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(101, 40);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 53;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(237, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "CLASS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(203, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "FEE NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(203, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "FEE  CODE :";
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(3, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(53, 51);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 54;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(194, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "FEE AMOUNT:";
            // 
            // famt
            // 
            this.famt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.famt.Location = new System.Drawing.Point(335, 172);
            this.famt.Multiline = true;
            this.famt.Name = "famt";
            this.famt.Size = new System.Drawing.Size(220, 29);
            this.famt.TabIndex = 55;
            // 
            // Add_FeeTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.famt);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.feename);
            this.Controls.Add(this.feeid);
            this.Name = "Add_FeeTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_FeeTypes";
            this.Load += new System.EventHandler(this.Add_FeeTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classname;
        private System.Windows.Forms.TextBox feename;
        private System.Windows.Forms.TextBox feeid;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox famt;
    }
}