namespace MHighSchool
{
    partial class Pay_Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_Fees));
            this.back = new System.Windows.Forms.PictureBox();
            this.savesub = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.feetypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.Label();
            this.classname = new System.Windows.Forms.TextBox();
            this.disp = new System.Windows.Forms.DataGridView();
            this.feetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.Label();
            this.allfeetypes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.payid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paydate = new System.Windows.Forms.DateTimePicker();
            this.dis = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savesub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).BeginInit();
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
            this.back.TabIndex = 41;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // savesub
            // 
            this.savesub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savesub.BackgroundImage")));
            this.savesub.Image = ((System.Drawing.Image)(resources.GetObject("savesub.Image")));
            this.savesub.Location = new System.Drawing.Point(697, 388);
            this.savesub.Name = "savesub";
            this.savesub.Size = new System.Drawing.Size(101, 40);
            this.savesub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.savesub.TabIndex = 55;
            this.savesub.TabStop = false;
            this.savesub.Click += new System.EventHandler(this.savesub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(138, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "CLASS :";
            // 
            // sname
            // 
            this.sname.Enabled = false;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.sname.Location = new System.Drawing.Point(235, 166);
            this.sname.Multiline = true;
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(220, 29);
            this.sname.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label2.Location = new System.Drawing.Point(50, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "STUDENT NAME :";
            // 
            // regno
            // 
            this.regno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.regno.Location = new System.Drawing.Point(235, 117);
            this.regno.Multiline = true;
            this.regno.Name = "regno";
            this.regno.Size = new System.Drawing.Size(220, 29);
            this.regno.TabIndex = 50;
            this.regno.TextChanged += new System.EventHandler(this.regno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(50, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "STUDENT REGNO. :";
            // 
            // feetypes
            // 
            this.feetypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.feetypes.FormattingEnabled = true;
            this.feetypes.Location = new System.Drawing.Point(235, 265);
            this.feetypes.Name = "feetypes";
            this.feetypes.Size = new System.Drawing.Size(220, 26);
            this.feetypes.TabIndex = 57;
            this.feetypes.SelectedIndexChanged += new System.EventHandler(this.feetypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(102, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "FEE TYPES :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label5.Location = new System.Drawing.Point(76, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "FEE AMOUNT :";
            // 
            // amt
            // 
            this.amt.AutoSize = true;
            this.amt.BackColor = System.Drawing.Color.Transparent;
            this.amt.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.amt.Location = new System.Drawing.Point(231, 358);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(35, 24);
            this.amt.TabIndex = 59;
            this.amt.Text = ":::::";
            // 
            // classname
            // 
            this.classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.classname.Location = new System.Drawing.Point(235, 215);
            this.classname.Multiline = true;
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(220, 29);
            this.classname.TabIndex = 60;
            // 
            // disp
            // 
            this.disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feetype,
            this.feeamount,
            this.total});
            this.disp.Location = new System.Drawing.Point(710, 117);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(317, 174);
            this.disp.TabIndex = 61;
            // 
            // feetype
            // 
            this.feetype.HeaderText = "Fee Type";
            this.feetype.Name = "feetype";
            this.feetype.ReadOnly = true;
            // 
            // feeamount
            // 
            this.feeamount.HeaderText = "Fee Amount";
            this.feeamount.Name = "feeamount";
            this.feeamount.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(710, 313);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 63;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(804, 312);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 64;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(901, 313);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 65;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label6.Location = new System.Drawing.Point(54, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "TOTAL AMOUNT :";
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.BackColor = System.Drawing.Color.Transparent;
            this.txttotal.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.txttotal.Location = new System.Drawing.Point(219, 412);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(35, 24);
            this.txttotal.TabIndex = 67;
            this.txttotal.Text = ":::::";
            // 
            // allfeetypes
            // 
            this.allfeetypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.allfeetypes.Location = new System.Drawing.Point(482, 116);
            this.allfeetypes.Name = "allfeetypes";
            this.allfeetypes.Size = new System.Drawing.Size(222, 172);
            this.allfeetypes.TabIndex = 68;
            this.allfeetypes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 69;
            this.label7.Text = "FEE DETAILS :";
            // 
            // payid
            // 
            this.payid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.payid.Location = new System.Drawing.Point(235, 54);
            this.payid.Multiline = true;
            this.payid.Name = "payid";
            this.payid.Size = new System.Drawing.Size(220, 29);
            this.payid.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label8.Location = new System.Drawing.Point(61, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "PAYMENT ID. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(713, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "DATE:";
            // 
            // paydate
            // 
            this.paydate.CustomFormat = "dd/MM/yyyy";
            this.paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.paydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paydate.Location = new System.Drawing.Point(789, 52);
            this.paydate.Name = "paydate";
            this.paydate.Size = new System.Drawing.Size(200, 24);
            this.paydate.TabIndex = 73;
            // 
            // dis
            // 
            this.dis.AutoSize = true;
            this.dis.BackColor = System.Drawing.Color.Transparent;
            this.dis.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.dis.Location = new System.Drawing.Point(231, 313);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(35, 24);
            this.dis.TabIndex = 75;
            this.dis.Text = ":::::";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label11.Location = new System.Drawing.Point(138, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 74;
            this.label11.Text = "CLASS :";
            // 
            // Pay_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 476);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.paydate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.payid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.allfeetypes);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.disp);
            this.Controls.Add(this.classname);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feetypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.savesub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Pay_Fees";
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.Pay_Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savesub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox savesub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox feetypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amt;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.DataGridView disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn feetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.RichTextBox allfeetypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox payid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker paydate;
        private System.Windows.Forms.Label dis;
        private System.Windows.Forms.Label label11;
    }
}