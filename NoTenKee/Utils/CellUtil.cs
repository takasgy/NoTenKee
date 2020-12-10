using System;
using NoTenKee.Definition;
using ClosedXML.Excel;
using System.Globalization;
using NoTenKee.AppException;

namespace NoTenKee.Utils
{
    class CellUtil
    {
        /// <summary>
        /// セルへの値設定.
        /// 帳票定義で指定されるデータ型、書式設定をもとにデータを変換する.
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="value"></param>
        /// <param name="item"></param>
        public static void SetValue(IXLCell cell, String value, ReportItem item)
        {
            if (String.IsNullOrEmpty(value) )
            {
                cell.DataType = XLDataType.Text;
                cell.Value = "";
            }
            else if (String.Compare(item.DataType, ReportConst.DATA_TYPE_STRING, true).Equals(0))
            {
                cell.DataType = XLDataType.Text;
                cell.Value = value;
            }
            else if (String.Compare(item.DataType, ReportConst.DATA_TYPE_DATETIME, true).Equals(0))
            {
                if (string.IsNullOrEmpty(value))
                {
                    cell.Value = "";
                }
                else if (DateTime.TryParseExact(value, item.DataFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime trnValue))
                {
                    cell.DataType = XLDataType.DateTime;
                    cell.Value = trnValue;
                    cell.Style.DateFormat.Format = item.CellFormat;
                }
                else
                {
                    throw new NoTenKeeException("The data in the specified format cannot be converted. type:"
                                                + ReportConst.DATA_TYPE_DATETIME
                                                + ", value:" + value);
                }
            }
            else if (String.Compare(item.DataType, ReportConst.DATA_TYPE_INTEGER, true).Equals(0))
            {
                if (int.TryParse(value, out int trnValue))
                {
                    if (!string.IsNullOrEmpty(item.CellFormat))
                    {
                        cell.Style.NumberFormat.Format = item.CellFormat;
                    }
                    cell.Value = trnValue;
                }
                else
                {
                    throw new NoTenKeeException("The data in the specified format cannot be converted. type:"
                                                + ReportConst.DATA_TYPE_INTEGER
                                                + ", value:" + value);
                }
            }
            else if (String.Compare(item.DataType, ReportConst.DATA_TYPE_LONG, true).Equals(0))
            {
                if (long.TryParse(value, out long trnValue))
                {
                    cell.DataType = XLDataType.Number;
                    if (!string.IsNullOrEmpty(item.CellFormat))
                    {
                        cell.Style.NumberFormat.Format = item.CellFormat;
                    }
                    cell.Value = trnValue;
                }
                else
                {
                    throw new NoTenKeeException("The data in the specified format cannot be converted. type:"
                                                + ReportConst.DATA_TYPE_LONG
                                                + ", value:" + value);
                }
            }
            else if (String.Compare(item.DataType, ReportConst.DATA_TYPE_DOUBLE, true).Equals(0))
            {
                if (double.TryParse(value, out double trnValue))
                {
                    cell.DataType = XLDataType.Number;
                    if (!string.IsNullOrEmpty(item.CellFormat))
                    {
                        cell.Style.NumberFormat.Format = item.CellFormat;
                    }
                    cell.Value = trnValue;
                }
                else
                {
                    throw new NoTenKeeException("The data in the specified format cannot be converted. type:"
                                                + ReportConst.DATA_TYPE_DOUBLE
                                                + ", value:" + value);
                }
            }
        }
    }
}
