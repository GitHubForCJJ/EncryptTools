using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTools
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Adddb_Load(object sender, EventArgs e)
        {
            this.Dbtype.SelectedIndex = 0;
        }

        private void Adddbconfig_Click(object sender, EventArgs e)
        {
            var db = new Datebasemodel();
            db.Dbip = Dbip.Text;
            db.Dbtype = Dbtype.SelectedText;
            db.Dbname = Dbname.Text;
            db.Dbport = Dbport.Text;
            db.Useraccount = Useraccount.Text;
            db.Userpassword = Userpassword.Text;
            db.Name = Name.Text;
            db.Addtime = DateTime.Now;

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
                list.Add(db);
                var insertstr = JsonConvert.SerializeObject(list);
                File.WriteAllText(configfilename, insertstr);
                MessageBox.Show("配置成功");
            }
            else
            {
                MessageBox.Show("配置文件不存在");
            }
        }
    }
}
