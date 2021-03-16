namespace MHighSchool
{
    partial class Fee_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fee_Master));
            this.label5 = new System.Windows.Forms.Label();
            this.feerecord = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payfee = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.feerecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payfee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label5.Location = new System.Drawing.Point(641, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "RECORDS";
            // 
            // feerecord
            // 
            this.feerecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("feerecord.BackgroundImage")));
            this.feerecord.Image = ((System.Drawing.Image)(resources.GetObject("feerecord.Image")));
            this.feerecord.Location = new System.Drawing.Point(607, 91);
            this.feerecord.Name = "feerecord";
            this.feerecord.Size = new System.Drawing.Size(150, 150);
            this.feerecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feerecord.TabIndex = 49;
            this.feerecord.TabStop = false;
            this.feerecord.Click += new System.EventHandler(this.feerecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label1.Location = new System.Drawing.Point(134, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "PAY FEE";
            // 
            // payfee
            // 
            this.payfee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payfee.BackgroundImage")));
            this.payfee.Image = ((System.Drawing.Image)(resources.GetObject("payfee.Image")));
            this.payfee.Location = new System.Drawing.Point(100, 91);
            this.payfee.Name = "payfee";
            this.payfee.Size = new System.Drawing.Size(150, 150);
            this.payfee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.payfee.TabIndex = 51;
            this.payfee.TabStop = false;
            this.payfee.Click += new System.EventHandler(this.payfee_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(1, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 39);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 53;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Fee_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 436);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payfee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feerecord);
            this.Name = "Fee_Master";
            this.Text = "Fee_Master";
            ((System.ComponentModel.ISupportInitialize)(this.feerecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payfee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox feerecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox payfee;
        private System.Windows.Forms.PictureBox back;
    }
}