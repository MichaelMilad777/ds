namespace DS
{
    partial class DS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deketecustbtn = new System.Windows.Forms.Button();
            this.addorderbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.editcustbtn = new System.Windows.Forms.Button();
            this.savecustbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.deketecustbtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.addorderbtn);
            this.panel1.Controls.Add(this.clearbtn);
            this.panel1.Controls.Add(this.editcustbtn);
            this.panel1.Controls.Add(this.savecustbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 710);
            this.panel1.TabIndex = 12;
            // 
            // deketecustbtn
            // 
            this.deketecustbtn.BackColor = System.Drawing.Color.Red;
            this.deketecustbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deketecustbtn.FlatAppearance.BorderSize = 0;
            this.deketecustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deketecustbtn.Location = new System.Drawing.Point(0, 307);
            this.deketecustbtn.Name = "deketecustbtn";
            this.deketecustbtn.Size = new System.Drawing.Size(172, 37);
            this.deketecustbtn.TabIndex = 25;
            this.deketecustbtn.Text = "حذف";
            this.deketecustbtn.UseVisualStyleBackColor = false;
            this.deketecustbtn.Click += new System.EventHandler(this.deketecustbtn_Click_1);
            // 
            // addorderbtn
            // 
            this.addorderbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addorderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addorderbtn.FlatAppearance.BorderSize = 0;
            this.addorderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addorderbtn.Location = new System.Drawing.Point(0, 160);
            this.addorderbtn.Name = "addorderbtn";
            this.addorderbtn.Size = new System.Drawing.Size(172, 37);
            this.addorderbtn.TabIndex = 26;
            this.addorderbtn.Text = "اضافة اوردر";
            this.addorderbtn.UseVisualStyleBackColor = false;
            this.addorderbtn.Click += new System.EventHandler(this.addorderbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Coral;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.FlatAppearance.BorderSize = 0;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Location = new System.Drawing.Point(0, 270);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(172, 37);
            this.clearbtn.TabIndex = 24;
            this.clearbtn.Text = "مسح";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // editcustbtn
            // 
            this.editcustbtn.BackColor = System.Drawing.Color.Gold;
            this.editcustbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editcustbtn.FlatAppearance.BorderSize = 0;
            this.editcustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editcustbtn.Location = new System.Drawing.Point(0, 233);
            this.editcustbtn.Name = "editcustbtn";
            this.editcustbtn.Size = new System.Drawing.Size(172, 37);
            this.editcustbtn.TabIndex = 23;
            this.editcustbtn.Text = "تعديل";
            this.editcustbtn.UseVisualStyleBackColor = false;
            this.editcustbtn.Click += new System.EventHandler(this.editcustbtn_Click);
            // 
            // savecustbtn
            // 
            this.savecustbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.savecustbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savecustbtn.FlatAppearance.BorderSize = 0;
            this.savecustbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savecustbtn.Location = new System.Drawing.Point(0, 197);
            this.savecustbtn.Name = "savecustbtn";
            this.savecustbtn.Size = new System.Drawing.Size(172, 37);
            this.savecustbtn.TabIndex = 22;
            this.savecustbtn.Text = "حفظ";
            this.savecustbtn.UseVisualStyleBackColor = false;
            this.savecustbtn.Click += new System.EventHandler(this.savecustbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DS.Properties.Resources.لوجو_وسط;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 710);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DS_FormClosed);
            this.Load += new System.EventHandler(this.DS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deketecustbtn;
        private System.Windows.Forms.Button addorderbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button editcustbtn;
        private System.Windows.Forms.Button savecustbtn;
    }
}

