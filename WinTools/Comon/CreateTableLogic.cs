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
            var res = new Result() { IsSucceed=false};
            var tableinfo = new TableInfo() { TableColumns = new List<TableColumn>() };

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
                    col.ColType = colinfo[1] ?? "";
                    col.ColLength = colinfo[2].Toint();
                    col.ColDefault = colinfo[3];
                    col.ColPrimary = colinfo[4].Tobool();
                    col.ColEmpty = colinfo[5].Tobool();
                    col.ColSymbol = colinfo[6];
                    col.ColAuto = colinfo[7].Tobool();
                    col.ColRemart = colinfo[8];
                    tableinfo.TableColumns.Add(col);
                }


                index++;
            }

            try
            {
                using (var db = GetConnByType(model))
                {
                    db.Open();
                    var iscunzai = IsTableExist(model, db,tableinfo);
                    if (!isdrop && iscunzai)
                    {
                        res.IsSucceed = false;
                        res.Message = $"已存在{tableinfo.TableName}表";
                        return res;
                    }
                    res = Ctable(tableinfo, db);
                    //再次查询获取建表结果
                    res.IsSucceed= IsTableExist(model, db,tableinfo);
                    res.Message = res.IsSucceed ? $"创建{tableinfo.TableName}成功，共{tableinfo.TableColumns.Count}个字段" : $"创建{tableinfo.TableName}失败";
                }
            }
            catch (Exception ex)
            {

            }


            return res;
        }
        private static bool IsTableExist(Datebasemodel model,DbConnection db, TableInfo info)
        {
            bool res = false;
            try
            {
                var dbcom = db.CreateCommand();
                var sql = $"SELECT count(1) FROM information_schema.TABLES WHERE table_name ='{info.TableName}' and table_schema='{model.Dbname}';";
                dbcom.CommandText = sql;
                var iscunzai = dbcom.ExecuteScalar().Toint();
                res = iscunzai > 0;
            }
            catch(Exception ex)
            {
                
            }
            return res;
        }
        /// <summary>
        /// 建表操作
        /// </summary>
        /// <param name="tableInfo"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private static Result Ctable(TableInfo tableInfo, DbConnection db)
        {
            var res = new Result();
            var str = new StringBuilder();
            str.Append($"drop table if exists {tableInfo.TableName};");
            str.Append($"Create table `{tableInfo.TableName}`(");
            //只考虑了单主键
            string primarykey = "KID";
            foreach (var item in tableInfo.TableColumns)
            {
                var ispri = item.ColPrimary.Tobool();
                var isnull = item.ColEmpty ?  "": "NOT NULL";
                var isauto = item.ColAuto ?  "AUTO_INCREMENT":"";
                if (ispri)
                {
                    var aa = $" `{item.ColName}` {Getcoltype(item.ColType, item.ColLength)} {isnull} {isauto}  COMMENT '{item.ColRemart}' ,";
                    str.Append(aa);
                }
                else
                {
                    var aa = $" `{item.ColName}` {Getcoltype(item.ColType, item.ColLength)} {isnull} {isauto} {Getcoldefault(item.ColType, item.ColDefault)} COMMENT '{item.ColRemart}' ,";
                    str.Append(aa);
                }


            }
            str.Append($"PRIMARY KEY(`{primarykey}`) ) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COMMENT='{tableInfo.TableRemark}';");

            var a = str.ToString();


            var com = db.CreateCommand();
            com.Connection = db;
            com.CommandText = a;
            var t = com.ExecuteNonQuery();
            //res.IsSucceed = t > 0;
            //res.Message = t.ToString();
            return res;

        }
        /// <summary>
        /// 获取数据表字段的default值
        /// </summary>
        /// <param name="coltype"></param>
        /// <param name="defdata"></param>
        /// <returns></returns>
        private static string Getcoldefault(string coltype, string defdata)
        {
            coltype = coltype.ToLower();
            var res = "";
            switch (coltype)
            {
                case "int":
                    res = $"DEFAULT  0";
                    break;
                case "varchar":
                    res = $"DEFAULT '{defdata}'";
                    break;
                case "datetime":
                    res = $"DEFAULT '1970-01-01 08:00:00'";
                    break;
                case "timestamp":
                    res = $"DEFAULT CURRENT_TIMESTAMP ";
                    break;
                case "tinyint":
                    res = string.IsNullOrEmpty(defdata)?"DEFAULT 0":$"DEFAULT {defdata}";
                    break;
                default:
                    res = $"DEFAULT '{defdata}'";
                    break;
            }
            return res;
        }
        /// <summary>
        /// 获取数据表的类型
        /// </summary>
        /// <param name="coltype"></param>
        /// <param name="lenth"></param>
        /// <returns></returns>
        private static string Getcoltype(string coltype, int lenth)
        {
            coltype = coltype.ToLower();
            var res = "";
            switch (coltype)
            {
                case "int":
                    res = lenth > 0 ? $"int({ lenth})" : "int";
                    break;
                case "varchar":
                    res = lenth > 0 ? $"varchar({ lenth})" : "varchar(64)";
                    break;
                case "datetime":
                    res = "datetime";
                    break;
                case "decimal":
                    coltype= "decimal(19,2)";
                    break;
                case "tinyint":
                    res = lenth > 0 ? $"tinyint({ lenth})" : "tinyint";
                    break;
                default:
                    if (lenth > 0)
                    {
                        res = $"{coltype}({lenth})";
                    }
                    else
                    {
                        res = coltype;
                    }
                    break;
            }
            return res;
        }
        private static string GetDbtype(string type)
        {
            type = type.ToLower();
            switch (type)
            {
                case "datetime":
                    return "DateTime";
                case "int":
                    return "int";
                case "varchar":
                    return "varchar";
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
                    return "varchar";
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
