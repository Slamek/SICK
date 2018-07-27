namespace thecrimsbeta
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbAssault = new System.Windows.Forms.CheckBox();
            this.cbGang = new System.Windows.Forms.CheckBox();
            this.cbSolo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTickets = new System.Windows.Forms.CheckBox();
            this.tbMinTickets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Akcija!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "usrn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "pwrd";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(143, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(143, 59);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(153, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "samek";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(153, 109);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "bokota";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbAssault
            // 
            this.cbAssault.AutoSize = true;
            this.cbAssault.Location = new System.Drawing.Point(12, 97);
            this.cbAssault.Name = "cbAssault";
            this.cbAssault.Size = new System.Drawing.Size(89, 17);
            this.cbAssault.TabIndex = 7;
            this.cbAssault.Text = "Gang Assault";
            this.cbAssault.UseVisualStyleBackColor = true;
            // 
            // cbGang
            // 
            this.cbGang.AutoSize = true;
            this.cbGang.Location = new System.Drawing.Point(12, 120);
            this.cbGang.Name = "cbGang";
            this.cbGang.Size = new System.Drawing.Size(95, 17);
            this.cbGang.TabIndex = 8;
            this.cbGang.Text = "Gang Robbery";
            this.cbGang.UseVisualStyleBackColor = true;
            // 
            // cbSolo
            // 
            this.cbSolo.AutoSize = true;
            this.cbSolo.Checked = true;
            this.cbSolo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSolo.Location = new System.Drawing.Point(12, 143);
            this.cbSolo.Name = "cbSolo";
            this.cbSolo.Size = new System.Drawing.Size(90, 17);
            this.cbSolo.TabIndex = 9;
            this.cbSolo.Text = "Solo Robbery";
            this.cbSolo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Si polek pri:";
            // 
            // cbTickets
            // 
            this.cbTickets.AutoSize = true;
            this.cbTickets.Location = new System.Drawing.Point(12, 194);
            this.cbTickets.Name = "cbTickets";
            this.cbTickets.Size = new System.Drawing.Size(115, 17);
            this.cbTickets.TabIndex = 11;
            this.cbTickets.Text = "Use Tickets Ce So";
            this.cbTickets.UseVisualStyleBackColor = true;
            // 
            // tbMinTickets
            // 
            this.tbMinTickets.Location = new System.Drawing.Point(12, 211);
            this.tbMinTickets.Name = "tbMinTickets";
            this.tbMinTickets.Size = new System.Drawing.Size(26, 20);
            this.tbMinTickets.TabIndex = 12;
            this.tbMinTickets.Text = "000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jih Pusti";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(153, 132);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "pofukanec";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(153, 164);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMinTickets);
            this.Controls.Add(this.cbTickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSolo);
            this.Controls.Add(this.cbGang);
            this.Controls.Add(this.cbAssault);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbAssault;
        private System.Windows.Forms.CheckBox cbGang;
        private System.Windows.Forms.CheckBox cbSolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTickets;
        private System.Windows.Forms.TextBox tbMinTickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ListView listView1;
    }
}

