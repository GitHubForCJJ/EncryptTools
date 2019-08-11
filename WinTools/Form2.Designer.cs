namespace WinTools
{
    partial class Form2
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
            this.Adddbconfig = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Dbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dbtype = new System.Windows.Forms.ComboBox();
            this.Userpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Useraccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dbport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dbip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adddbconfig
            // 
            this.Adddbconfig.Location = new System.Drawing.Point(27, 326);
            this.Adddbconfig.Name = "Adddbconfig";
            this.Adddbconfig.Size = new System.Drawing.Size(275, 43);
            this.Adddbconfig.TabIndex = 32;
            this.Adddbconfig.Text = "保存";
            this.Adddbconfig.UseVisualStyleBackColor = true;
            this.Adddbconfig.Click += new System.EventHandler(this.Adddbconfig_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "数据库";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbname
            // 
            this.Dbname.Location = new System.Drawing.Point(107, 276);
            this.Dbname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbname.Name = "Dbname";
            this.Dbname.Size = new System.Drawing.Size(195, 21);
            this.Dbname.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 29;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbtype
            // 
            this.Dbtype.FormattingEnabled = true;
            this.Dbtype.Items.AddRange(new object[] {
            "Mysql",
            "SqlServer"});
            this.Dbtype.Location = new System.Drawing.Point(107, 64);
            this.Dbtype.Name = "Dbtype";
            this.Dbtype.Size = new System.Drawing.Size(195, 20);
            this.Dbtype.TabIndex = 28;
            // 
            // Userpassword
            // 
            this.Userpassword.Location = new System.Drawing.Point(107, 236);
            this.Userpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Userpassword.Name = "Userpassword";
            this.Userpassword.Size = new System.Drawing.Size(195, 21);
            this.Userpassword.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "密码";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Useraccount
            // 
            this.Useraccount.Location = new System.Drawing.Point(107, 188);
            this.Useraccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Useraccount.Name = "Useraccount";
            this.Useraccount.Size = new System.Drawing.Size(195, 21);
            this.Useraccount.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "账号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbport
            // 
            this.Dbport.Location = new System.Drawing.Point(107, 145);
            this.Dbport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbport.Name = "Dbport";
            this.Dbport.Size = new System.Drawing.Size(195, 21);
            this.Dbport.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "端口号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbip
            // 
            this.Dbip.Location = new System.Drawing.Point(107, 101);
            this.Dbip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbip.Name = "Dbip";
            this.Dbip.Size = new System.Drawing.Size(195, 21);
            this.Dbip.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "IP地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "数据库类型";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(107, 26);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(195, 21);
            this.Name.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "配置名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 382);
            this.Controls.Add(this.Adddbconfig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dbname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dbtype);
            this.Controls.Add(this.Userpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Useraccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dbport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dbip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);

            this.Text = "Adddb";
            this.Load += new System.EventHandler(this.Adddb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adddbconfig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Dbname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Dbtype;
        private System.Windows.Forms.TextBox Userpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Useraccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Dbport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dbip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
    }
}