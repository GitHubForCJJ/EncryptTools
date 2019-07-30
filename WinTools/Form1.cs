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
    }
}
