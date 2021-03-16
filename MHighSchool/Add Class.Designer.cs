namespace MHighSchool
{
    partial class Add_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Class));
            this.saveclass = new System.Windows.Forms.PictureBox();
            this.classname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.saveclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // saveclass
            // 
            this.saveclass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveclass.BackgroundImage")));
            this.saveclass.Image = ((System.Drawing.Image)(resources.GetObject("saveclass.Image")));
            this.saveclass.Location = new System.Drawing.Point(328, 186);
            this.saveclass.Name = "saveclass";
            this.saveclass.Size = new System.Drawing.Size(101, 40);
            this.saveclass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveclass.TabIndex = 56;
            this.saveclass.TabStop = false;
            this.saveclass.Click += new System.EventHandler(this.saveclass_Click);
            // 
            // classname
            // 
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.Location = new System.Drawing.Point(328, 128);
            this.classname.Multiline = true;
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 29);
            this.classname.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(153, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "CLASS NAME :";
            // 
            // classcode
            // 
            this.classcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classcode.Location = new System.Drawing.Point(328, 66);
            this.classcode.Multiline = true;
            this.classcode.Name = "classcode";
            this.classcode.Size = new System.Drawing.Size(220, 29);
            this.classcode.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(153, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "CLASS CODE :";
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(0, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 39);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 57;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 435);
            this.Controls.Add(this.back);
            this.Controls.Add(this.saveclass);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classcode);
            this.Controls.Add(this.label1);
            this.Name = "Add_Class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Class";
            this.Load += new System.EventHandler(this.Add_Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saveclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox saveclass;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox classcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back;
    }
}