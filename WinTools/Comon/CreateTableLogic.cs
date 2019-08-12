using FastDev.Common.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinTools.Models;

namespace WinTools.Comon
{
    public class CreateTableLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alldata">所有的数据</param>
        /// <param name="isdrop">如果表存在是否删除在重建</param>
        /// <param name="model">数据库连接对象</param>
        /// <returns></returns>
        public static Result CreateTble(List<string> alldata, bool isdrop, Datebasemodel model)
        {
            var res = new Result();
            var tableinfo = new TableInfo() {TableColumns=new List<TableColumn>() };

            var index = 0;
            foreach (var item in alldata)
            {
                //过滤第二行
                if (index == 1) { index++; continue; }
                var colinfo = item.Split(new char[] { '\t' });
                if (index == 0)
                {
                    tableinfo.TableName = colinfo[0];
                    tableinfo.TableRemark = colinfo[1];
                }
                else
                {
                    var col = new TableColumn();
                    col.ColName = colinfo[0] ?? "";
                    col.ColType = GetDbtype(colinfo[1] ?? "");
                    col.ColLength = colinfo[1] != "varchar" ? "0" : string.IsNullOrEmpty(colinfo[2]) ? "512" : colinfo[2];
                    col.ColDefault = colinfo[3];
                    col.ColPrimary = colinfo[4];
                    col.ColEmpty = colinfo[5];
                    col.ColSymbol = colinfo[6];
                    col.ColAuto = colinfo[7];
                    col.ColRemart = colinfo[8];
                    tableinfo.TableColumns.Add(col);
                }


                index++;
            }

            try
            {
                using (var db = GetConnByType(model))
                {
                    var dbcom = db.CreateCommand();
                    var sql = $"SELECT count(1) FROM information_schema.TABLES WHERE table_name ='{tableinfo.TableName}' and table_schema='{model.Dbname}';";
                    dbcom.CommandText = sql;
                    var iscunzai = dbcom.ExecuteScalar();
                }
            }
            catch(Exception ex)
            {

            }


            return res;
        }
        private static Result Ctable(TableInfo tableInfo,DbConnection db)
        {
            var res =new Result();
            var str = new StringBuilder();
            str.Append("Create table");
            return res;

        }
        private static string GetDbtype(string type)
        {
            switch (type)
            {
                case "datetime":
                    return "DateTime";
                case "int":
                    return "int";
                case "varchar":
                    return "string";
                case "timestamp":
                    return "DateTime";
                case "tinyint":
                    return "int";
                case "bit":
                    return "bool";
                case "bigint":
                    return "long";
                case "boolean":
                    return "bool";
                case "decimal":
                    return "decimal";
                default:
                    return "string";
            }
        }

        /// <summary>
        /// 获取连接对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static DbConnection GetConnByType(Datebasemodel model)
        {
            var strconn = string.Empty;
            switch (model.Dbtype)
            {
                case "Mysql":
                    strconn = $"server={model.Dbip};port={model.Dbport}; user id={model.Useraccount}; password={model.Userpassword};database={model.Dbname}; pooling=false;CharSet=utf8;Allow Zero Datetime=True";
                    try
                    {
                        var a = new MySqlConnection(strconn);
                        a.Open();
                        a.Close();
                        return a;
                    }
                    catch
                    {
                        return null;
                    }

                default:
                    strconn = $"server={model.Dbip};port={model.Dbport}; user id={model.Useraccount}; password={model.Userpassword};database={model.Dbname}; pooling=false;CharSet=utf8;Allow Zero Datetime=True";
                    try
                    {
                        var a = new MySqlConnection(strconn);
                        a.Open();
                        a.Close();
                        return a;
                    }
                    catch
                    {
                        return null;
                    }

            }
        }
    }
}
