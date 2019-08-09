namespace WinTools
{
    partial class Addconfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dbip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dbport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Useraccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Userpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dbtype = new System.Windows.Forms.ComboBox();
            this.Dbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Adddbconfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(100, 29);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(195, 22);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库类型";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Dbip
            // 
            this.Dbip.Location = new System.Drawing.Point(100, 104);
            this.Dbip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbip.Name = "Dbip";
            this.Dbip.Size = new System.Drawing.Size(195, 22);
            this.Dbip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbport
            // 
            this.Dbport.Location = new System.Drawing.Point(100, 148);
            this.Dbport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbport.Name = "Dbport";
            this.Dbport.Size = new System.Drawing.Size(195, 22);
            this.Dbport.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "端口号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Useraccount
            // 
            this.Useraccount.Location = new System.Drawing.Point(100, 191);
            this.Useraccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Useraccount.Name = "Useraccount";
            this.Useraccount.Size = new System.Drawing.Size(195, 22);
            this.Useraccount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "账号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Userpassword
            // 
            this.Userpassword.Location = new System.Drawing.Point(100, 239);
            this.Userpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Userpassword.Name = "Userpassword";
            this.Userpassword.Size = new System.Drawing.Size(195, 22);
            this.Userpassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "密码";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Dbtype
            // 
            this.Dbtype.FormattingEnabled = true;
            this.Dbtype.Location = new System.Drawing.Point(100, 67);
            this.Dbtype.Name = "Dbtype";
            this.Dbtype.Size = new System.Drawing.Size(195, 21);
            this.Dbtype.TabIndex = 12;
            // 
            // Dbname
            // 
            this.Dbname.Location = new System.Drawing.Point(100, 279);
            this.Dbname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dbname.Name = "Dbname";
            this.Dbname.Size = new System.Drawing.Size(195, 22);
            this.Dbname.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "数据库";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Adddbconfig
            // 
            this.Adddbconfig.Location = new System.Drawing.Point(20, 329);
            this.Adddbconfig.Name = "Adddbconfig";
            this.Adddbconfig.Size = new System.Drawing.Size(275, 43);
            this.Adddbconfig.TabIndex = 16;
            this.Adddbconfig.Text = "保存";
            this.Adddbconfig.UseVisualStyleBackColor = true;
            // 
            // Addconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 384);
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
            this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Addconfig";
            this.Text = "添加配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dbip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dbport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Useraccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Userpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Dbtype;
        private System.Windows.Forms.TextBox Dbname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Adddbconfig;
    }
}