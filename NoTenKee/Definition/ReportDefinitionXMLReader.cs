using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using NoTenKee.AppException;
using NoTenKee.Utils;

namespace NoTenKee.Definition
{
    /// <summary>
    /// 帳票定義XMLの読み込みクラス.
    /// </summary>
    class ReportDefinitionXMLReader
    {
        /// <summary>
        /// 指定されたパスの帳票定義XMLファイルを取得する.
        /// </summary>
        /// <param name="file">帳票定義XMLファイルのパス</param>
        /// <returns>帳票定義クラス</returns>
        public ReportDefinition DoRead(String file)
        {
            ReportDefinition repDef = new ReportDefinition();

            try
            {
                var xdoc = XDocument.Load(file);

                // 帳票情報の取得
                var empBook = (
                    from book in xdoc.Descendants(ReportConst.REPORT_BOOK)
                    select book).Single();

                repDef.ReportName = empBook.Element(ReportConst.BOOK_ATTR_REPORT_NAME).Value;
                repDef.Type = empBook.Element(ReportConst.BOOK_ATTR_TYPE).Value.ToLower();
                repDef.ReferenceFormat = empBook.Element(ReportConst.BOOK_REFERENCE_FORMAT).Value;
                repDef.BreakAction = empBook.Element(ReportConst.BOOK_BREAK_ACTION).Value;
                repDef.TemplateName = empBook.Element(ReportConst.BOOK_ATTR_TEMPLATENAME).Value;
                repDef.FileName = empBook.Element(ReportConst.BOOK_ATTR_FILENAME).Value;
                repDef.BreakKey = empBook.Element(ReportConst.BOOK_BREAK_KEY).Value.Split(',');
                repDef.BreakAction = empBook.Element(ReportConst.BOOK_BREAK_ACTION).Value;
                repDef.MaxSheet =
                    int.TryParse(empBook.Element(ReportConst.BOOK_MAX_SHEET).Value, out int sheetMax) ? sheetMax : ReportConst.BOOK_MAX_SHEET_DEF;
                repDef.TemplateSheet = empBook.Element(ReportConst.BOOK_SHEET_TEMPLATENAME).Value;
                repDef.SheetName = empBook.Element(ReportConst.BOOK_SHEET_NAME).Value;

                // CSV関連情報の取得
                var empCsvInfo = (
                    from csv_info in xdoc.Descendants(ReportConst.CSV_INFO)
                    select csv_info).Single();

                if (!string.IsNullOrEmpty(empCsvInfo.Element(ReportConst.CSV_CODESET).Value))
                {
                    try
                    {
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                        repDef.Codeset = Encoding.GetEncoding(empCsvInfo.Element(ReportConst.CSV_CODESET).Value);
                    } catch(Exception e)
                    {
                        throw new NoTenKeeException(
                            "The specified code page is not supported on the platform.value=" +
                            empCsvInfo.Element(ReportConst.CSV_CODESET).Value, e);
                    }
                } 
                else
                {
                    repDef.Codeset = Encoding.UTF8;
                }
                if (!string.IsNullOrEmpty(empCsvInfo.Element(ReportConst.CSV_DELIMITER).Value))
                {
                    repDef.Delimiter = empCsvInfo.Element(ReportConst.CSV_DELIMITER).Value;
                }
                if (!string.IsNullOrEmpty(empCsvInfo.Element(ReportConst.CSV_QUOTE).Value))
                {
                    if (Char.TryParse(empCsvInfo.Element(ReportConst.CSV_QUOTE).Value, out char result)) {
                        repDef.Quote = empCsvInfo.Element(ReportConst.CSV_QUOTE).Value;
                    }
                    else
                    {
                        throw new NoTenKeeException(
                            "There is a problem with the value set in the quote.value=" + 
                            empCsvInfo.Element(ReportConst.CSV_QUOTE).Value);
                    }
                }
                if (empCsvInfo.Element(ReportConst.CSV_CSV_HEADER).Value.ToLower().Equals(ReportConst.CSV_CSV_HEADER_TRUE))
                {
                    repDef.CsvHeader = true;
                }
                else
                {
                    repDef.CsvHeader = false;
                }

                // 帳票(ヘッダ／フッタ)の項目取得
                repDef.HeaderItemList = GetElements(xdoc, repDef.ReferenceFormat, ReportConst.REPORT_CELLS, ReportConst.REPORT_CELL) ?? new ReportItemList();

                // 帳票(リスト)情報の取得
                XElement empRow = xdoc.Element(ReportConst.REPORT).Element(ReportConst.REPORT_ROW_INFO);

                repDef.RowName = empRow.Element(ReportConst.ROW_NMAE).Value;
                repDef.ListType = empRow.Element(ReportConst.ROW_LIST_TYPE).Value.ToLower();
                repDef.NRowMax =
                    int.TryParse(empRow.Element(ReportConst.ROW_N_ROW_MAX).Value, out int nRowMax) ? nRowMax : ReportConst.DEFAULT_MIN;
                repDef.NIncremental =
                    int.TryParse(empRow.Element(ReportConst.ROW_N_INCREMENTAL).Value, out int nIncr) ? nIncr : ReportConst.DEFAULT_MIN;
                repDef.ZRowMax =
                    int.TryParse(empRow.Element(ReportConst.ROW_Z_ROW_MAX).Value, out int zRowMax) ? zRowMax : ReportConst.DEFAULT_MIN;
                repDef.ZIncremental =
                    int.TryParse(empRow.Element(ReportConst.ROW_Z_INCREMENTAL).Value, out int zIncr) ? zIncr : ReportConst.DEFAULT_MIN;

                // 帳票(リスト)の項目情報取得
                repDef.BodyItemList = GetElements(xdoc, repDef.ReferenceFormat, ReportConst.REPORT_ROW_CELLS, ReportConst.REPORT_ROW_CELL) ?? new ReportItemList();
            }
            catch (System.Xml.XmlException e)
            {
                throw new NoTenKeeException("Exception object Line, pos: (" + e.LineNumber + "," + e.LinePosition + ")", e);
            }
            catch (System.InvalidOperationException e)
            {
                throw new NoTenKeeException("Inappropriate value is set in the form definition.", e);
            }
            catch (System.NullReferenceException e)
            {
                throw new NoTenKeeException("Required items are not specified in the form definition.", e);
            }
            return repDef;
        }

