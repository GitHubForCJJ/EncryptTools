using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Base64Combobox.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MD5encrypt_Click(object sender, EventArgs e)
        {
            string intext = INRichText.Text;
            string outtext32up = Md5.Encrypt32(intext);
            string outtext32down = outtext32up?.ToLower();
            OutRichUpText.Text = outtext32up;
            OutRichDownText.Text = outtext32down;
        }

        private void DesEncrypt_Click(object sender, EventArgs e)
        {
            string intext = DesInRichText.Text;
            string key = DesKeyText.Text;
            try
            {
                string res = Des.Encrypt(intext, key);
                DesResultRichText.Text = res;
            }
            catch(Exception ex)
            {
                DesResultRichText.Text = ex.Message;
            }

        }

        private void DesDecrypt_Click(object sender, EventArgs e)
        {
            string intext = DesInRichText.Text;
            string key = DesKeyText.Text;
            try
            {
                string res = Des.Decrypt(intext, key);
                DesResultRichText.Text = res;
            }
            catch(Exception ex)
            {
                DesResultRichText.Text = ex.Message;
            }
        }

        private void SHA1Encrypt_Click(object sender, EventArgs e)
        {
            string intext = SHA1ResRichText.Text;
            string res = WinTools.SHA1.Encrypt(intext);
            SHA1ResRichText.Text = res;
        }

        private void Base64Encrypt_Click(object sender, EventArgs e)
        {
            string intext = Base64InRichText.Text;
            string codetype = Base64Combobox.Text ?? "utf-8";
            string res = WinTools.Base64.EncodeBase64(intext, codetype);
            Base64ResRichText.Text = res;
        }

        private void Base64Dncrypt_Click(object sender, EventArgs e)
        {
            string intext = Base64InRichText.Text;
            string codetype = Base64Combobox.Text ?? "utf-8";
            string res = WinTools.Base64.DecodeBase64(intext, codetype);
            Base64ResRichText.Text = res;
        }

        private void JsonFormart_Click(object sender, EventArgs e)
        {
            string intext = JsonInRichText.Text;
            string res = WinTools.JsonFormart.JsonTree(intext);
            JsonResRichText.Text = res;
        }



        private void DES_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DesKeyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesResultRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesInRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void MD5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OutRichDownText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutRichUpText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Base64_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Base64ResRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Base64InRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Base64Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SHA1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SHA1ResRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHA1RichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void JSON_Click(object sender, EventArgs e)
        {

        }

        private void JsonResRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void JsonInRichText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addconfig_Click(object sender, EventArgs e)
        {

        }
    }
}
