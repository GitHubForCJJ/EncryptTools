using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools.Models
{
    public class TableColumn
    {
        /// <summary>
        /// 列名
        /// </summary>
        public string ColName { get; set; }
        //类型
        public string ColType { get; set; }
        //列长度
        public string ColLength { get; set; }
        public string ColDefault { get; set; }
        //是否为主键
        public string ColPrimary { get; set; }
        //可空
        public string ColEmpty { get; set;}
        //符号
        public string ColSymbol { get; set; }
        //自增
        public string ColAuto { get; set; }
        //备注
        public string ColRemart { get; set; }

    }
}
