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
            this.JsonFormart = new System.Windows.Forms.Button();
            this.JsonResRichText = new System.Windows.Forms.RichTextBox();
            this.JsonInRichText = new System.Windows.Forms.RichTextBox();
            this.CreateTable = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.Resultrich = new System.Windows.Forms.RichTextBox();
            this.c = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addconfig = new System.Windows.Forms.Button();
            this.consql = new System.Windows.Forms.Button();
            this.Userpassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Dbtype = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Dbip = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Useraccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Dbport = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DES.SuspendLayout();
            this.MD5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Base64.SuspendLayout();
            this.SHA1.SuspendLayout();
            this.JSON.SuspendLayout();
            this.CreateTable.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.DES.Location = new System.Drawing.Point(4, 26);
            this.DES.Name = "DES";
            this.DES.Padding = new System.Windows.Forms.Padding(3);
            this.DES.Size = new System.Drawing.Size(992, 628);
            this.DES.TabIndex = 1;
            this.DES.Text = "DES";
            this.DES.UseVisualStyleBackColor = true;
            this.DES.Click += new System.EventHandler(this.DES_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "待处理密文";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "结果";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "密文key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DesKeyText
            // 
            this.DesKeyText.Location = new System.Drawing.Point(7, 48);
            this.DesKeyText.Name = "DesKeyText";
            this.DesKeyText.Size = new System.Drawing.Size(395, 23);
            this.DesKeyText.TabIndex = 4;
            this.DesKeyText.TextChanged += new System.EventHandler(this.DesKeyText_TextChanged);
            // 
            // DesResultRichText
            // 
            this.DesResultRichText.Location = new System.Drawing.Point(517, 18);
            this.DesResultRichText.Name = "DesResultRichText";
            this.DesResultRichText.Size = new System.Drawing.Size(466, 581);
            this.DesResultRichText.TabIndex = 3;
            this.DesResultRichText.Text = "";
            this.DesResultRichText.TextChanged += new System.EventHandler(this.DesResultRichText_TextChanged);
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
            this.DesInRichText.TextChanged += new System.EventHandler(this.DesInRichText_TextChanged);
            // 
            // MD5
            // 
            this.MD5.Controls.Add(this.label2);
            this.MD5.Controls.Add(this.label1);
            this.MD5.Controls.Add(this.OutRichDownText);
            this.MD5.Controls.Add(this.MD5encrypt);
            this.MD5.Controls.Add(this.OutRichUpText);
            this.MD5.Controls.Add(this.INRichText);
            this.MD5.Location = new System.Drawing.Point(4, 26);
            this.MD5.Name = "MD5";
            this.MD5.Padding = new System.Windows.Forms.Padding(3);
            this.MD5.Size = new System.Drawing.Size(992, 628);
            this.MD5.TabIndex = 0;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            this.MD5.Click += new System.EventHandler(this.MD5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "32位小写";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "32位大写";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutRichDownText
            // 
            this.OutRichDownText.Location = new System.Drawing.Point(539, 335);
            this.OutRichDownText.Name = "OutRichDownText";
            this.OutRichDownText.Size = new System.Drawing.Size(434, 255);
            this.OutRichDownText.TabIndex = 3;
            this.OutRichDownText.Text = "";
            this.OutRichDownText.TextChanged += new System.EventHandler(this.OutRichDownText_TextChanged);
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
            this.OutRichUpText.TextChanged += new System.EventHandler(this.OutRichUpText_TextChanged);
            // 
            // INRichText
            // 
            this.INRichText.Location = new System.Drawing.Point(7, 43);
            this.INRichText.Name = "INRichText";
            this.INRichText.Size = new System.Drawing.Size(386, 547);
            this.INRichText.TabIndex = 0;
            this.INRichText.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.MD5);
            this.tabControl1.Controls.Add(this.DES);
            this.tabControl1.Controls.Add(this.Base64);
            this.tabControl1.Controls.Add(this.SHA1);
            this.tabControl1.Controls.Add(this.JSON);
            this.tabControl1.Controls.Add(this.CreateTable);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 658);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.Base64.Location = new System.Drawing.Point(4, 26);
            this.Base64.Name = "Base64";
            this.Base64.Padding = new System.Windows.Forms.Padding(3);
            this.Base64.Size = new System.Drawing.Size(992, 628);
            this.Base64.TabIndex = 2;
            this.Base64.Text = "Base64";
            this.Base64.UseVisualStyleBackColor = true;
            this.Base64.Click += new System.EventHandler(this.Base64_Click);
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
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "结果";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Base64ResRichText
            // 
            this.Base64ResRichText.Location = new System.Drawing.Point(543, 18);
            this.Base64ResRichText.Name = "Base64ResRichText";
            this.Base64ResRichText.Size = new System.Drawing.Size(440, 581);
            this.Base64ResRichText.TabIndex = 3;
            this.Base64ResRichText.Text = "";
            this.Base64ResRichText.TextChanged += new System.EventHandler(this.Base64ResRichText_TextChanged);
            // 
            // Base64InRichText
            // 
            this.Base64InRichText.Location = new System.Drawing.Point(10, 80);
            this.Base64InRichText.Name = "Base64InRichText";
            this.Base64InRichText.Size = new System.Drawing.Size(395, 519);
            this.Base64InRichText.TabIndex = 2;
            this.Base64InRichText.Text = "";
            this.Base64InRichText.TextChanged += new System.EventHandler(this.Base64InRichText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "编码方式";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.Base64Combobox.SelectedIndexChanged += new System.EventHandler(this.Base64Combobox_SelectedIndexChanged);
            // 
            // SHA1
            // 
            this.SHA1.Controls.Add(this.label8);
            this.SHA1.Controls.Add(this.SHA1Encrypt);
            this.SHA1.Controls.Add(this.SHA1ResRichText);
            this.SHA1.Controls.Add(this.SHA1RichText);
            this.SHA1.Location = new System.Drawing.Point(4, 26);
            this.SHA1.Name = "SHA1";
            this.SHA1.Padding = new System.Windows.Forms.Padding(3);
            this.SHA1.Size = new System.Drawing.Size(992, 628);
            this.SHA1.TabIndex = 3;
            this.SHA1.Text = "SHA1";
            this.SHA1.UseVisualStyleBackColor = true;
            this.SHA1.Click += new System.EventHandler(this.SHA1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "结果";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.SHA1ResRichText.TextChanged += new System.EventHandler(this.SHA1ResRichText_TextChanged);
            // 
            // SHA1RichText
            // 
            this.SHA1RichText.Location = new System.Drawing.Point(24, 41);
            this.SHA1RichText.Name = "SHA1RichText";
            this.SHA1RichText.Size = new System.Drawing.Size(363, 517);
            this.SHA1RichText.TabIndex = 0;
            this.SHA1RichText.Text = "";
            this.SHA1RichText.TextChanged += new System.EventHandler(this.SHA1RichText_TextChanged);
            // 
            // JSON
            // 
            this.JSON.Controls.Add(this.JsonFormart);
            this.JSON.Controls.Add(this.JsonResRichText);
            this.JSON.Controls.Add(this.JsonInRichText);
            this.JSON.Location = new System.Drawing.Point(4, 26);
            this.JSON.Name = "JSON";
            this.JSON.Padding = new System.Windows.Forms.Padding(3);
            this.JSON.Size = new System.Drawing.Size(992, 628);
            this.JSON.TabIndex = 4;
            this.JSON.Text = "JSON";
            this.JSON.UseVisualStyleBackColor = true;
            this.JSON.Click += new System.EventHandler(this.JSON_Click);
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
            // JsonResRichText
            // 
            this.JsonResRichText.Location = new System.Drawing.Point(434, 6);
            this.JsonResRichText.Name = "JsonResRichText";
            this.JsonResRichText.Size = new System.Drawing.Size(549, 604);
            this.JsonResRichText.TabIndex = 1;
            this.JsonResRichText.Text = "";
            this.JsonResRichText.TextChanged += new System.EventHandler(this.JsonResRichText_TextChanged);
            // 
            // JsonInRichText
            // 
            this.JsonInRichText.Location = new System.Drawing.Point(18, 145);
            this.JsonInRichText.Name = "JsonInRichText";
            this.JsonInRichText.Size = new System.Drawing.Size(387, 465);
            this.JsonInRichText.TabIndex = 0;
            this.JsonInRichText.Text = "";
            this.JsonInRichText.TextChanged += new System.EventHandler(this.JsonInRichText_TextChanged);
            // 
            // CreateTable
            // 
            this.CreateTable.Controls.Add(this.tabControl2);
            this.CreateTable.Controls.Add(this.addconfig);
            this.CreateTable.Controls.Add(this.consql);
            this.CreateTable.Controls.Add(this.Userpassword);
            this.CreateTable.Controls.Add(this.label14);
            this.CreateTable.Controls.Add(this.Dbtype);
            this.CreateTable.Controls.Add(this.label13);
            this.CreateTable.Controls.Add(this.Dbip);
            this.CreateTable.Controls.Add(this.label12);
            this.CreateTable.Controls.Add(this.Useraccount);
            this.CreateTable.Controls.Add(this.label11);
            this.CreateTable.Controls.Add(this.Dbport);
            this.CreateTable.Controls.Add(this.label10);
            this.CreateTable.Controls.Add(this.Name);
            this.CreateTable.Controls.Add(this.label9);
            this.CreateTable.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreateTable.Location = new System.Drawing.Point(4, 26);
            this.CreateTable.Name = "CreateTable";
            this.CreateTable.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTable.Size = new System.Drawing.Size(992, 628);
            this.CreateTable.TabIndex = 5;
            this.CreateTable.Text = "建表";
            this.CreateTable.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(15, 69);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(949, 553);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Resultrich);
            this.tabPage1.Controls.Add(this.c);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "方式一单表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(17, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 29);
            this.label15.TabIndex = 15;
            this.label15.Text = "结果";
            // 
            // Resultrich
            // 
            this.Resultrich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultrich.Location = new System.Drawing.Point(94, 418);
            this.Resultrich.Name = "Resultrich";
            this.Resultrich.Size = new System.Drawing.Size(841, 96);
            this.Resultrich.TabIndex = 1;
            this.Resultrich.Text = "";
            // 
            // c
            // 
            this.c.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c.Location = new System.Drawing.Point(6, 6);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(929, 394);
            this.c.TabIndex = 0;
            this.c.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "方式二导入excel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // addconfig
            // 
            this.addconfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addconfig.Location = new System.Drawing.Point(157, 21);
            this.addconfig.Name = "addconfig";
            this.addconfig.Size = new System.Drawing.Size(33, 28);
            this.addconfig.TabIndex = 13;
            this.addconfig.Text = "+";
            this.addconfig.UseVisualStyleBackColor = true;
            this.addconfig.Click += new System.EventHandler(this.addconfig_Click);
            // 
            // consql
            // 
            this.consql.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.consql.Location = new System.Drawing.Point(896, 23);
            this.consql.Name = "consql";
            this.consql.Size = new System.Drawing.Size(87, 27);
            this.consql.TabIndex = 12;
            this.consql.Text = "连接数据库";
            this.consql.UseVisualStyleBackColor = true;
            this.consql.Click += new System.EventHandler(this.consql_Click);
            // 
            // Userpassword
            // 
            this.Userpassword.Location = new System.Drawing.Point(797, 23);
            this.Userpassword.Name = "Userpassword";
            this.Userpassword.Size = new System.Drawing.Size(84, 25);
            this.Userpassword.TabIndex = 11;
            this.Userpassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F);
            this.label14.Location = new System.Drawing.Point(756, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "密码";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Dbtype
            // 
            this.Dbtype.FormattingEnabled = true;
            this.Dbtype.Items.AddRange(new object[] {
            "Mysql",
            "SqlServer"});
            this.Dbtype.Location = new System.Drawing.Point(236, 22);
            this.Dbtype.Name = "Dbtype";
            this.Dbtype.Size = new System.Drawing.Size(87, 27);
            this.Dbtype.TabIndex = 9;
            this.Dbtype.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F);
            this.label13.Location = new System.Drawing.Point(192, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "数据库";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Dbip
            // 
            this.Dbip.Location = new System.Drawing.Point(369, 22);
            this.Dbip.Name = "Dbip";
            this.Dbip.Size = new System.Drawing.Size(120, 25);
            this.Dbip.TabIndex = 7;
            this.Dbip.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F);
            this.label12.Location = new System.Drawing.Point(334, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "地址";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Useraccount
            // 
            this.Useraccount.Location = new System.Drawing.Point(654, 23);
            this.Useraccount.Name = "Useraccount";
            this.Useraccount.Size = new System.Drawing.Size(96, 25);
            this.Useraccount.TabIndex = 5;
            this.Useraccount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F);
            this.label11.Location = new System.Drawing.Point(613, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "账号";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Dbport
            // 
            this.Dbport.Location = new System.Drawing.Point(533, 23);
            this.Dbport.Name = "Dbport";
            this.Dbport.Size = new System.Drawing.Size(63, 25);
            this.Dbport.TabIndex = 3;
            this.Dbport.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F);
            this.label10.Location = new System.Drawing.Point(498, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "端口";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Name
            // 
            this.Name.FormattingEnabled = true;
            this.Name.Location = new System.Drawing.Point(48, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(103, 27);
            this.Name.TabIndex = 1;
            this.Name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F);
            this.label9.Location = new System.Drawing.Point(13, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "配置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.tabControl1);
            this.Text = "常用开发工具";
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
            this.CreateTable.ResumeLayout(false);
            this.CreateTable.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage CreateTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Name;
        private System.Windows.Forms.TextBox Dbport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Useraccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Dbtype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Dbip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Userpassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button consql;
        private System.Windows.Forms.Button addconfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox Resultrich;
        private System.Windows.Forms.RichTextBox c;
    }
}

