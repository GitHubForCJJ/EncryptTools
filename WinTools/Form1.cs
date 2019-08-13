using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using WinTools.Comon;
using ExcelHelper;
using FastDev.Common.Code;

namespace WinTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Base64Combobox.SelectedIndex = 0;

            //读取文件中的配置项
            var filename = AppDomain.CurrentDomain.BaseDirectory + "datebaseconfig.txt";
            if (File.Exists(filename))
            {
                var text = File.ReadAllText(filename);
                var list = new List<Datebasemodel>();
                if (text.Length > 0)
                {
                    try
                    {
                        list = JsonConvert.DeserializeObject<List<Datebasemodel>>(text);
                    }
                    catch { }
                    if (list.Count() > 0)
                    {
                        var arr = list.OrderByDescending(x => x.Addtime);
                        this.Name.Items.AddRange(arr.Select(x => x.Name).ToArray());

                        var choose = arr.First();

                        this.Dbtype.SelectedIndex = this.Dbtype.Items.IndexOf(choose.Dbtype.ToString());
                        this.Dbip.Text = choose.Dbip;
                        this.Dbport.Text = choose.Dbport;
                        this.Useraccount.Text = choose.Useraccount;
                        this.Userpassword.Text = choose.Userpassword;
                        this.Dbname.Text = choose.Dbname;
                        this.Name.SelectedIndex = this.Name.Items.IndexOf(choose.Name);
                    }
                }
            }

            this.Isdrop.Checked = true;
            this.isdrop2.Checked = true;
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            var name = ((ComboBox)sender).Text;
            var configfilename = AppDomain.CurrentDomain.BaseDirectory + "datebaseconfig.txt";
            if (File.Exists(configfilename))
            {
                var text = File.ReadAllText(configfilename);
                var list = new List<Datebasemodel>();
                if (text.Length > 0)
                {
                    try
                    {
                        list = JsonConvert.DeserializeObject<List<Datebasemodel>>(text);
                    }
                    catch { }

                }
                if (list.Count > 0 && !string.IsNullOrEmpty(name))
                {
                    var model = list.FirstOrDefault(x => x.Name == name);
                    this.Dbip.Text = model?.Dbip;
                    this.Dbport.Text = model?.Dbport;
                    this.Dbtype.SelectedIndex = this.Dbtype.Items.IndexOf(model.Dbtype);
                    this.Useraccount.Text = model?.Useraccount;
                    this.Userpassword.Text = model?.Userpassword;
                    this.Dbname.Text = model?.Dbname;
                }
            }
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


        private void addconfig_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void consql_Click(object sender, EventArgs e)
        {
            var model = new Datebasemodel();
            model.Dbip = Dbip.Text;
            model.Dbport = Dbport.Text;
            model.Dbtype = Dbtype.Text;
            model.Useraccount = Useraccount.Text;
            model.Userpassword = Userpassword.Text;

            DbConnection conn = CreateTableLogic.GetConnByType(model);
            if (conn == null)
            {
                MessageBox.Show("连接失败");
            }
            else
            {
                MessageBox.Show("连接成功");
            }
        }



        private void Createtablebtn_Click(object sender, EventArgs e)
        {
            var db = new Datebasemodel();
            db.Dbip = Dbip.Text;
            db.Dbtype = Dbtype.SelectedItem.ToString();
            db.Dbname = Dbname.Text;
            db.Dbport = Dbport.Text;
            db.Useraccount = Useraccount.Text;
            db.Userpassword = Userpassword.Text;
            db.Name = Name.Text;

            var alldata = this.tableinfo.Text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)?.ToList();
            var res = CreateTableLogic.CreateTble(alldata, this.Isdrop.Checked, db);
            if (res.IsSucceed)
            {
                this.Resultrichnew.Text = res.Message;
            }
            else
            {
                this.Resultrichnew.Text = "创建失败";
            }
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel文件(*.xlsx)|*.xlsx|Excel97(*.xls)|*.xls";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.Filename.Text = open.FileName;
                LoadExcelFile(open.FileName);
            }
        }
        private void LoadExcelFile(string filename)
        {
            var res = NpoiHelper.InputExcelTableByNpoi(filename, out Dictionary<string, string> tabledic);
            dic = tabledic;
            ds = res;
            LoadTreeView(tabledic);
        }
        /// <summary>
        /// 表名数据，加载treeview时赋值
        /// </summary>
        private Dictionary<string, string> dic;
        /// <summary>
        /// 表列数据加载treeview时赋值
        /// </summary>
        private Result<DataSet> ds;
        //根node
        private TreeNode node;
        private void LoadTreeView(Dictionary<string, string> dic)
        {
            this.Tabletreeview.Nodes.Clear();
            this.Tabletreeview.CheckBoxes = true;
            node = new TreeNode(alltablenodekey);
            this.Tabletreeview.Nodes.Add(node);
            foreach (var item in dic)
            {
                var subnode = new TreeNode();
                subnode.Text = item.Key;
                subnode.ToolTipText = item.Value;
                node.Nodes.Add(subnode);
            }
            node.Checked = true;
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = true;
            }
            node.ExpandAll();

        }


        private void Tabletreeview_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tablename = e.Node.Text;
            if (tablename == alltablenodekey)
            {
                return;
            }
            if (this.treetablename.Text == tablename)
            {
                return;
            }
            this.treetablename.Text = tablename;
            DataTable dt = null;
            if (dic.ContainsKey(tablename))
            {
                dt = ds.Data.Tables[tablename];
            }
            if (dt == null)
            {
                MessageBox.Show("错误，不存在该表数据");
                return;
            }
            listView1.View = View.Details;
            listView1.GridLines = true;//显示网格线
            listView1.Items.Clear();//所有的项
            listView1.Columns.Clear();//标题
            listView1.FullRowSelect = true;
            for (var i = 0; i < dt.Columns.Count; i++)
            {
                this.listView1.Columns.Add(dt.Columns[i].Caption);
            }
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                for (var j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }
                this.listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);//调整列的宽度  

            //全选反选
            SelectAll(e);
        }

        //全选反选
        private void SelectAll(TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == alltablenodekey)
            {
                foreach (TreeNode item in this.Tabletreeview.Nodes)
                {
                    item.Checked = e.Node.Checked;
                }
            }
        }
        private string alltablenodekey = "所有表";

        private void excel2btn_Click(object sender, EventArgs e)
        {
            var inputlist = new Dictionary<string, List<string>>();
            for (var i = 0; i < node.Nodes.Count; i++)
            {
      
                var curnode = node.Nodes[i];

                var str = new StringBuilder();
                var dicitem = dic[curnode.Text];
                if (curnode.Checked)
                {
                    var alldata = new List<string>();
         

                    var cols = ds.Data.Tables[curnode.Text];
                    //处理表名
                    str.Append($"{curnode.Text}\t{dicitem}");
                    str.Append("\n");
                    //处理header
                    foreach (DataColumn item in cols.Columns)
                    {
                        str.Append($"{item.Caption}\t");
                    }                   
                    str.Append("\n");
                    //处理行
                    foreach(DataRow item in cols.Rows)
                    {
                        StringBuilder sb = new StringBuilder();
                        for(var p = 0; p < cols.Columns.Count; p++)
                        {
                            sb.Append($"{item[p].ToString()}\t");
                        }
                        sb.Append("\n");
                        str.Append(sb.ToString());
                    }
                    alldata = str.ToString().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    inputlist.Add(curnode.Text, alldata);
                }
            }
            var db = new Datebasemodel();
            db.Dbip = Dbip.Text;
            db.Dbtype = Dbtype.SelectedItem.ToString();
            db.Dbname = Dbname.Text;
            db.Dbport = Dbport.Text;
            db.Useraccount = Useraccount.Text;
            db.Userpassword = Userpassword.Text;
            db.Name = Name.Text;

            //结果str
            StringBuilder resstr = new StringBuilder();
            foreach (var item in inputlist)
            {
               var res= CreateTableLogic.CreateTble(item.Value, true, db);
                resstr.AppendLine($"{item.Key}表:{res.Message}");
            }
            this.excel2result.Text = resstr.ToString();
        }
    }
}
