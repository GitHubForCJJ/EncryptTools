namespace WinTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DES = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesKeyText = new System.Windows.Forms.TextBox();
            this.DesResultRichText = new System.Windows.Forms.RichTextBox();
            this.DesDecrypt = new System.Windows.Forms.Button();
            this.DesEncrypt = new System.Windows.Forms.Button();
            this.DesInRichText = new System.Windows.Forms.RichTextBox();
            this.MD5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutRichDownText = new System.Windows.Forms.RichTextBox();
            this.MD5encrypt = new System.Windows.Forms.Button();
            this.OutRichUpText = new System.Windows.Forms.RichTextBox();
            this.INRichText = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Base64 = new System.Windows.Forms.TabPage();
            this.Base64Dncrypt = new System.Windows.Forms.Button();
            this.Base64Encrypt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Base64ResRichText = new System.Windows.Forms.RichTextBox();
            this.Base64InRichText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Base64Combobox = new System.Windows.Forms.ComboBox();
            this.SHA1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.SHA1Encrypt = new System.Windows.Forms.Button();
            this.SHA1ResRichText = new System.Windows.Forms.RichTextBox();
            this.SHA1RichText = new System.Windows.Forms.RichTextBox();
            this.JSON = new System.Windows.Forms.TabPage();
            this.JsonInRichText = new System.Windows.Forms.RichTextBox();
            this.JsonResRichText = new System.Windows.Forms.RichTextBox();
            this.JsonFormart = new System.Windows.Forms.Button();
            this.DES.SuspendLayout();
            this.MD5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Base64.SuspendLayout();
            this.SHA1.SuspendLayout();
            this.JSON.SuspendLayout();
            this.SuspendLayout();
            // 
            // DES
            // 
            this.DES.Controls.Add(this.label5);
            this.DES.Controls.Add(this.label4);
            this.DES.Controls.Add(this.label3);
            this.DES.Controls.Add(this.DesKeyText);
            this.DES.Controls.Add(this.DesResultRichText);
            this.DES.Controls.Add(this.DesDecrypt);
            this.DES.Controls.Add(this.DesEncrypt);
            this.DES.Controls.Add(this.DesInRichText);
            this.DES.Location = new System.Drawing.Point(4, 27);
            this.DES.Name = "DES";
            this.DES.Padding = new System.Windows.Forms.Padding(3);
            this.DES.Size = new System.Drawing.Size(992, 627);
            this.DES.TabIndex = 1;
            this.DES.Text = "DES";
            this.DES.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "待处理密文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "结果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "密文key";
            // 
            // DesKeyText
            // 
            this.DesKeyText.Location = new System.Drawing.Point(7, 48);
            this.DesKeyText.Name = "DesKeyText";
            this.DesKeyText.Size = new System.Drawing.Size(395, 27);
            this.DesKeyText.TabIndex = 4;
            // 
            // DesResultRichText
            // 
            this.DesResultRichText.Location = new System.Drawing.Point(517, 18);
            this.DesResultRichText.Name = "DesResultRichText";
            this.DesResultRichText.Size = new System.Drawing.Size(466, 581);
            this.DesResultRichText.TabIndex = 3;
            this.DesResultRichText.Text = "";
            // 
            // DesDecrypt
            // 
            this.DesDecrypt.Location = new System.Drawing.Point(412, 319);
            this.DesDecrypt.Name = "DesDecrypt";
            this.DesDecrypt.Size = new System.Drawing.Size(85, 30);
            this.DesDecrypt.TabIndex = 2;
            this.DesDecrypt.Text = "Des解密";
            this.DesDecrypt.UseVisualStyleBackColor = true;
            this.DesDecrypt.Click += new System.EventHandler(this.DesDecrypt_Click);
            // 
            // DesEncrypt
            // 
            this.DesEncrypt.Location = new System.Drawing.Point(412, 257);
            this.DesEncrypt.Name = "DesEncrypt";
            this.DesEncrypt.Size = new System.Drawing.Size(85, 31);
            this.DesEncrypt.TabIndex = 1;
            this.DesEncrypt.Text = "Des加密";
            this.DesEncrypt.UseVisualStyleBackColor = true;
            this.DesEncrypt.Click += new System.EventHandler(this.DesEncrypt_Click);
            // 
            // DesInRichText
            // 
            this.DesInRichText.Location = new System.Drawing.Point(7, 133);
            this.DesInRichText.Name = "DesInRichText";
            this.DesInRichText.Size = new System.Drawing.Size(395, 466);
            this.DesInRichText.TabIndex = 0;
            this.DesInRichText.Text = "";
            // 
            // MD5
            // 
            this.MD5.Controls.Add(this.label2);
            this.MD5.Controls.Add(this.label1);
            this.MD5.Controls.Add(this.OutRichDownText);
            this.MD5.Controls.Add(this.MD5encrypt);
            this.MD5.Controls.Add(this.OutRichUpText);
            this.MD5.Controls.Add(this.INRichText);
            this.MD5.Location = new System.Drawing.Point(4, 27);
            this.MD5.Name = "MD5";
            this.MD5.Padding = new System.Windows.Forms.Padding(3);
            this.MD5.Size = new System.Drawing.Size(992, 627);
            this.MD5.TabIndex = 0;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "32位小写";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "32位大写";
            // 
            // OutRichDownText
            // 
            this.OutRichDownText.Location = new System.Drawing.Point(539, 335);
            this.OutRichDownText.Name = "OutRichDownText";
            this.OutRichDownText.Size = new System.Drawing.Size(434, 255);
            this.OutRichDownText.TabIndex = 3;
            this.OutRichDownText.Text = "";
            // 
            // MD5encrypt
            // 
            this.MD5encrypt.Location = new System.Drawing.Point(429, 288);
            this.MD5encrypt.Name = "MD5encrypt";
            this.MD5encrypt.Size = new System.Drawing.Size(87, 34);
            this.MD5encrypt.TabIndex = 2;
            this.MD5encrypt.Text = "MD5加密";
            this.MD5encrypt.UseVisualStyleBackColor = true;
            this.MD5encrypt.Click += new System.EventHandler(this.MD5encrypt_Click);
            // 
            // OutRichUpText
            // 
            this.OutRichUpText.Location = new System.Drawing.Point(539, 64);
            this.OutRichUpText.Name = "OutRichUpText";
            this.OutRichUpText.Size = new System.Drawing.Size(434, 229);
            this.OutRichUpText.TabIndex = 1;
            this.OutRichUpText.Text = "";
            // 
            // INRichText
            // 
            this.INRichText.Location = new System.Drawing.Point(7, 43);
            this.INRichText.Name = "INRichText";
            this.INRichText.Size = new System.Drawing.Size(386, 547);
            this.INRichText.TabIndex = 0;
            this.INRichText.Text = "";
            this.INRichText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MD5);
            this.tabControl1.Controls.Add(this.DES);
            this.tabControl1.Controls.Add(this.Base64);
            this.tabControl1.Controls.Add(this.SHA1);
            this.tabControl1.Controls.Add(this.JSON);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 13F);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 658);
            this.tabControl1.TabIndex = 2;
            // 
            // Base64
            // 
            this.Base64.Controls.Add(this.Base64Dncrypt);
            this.Base64.Controls.Add(this.Base64Encrypt);
            this.Base64.Controls.Add(this.label7);
            this.Base64.Controls.Add(this.Base64ResRichText);
            this.Base64.Controls.Add(this.Base64InRichText);
            this.Base64.Controls.Add(this.label6);
            this.Base64.Controls.Add(this.Base64Combobox);
            this.Base64.Location = new System.Drawing.Point(4, 27);
            this.Base64.Name = "Base64";
            this.Base64.Padding = new System.Windows.Forms.Padding(3);
            this.Base64.Size = new System.Drawing.Size(992, 627);
            this.Base64.TabIndex = 2;
            this.Base64.Text = "Base64";
            this.Base64.UseVisualStyleBackColor = true;
            // 
            // Base64Dncrypt
            // 
            this.Base64Dncrypt.Location = new System.Drawing.Point(411, 323);
            this.Base64Dncrypt.Name = "Base64Dncrypt";
            this.Base64Dncrypt.Size = new System.Drawing.Size(110, 31);
            this.Base64Dncrypt.TabIndex = 6;
            this.Base64Dncrypt.Text = "Base64解密";
            this.Base64Dncrypt.UseVisualStyleBackColor = true;
            this.Base64Dncrypt.Click += new System.EventHandler(this.Base64Dncrypt_Click);
            // 
            // Base64Encrypt
            // 
            this.Base64Encrypt.Location = new System.Drawing.Point(411, 263);
            this.Base64Encrypt.Name = "Base64Encrypt";
            this.Base64Encrypt.Size = new System.Drawing.Size(110, 31);
            this.Base64Encrypt.TabIndex = 5;
            this.Base64Encrypt.Text = "Base64加密";
            this.Base64Encrypt.UseVisualStyleBackColor = true;
            this.Base64Encrypt.Click += new System.EventHandler(this.Base64Encrypt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "结果";
            // 
            // Base64ResRichText
            // 
            this.Base64ResRichText.Location = new System.Drawing.Point(543, 18);
            this.Base64ResRichText.Name = "Base64ResRichText";
            this.Base64ResRichText.Size = new System.Drawing.Size(440, 581);
            this.Base64ResRichText.TabIndex = 3;
            this.Base64ResRichText.Text = "";
            // 
            // Base64InRichText
            // 
            this.Base64InRichText.Location = new System.Drawing.Point(10, 80);
            this.Base64InRichText.Name = "Base64InRichText";
            this.Base64InRichText.Size = new System.Drawing.Size(395, 519);
            this.Base64InRichText.TabIndex = 2;
            this.Base64InRichText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "编码方式";
            // 
            // Base64Combobox
            // 
            this.Base64Combobox.AutoCompleteCustomSource.AddRange(new string[] {
            "utf-8"});
            this.Base64Combobox.FormattingEnabled = true;
            this.Base64Combobox.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.Base64Combobox.Location = new System.Drawing.Point(113, 25);
            this.Base64Combobox.Name = "Base64Combobox";
            this.Base64Combobox.Size = new System.Drawing.Size(121, 25);
            this.Base64Combobox.TabIndex = 0;
            // 
            // SHA1
            // 
            this.SHA1.Controls.Add(this.label8);
            this.SHA1.Controls.Add(this.SHA1Encrypt);
            this.SHA1.Controls.Add(this.SHA1ResRichText);
            this.SHA1.Controls.Add(this.SHA1RichText);
            this.SHA1.Location = new System.Drawing.Point(4, 27);
            this.SHA1.Name = "SHA1";
            this.SHA1.Padding = new System.Windows.Forms.Padding(3);
            this.SHA1.Size = new System.Drawing.Size(992, 627);
            this.SHA1.TabIndex = 3;
            this.SHA1.Text = "SHA1";
            this.SHA1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "结果";
            // 
            // SHA1Encrypt
            // 
            this.SHA1Encrypt.Location = new System.Drawing.Point(422, 259);
            this.SHA1Encrypt.Name = "SHA1Encrypt";
            this.SHA1Encrypt.Size = new System.Drawing.Size(102, 34);
            this.SHA1Encrypt.TabIndex = 2;
            this.SHA1Encrypt.Text = "SHA1加密";
            this.SHA1Encrypt.UseVisualStyleBackColor = true;
            this.SHA1Encrypt.Click += new System.EventHandler(this.SHA1Encrypt_Click);
            // 
            // SHA1ResRichText
            // 
            this.SHA1ResRichText.Location = new System.Drawing.Point(566, 41);
            this.SHA1ResRichText.Name = "SHA1ResRichText";
            this.SHA1ResRichText.Size = new System.Drawing.Size(403, 517);
            this.SHA1ResRichText.TabIndex = 1;
            this.SHA1ResRichText.Text = "";
            // 
            // SHA1RichText
            // 
            this.SHA1RichText.Location = new System.Drawing.Point(24, 41);
            this.SHA1RichText.Name = "SHA1RichText";
            this.SHA1RichText.Size = new System.Drawing.Size(363, 517);
            this.SHA1RichText.TabIndex = 0;
            this.SHA1RichText.Text = "";
            // 
            // JSON
            // 
            this.JSON.Controls.Add(this.JsonFormart);
            this.JSON.Controls.Add(this.JsonResRichText);
            this.JSON.Controls.Add(this.JsonInRichText);
            this.JSON.Location = new System.Drawing.Point(4, 27);
            this.JSON.Name = "JSON";
            this.JSON.Padding = new System.Windows.Forms.Padding(3);
            this.JSON.Size = new System.Drawing.Size(992, 627);
            this.JSON.TabIndex = 4;
            this.JSON.Text = "JSON";
            this.JSON.UseVisualStyleBackColor = true;
            // 
            // JsonInRichText
            // 
            this.JsonInRichText.Location = new System.Drawing.Point(18, 145);
            this.JsonInRichText.Name = "JsonInRichText";
            this.JsonInRichText.Size = new System.Drawing.Size(387, 465);
            this.JsonInRichText.TabIndex = 0;
            this.JsonInRichText.Text = "";
            // 
            // JsonResRichText
            // 
            this.JsonResRichText.Location = new System.Drawing.Point(434, 6);
            this.JsonResRichText.Name = "JsonResRichText";
            this.JsonResRichText.Size = new System.Drawing.Size(549, 604);
            this.JsonResRichText.TabIndex = 1;
            this.JsonResRichText.Text = "";
            // 
            // JsonFormart
            // 
            this.JsonFormart.Location = new System.Drawing.Point(306, 63);
            this.JsonFormart.Name = "JsonFormart";
            this.JsonFormart.Size = new System.Drawing.Size(75, 23);
            this.JsonFormart.TabIndex = 2;
            this.JsonFormart.Text = "格式化";
            this.JsonFormart.UseVisualStyleBackColor = true;
            this.JsonFormart.Click += new System.EventHandler(this.JsonFormart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "常用加解密工具";
            this.DES.ResumeLayout(false);
            this.DES.PerformLayout();
            this.MD5.ResumeLayout(false);
            this.MD5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Base64.ResumeLayout(false);
            this.Base64.PerformLayout();
            this.SHA1.ResumeLayout(false);
            this.SHA1.PerformLayout();
            this.JSON.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage DES;
        private System.Windows.Forms.TabPage MD5;
        private System.Windows.Forms.RichTextBox INRichText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button MD5encrypt;
        private System.Windows.Forms.RichTextBox OutRichUpText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OutRichDownText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox DesResultRichText;
        private System.Windows.Forms.Button DesDecrypt;
        private System.Windows.Forms.Button DesEncrypt;
        private System.Windows.Forms.RichTextBox DesInRichText;
        private System.Windows.Forms.TextBox DesKeyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage Base64;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Base64Combobox;
        private System.Windows.Forms.RichTextBox Base64InRichText;
        private System.Windows.Forms.RichTextBox Base64ResRichText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Base64Dncrypt;
        private System.Windows.Forms.Button Base64Encrypt;
        private System.Windows.Forms.TabPage SHA1;
        private System.Windows.Forms.TabPage JSON;
        private System.Windows.Forms.Button SHA1Encrypt;
        private System.Windows.Forms.RichTextBox SHA1ResRichText;
        private System.Windows.Forms.RichTextBox SHA1RichText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button JsonFormart;
        private System.Windows.Forms.RichTextBox JsonResRichText;
        private System.Windows.Forms.RichTextBox JsonInRichText;
    }
}

