using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTools.Models
{
    public class TableInfo
    {
        public string TableName { get; set; }
        public string TableRemark { get; set; }
        public List<TableColumn> TableColumns { get; set; }
    }
}