        /// <summary>
        /// 帳票定義XMLからリスト形式の定義を取得する.
        /// </summary>
        /// <param name="xdoc">対象のXDocクラス</param>
        /// <param name="referenceFormat">Excelの表示形式</param>
        /// <param name="elementsName">対象リスト名</param>
        /// <param name="elementName">対象の要素名</param>
        /// <returns>定義のリスト</returns>
        private ReportItemList GetElements(XDocument xdoc, String referenceFormat, string elementsName, string elementName)
        {
            CnvertA1ToR1C1Util cnvUtil = new CnvertA1ToR1C1Util();

            var itemList = new ReportItemList();
            IEnumerable<XElement> elms = (
                from elm in xdoc.Root.Descendants(elementName)
                select elm);

            foreach (XElement el in elms)
            {
                if (el != null)
                {
                    ReportItem item = new ReportItem
                    {
                        Name = el.Element(ReportConst.CELL_ATTR_NAME).Value,
                        DataType = el.Element(ReportConst.CELL_ATTR_DATATYPE).Value
                    };

                    // CSVデータのデータ形式
                    try
                    {
                        item.DataFormat = el.Element(ReportConst.CELL_ATTR_DATA_FORMAT).Value is null ? "" : el.Element(ReportConst.CELL_ATTR_DATA_FORMAT).Value;

                    }
                    catch (System.NullReferenceException e)
                    {
                        item.DataFormat = "";
                    }

                    // Excelのセルに設定するデータ形式
                    try
                    {
                        item.CellFormat = el.Element(ReportConst.CELL_ATTR_CELL_FORMAT).Value is null ? "" : el.Element(ReportConst.CELL_ATTR_CELL_FORMAT).Value;

                    }
                    catch (System.NullReferenceException e)
                    {
                        item.CellFormat = "";
                    }

                    // セル位置の取得
                    item.Posiotion =
                        int.TryParse(el.Element(ReportConst.CELL_ATTR_CSV_POSIOTION).Value, out int pos) ? (pos -1) : ReportConst.DEFAULT_MIN;
                    if (String.Compare(referenceFormat, ReportConst.REFERENCE_FORMAT_A1, true) == 0)
                    {
                        item.PosiotionX =
                            cnvUtil.Execute(el.Element(ReportConst.CELL_ATTR_POSIOTION_X).Value);
                    }
                    else
                    {
                        item.PosiotionX =
                            int.TryParse(el.Element(ReportConst.CELL_ATTR_POSIOTION_X).Value, out int posX) ? (posX) : ReportConst.DEFAULT_MIN;
                    }
                    item.PosiotionY =
                        int.TryParse(el.Element(ReportConst.CELL_ATTR_POSIOTION_Y).Value, out int posY) ? (posY) : ReportConst.DEFAULT_MIN;
                    itemList.AddItem(item);
                }
            }
            return itemList;
        }
    }

}
