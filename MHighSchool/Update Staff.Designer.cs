namespace MHighSchool
{
    partial class Update_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Staff));
            this.back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sgen = new System.Windows.Forms.ComboBox();
            this.saddr = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sfat = new System.Windows.Forms.TextBox();
            this.semail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sphno = new System.Windows.Forms.TextBox();
            this.smot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sjdate = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 39);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 49;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sgen);
            this.panel1.Controls.Add(this.saddr);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sfat);
            this.panel1.Controls.Add(this.semail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sphno);
            this.panel1.Controls.Add(this.smot);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(538, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 380);
            this.panel1.TabIndex = 50;
            // 
            // sgen
            // 
            this.sgen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sgen.FormattingEnabled = true;
            this.sgen.Items.AddRange(new object[] {
            "FEMALE",
            "MALE",
            "OTHER"});
            this.sgen.Location = new System.Drawing.Point(165, 56);
            this.sgen.Name = "sgen";
            this.sgen.Size = new System.Drawing.Size(247, 26);
            this.sgen.TabIndex = 37;
            // 
            // saddr
            // 
            this.saddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.saddr.Location = new System.Drawing.Point(165, 272);
            this.saddr.Name = "saddr";
            this.saddr.Size = new System.Drawing.Size(247, 85);
            this.saddr.TabIndex = 33;
            this.saddr.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "ADDRESS";
            // 
            // sfat
            // 
            this.sfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sfat.Location = new System.Drawing.Point(165, 99);
            this.sfat.Multiline = true;
            this.sfat.Name = "sfat";
            this.sfat.Size = new System.Drawing.Size(247, 22);
            this.sfat.TabIndex = 28;
            // 
            // semail
            // 
            this.semail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.semail.Location = new System.Drawing.Point(165, 230);
            this.semail.Multiline = true;
            this.semail.Name = "semail";
            this.semail.Size = new System.Drawing.Size(247, 22);
            this.semail.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "NAME";
            // 
            // sphno
            // 
            this.sphno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sphno.Location = new System.Drawing.Point(165, 186);
            this.sphno.Multiline = true;
            this.sphno.Name = "sphno";
            this.sphno.Size = new System.Drawing.Size(247, 22);
            this.sphno.TabIndex = 30;
            // 
            // smot
            // 
            this.smot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.smot.Location = new System.Drawing.Point(165, 143);
            this.smot.Multiline = true;
            this.smot.Name = "smot";
            this.smot.Size = new System.Drawing.Size(247, 22);
            this.smot.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "GENDER";
            // 
            // sname
            // 
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sname.Location = new System.Drawing.Point(165, 17);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(247, 22);
            this.sname.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "EMAIL ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "PHONE NO.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "MOTHER\'S NAME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "FATHERS NAME";
            // 
            // sjdate
            // 
            this.sjdate.AutoSize = true;
            this.sjdate.BackColor = System.Drawing.Color.Transparent;
            this.sjdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sjdate.Location = new System.Drawing.Point(271, 85);
            this.sjdate.Name = "sjdate";
            this.sjdate.Size = new System.Drawing.Size(29, 19);
            this.sjdate.TabIndex = 54;
            this.sjdate.Text = "----";
            // 
            // regno
            // 
            this.regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.regno.Location = new System.Drawing.Point(238, 38);
            this.regno.Multiline = true;
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(171, 22);
            this.regno.TabIndex = 53;
            this.regno.TextChanged += new System.EventHandler(this.regno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "STAFF ID";
            // 
            // update
            // 
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.Location = new System.Drawing.Point(536, 429);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 40);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 51;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "JOINING DATE";
            // 
            // qual
            // 
            this.qual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.qual.Location = new System.Drawing.Point(238, 139);
            this.qual.Multiline = true;
            this.qual.Name = "qual";
            this.qual.Size = new System.Drawing.Size(282, 24);
            this.qual.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 57;
            this.label10.Text = "QUALIFICATION";
            // 
            // Update_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 479);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sjdate);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Name = "Update_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sgen;
        private System.Windows.Forms.RichTextBox saddr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sfat;
        private System.Windows.Forms.TextBox semail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sphno;
        private System.Windows.Forms.TextBox smot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sjdate;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qual;
        private System.Windows.Forms.Label label10;
    }
}