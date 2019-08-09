using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools
{
    public class Datebasemodel
    {
        
        public string Dbip { get; set; }
        //端口
        public string Dbport { get; set; }
        public string Useraccount { get; set; }
        public string Userpassword { get; set; }
        //数据库名称
        public string Dbname { get; set; }
        //数据库类型
        public string Dbtype { get; set; }
        //配置名称
        public string Name { get; set; }
    }
}
