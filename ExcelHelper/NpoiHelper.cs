using FastDev.Common.Code;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHelper
{
    public class NpoiHelper
    {
        /// <summary>
        /// 使用Npoi方式导入 代码生成工具专用的DataSet
        /// </summary>
        /// <param name="fileFullName">文件名</param>
        /// <param name="tableComment">表注释</param>
        /// <param name="excludeSheets">需要排除的sheet名称</param>
        /// <returns>
        /// DataTable.
        /// </returns>
        public static Result<DataSet> InputExcelTableByNpoi(string fileFullName, out Dictionary<string, string> tableComment, List<string> excludeSheets = null)
        {
            var ret = new Result<DataSet>();

            tableComment = new Dictionary<string, string>();
            try
            {
                DataSet ds = new DataSet();
                IWorkbook workbook;
                List<ISheet> iSheetLst = new List<ISheet>();

                #region Excel版本判断
                if (fileFullName.ToLower().EndsWith(".xlsx"))
                {
                    using (FileStream file = new FileStream(fileFullName, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new XSSFWorkbook(file);
                    }
                    for (int k = 0; k < workbook.NumberOfSheets; k++)
                    {
                        if (excludeSheets != null && excludeSheets.Contains(workbook.GetSheetAt(k).SheetName))
                            continue;
                        iSheetLst.Add(workbook.GetSheetAt(k));
                    }
                }
                else
                {
                    using (FileStream file = new FileStream(fileFullName, FileMode.Open, FileAccess.Read))
                    {
                        workbook = new HSSFWorkbook(file);
                    }
                    for (int k = 0; k < workbook.NumberOfSheets; k++)
                    {
                        iSheetLst.Add(workbook.GetSheetAt(k));
                    }
                }
                #endregion

                #region Excel处理

                for (int k = 0; k < iSheetLst.Count; k++)
                {
                    DataTable dt = new DataTable();

                    ISheet sheet = iSheetLst[k];// hssfworkbook.GetSheetAt(k);

                    try
                    {
                        System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

                        IRow headerRow = sheet.GetRow(1);
                        int cellCount = headerRow.LastCellNum;

                        for (int j = 0; j < cellCount; j++)
                        {
                            ICell cell = headerRow.GetCell(j);
                            dt.Columns.Add(cell.ToString());
                        }

                        #region 处理第一行的表名和注释

                        IRow firstRow = sheet.GetRow(0);
                        var tableName = firstRow.GetCell(0).ToString();

                        while (tableComment.ContainsKey(tableName))
                        {
                            tableName += "_r";
                        }
                        dt.TableName = tableName;
                        tableComment.Add(tableName, firstRow.GetCell(1).ToString());

                        #endregion

                        for (int i = (sheet.FirstRowNum + 2); i <= sheet.LastRowNum; i++)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null)
                                break;
                            DataRow dataRow = dt.NewRow();
                            bool isDataRow = false;//是否为有效数据行,如果每列的值都为空 则为无效行,需要过滤掉
                            for (int j = row.FirstCellNum; j < cellCount; j++)
                            {
                                var cell = row.GetCell(j);
                                if (cell != null)
                                {
                                    #region 数据格式判断读取
                                    if (cell.CellType == CellType.Numeric)
                                    {
                                        isDataRow = true;
                                        if (DateUtil.IsCellDateFormatted(cell))
                                        {
                                            dataRow[j] = cell.DateCellValue;
                                        }
                                        else
                                        {
                                            dataRow[j] = cell.NumericCellValue;
                                        }
                                    }
                                    else if (cell.CellType == CellType.Blank)
                                    {
                                        dataRow[j] = "";
                                    }
                                    else if (cell.CellType == CellType.Formula)
                                    {
                                        isDataRow = true;
                                        if (fileFullName.ToLower().EndsWith(".xlsx"))
                                        {
                                            var eva = new XSSFFormulaEvaluator(workbook);
                                            dataRow[j] = eva.Evaluate(cell).StringValue;
                                        }
                                        else
                                        {
                                            var eva = new HSSFFormulaEvaluator(workbook);
                                            dataRow[j] = eva.Evaluate(cell).StringValue;
                                        }
                                    }
                                    else if (cell.CellType == CellType.String)
                                    {
                                        isDataRow = true;
                                        dataRow[j] = cell.StringCellValue;
                                    }
                                    else
                                    {
                                        isDataRow = true;
                                        dataRow[j] = row.GetCell(j).ToString();
                                    }
                                    #endregion
                                }
                            }
                            if (isDataRow)
                            {
                                dt.Rows.Add(dataRow);
                            }
                        }

                        ds.Tables.Add(dt);
                    }
                    catch (Exception ep)
                    {
                        //LogHelper.WriteLog(ep, "文件导入异常index:" + k.ToString() + "sheetName:" + sheet.SheetName);
                    }
                }
                #endregion

                ret.Data = ds;
                ret.IsSucceed = true;
                ret.Message = "导入成功";
            }
            catch (Exception ex)
            {
                ret.Message = ex.Message;
            }

            return ret;
        }
    }
}
