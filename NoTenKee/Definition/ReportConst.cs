using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.Definition
{
    /// <summary>
    /// 帳票定義用定数
    /// </summary>
    static class ReportConst
    {
        // 帳票用XML定義に関するタグ
        public const String REPORT = "report";

        // 帳票用Bookに関するタグ
        public const String REPORT_BOOK = "book";
        // 帳票名
        public const String BOOK_ATTR_REPORT_NAME = "report_name";
        // 帳票のタイプ
        public const String BOOK_ATTR_TYPE = "type";
        public const String BOOK_REFERENCE_FORMAT = "reference_format";
        public const String BOOK_ATTR_TEMPLATENAME = "template_name";
        public const String BOOK_ATTR_FILENAME = "file_name";
        public const String BOOK_MAX_SHEET = "max_sheet";
        public const string BOOK_SHEET_NAME = "sheet_name";
        public const String BOOK_SHEET_TEMPLATENAME = "template_sheet";
        public const int BOOK_MAX_SHEET_DEF = 50;
        public const String BOOK_BREAK_KEY = "break_key";
        // キーブレイク時の動作
        public const String BOOK_BREAK_ACTION = "break_action";

        // キーブレイク時に新しいSheetに切り替わる
        public const String BOOK_BREAK_ACTION_NEW_SHEET = "newsheet";
        // キーブレイク時に新しいBookに切り替わる
        public const String BOOK_BREAK_ACTION_NEW_BOOK = "newbook";
        // キーブレイクしない
        public const String BOOK_BREAK_ACTION_NO_PROCESSING = "no_processing";

        // 帳票用ヘッダ・フッダ部
        public const String REPORT_CELLS = "cells";
        public const String REPORT_CELL = "cell";

        // 帳票用ボディ部
        public const String REPORT_ROW_INFO = "row_info";
        public const String REPORT_ROW_CELLS = "row_cells";
        public const String REPORT_ROW_CELL = "row_cell";

        // Bookの参照形式(A1形式)
        public const String REFERENCE_FORMAT_A1 = "a1";
        // Bookの参照形式(R1C1形式)
        public const String REFERENCE_FORMAT_R1C1 = "r1c1";

        // 行データに関するタグ
        public const String SHEET_ROW = "row";
        // 行の名前
        public const String ROW_NMAE = "name";
        // 行のタイプ(一覧の繰り返し方向)
        public const String ROW_LIST_TYPE = "list_type";
        // 縦方向の最大行数
        public const String ROW_N_ROW_MAX = "n_row_max";
        // 縦1行の段数
        public const String ROW_N_INCREMENTAL = "n_incremental";
        // 横方向の最大行数
        public const String ROW_Z_ROW_MAX = "z_row_max";
        // 横1行の段数
        public const String ROW_Z_INCREMENTAL = "z_incremental";
        //　最大業に達した場合のペーシブレイク可否
        public const String ROW_PAGE_BREAK = "page_break";

        // 帳票のタイプ
        //　単票形式
        public const String BOOK_ATTR_TYPE_SINGLE = "SINGLE";

        //　一覧表形式
        public const String BOOK_ATTR_TYPE_LIST = "LIST";

        // 一覧の繰り返し方向
        // 横から縦
        public const String REPORT_TYPE_Z = "Z";
        // 縦から横
        public const String REPORT_TYPE_N = "N";

        // 帳票項目用定義
        public const String CELL_ATTR_NAME = "name";
        public const String CELL_ATTR_CSV_KEY = "csv_key";  //　未使用
        public const String CELL_ATTR_CSV_POSIOTION = "position";
        public const String CELL_ATTR_POSIOTION_X = "positionX";
        public const String CELL_ATTR_POSIOTION_Y = "positionY";
        public const String CELL_ATTR_DATATYPE = "data_type";
        public const String CELL_ATTR_DATA_FORMAT = "data_format";
        public const String CELL_ATTR_CELL_FORMAT = "cell_format";

        // 帳票項目のデータ型
        public const String DATA_TYPE_STRING = "String";
        public const String DATA_TYPE_INTEGER = "Int";
        public const String DATA_TYPE_LONG = "Long";
        public const String DATA_TYPE_DOUBLE = "double";
        public const String DATA_TYPE_DATETIME = "Datetime";

        public const int DEFAULT_MIN = 1;

        // CSV
        public const String CSV_INFO = "csv_info";
        public const String CSV_DELIMITER = "delimiter";
        public const String CSV_QUOTE = "quote";
        public const String CSV_CODESET = "codeset";
        public const String CSV_CSV_HEADER = "csv_header";

        // CSVヘッダあり
        public const String CSV_CSV_HEADER_TRUE = "true";
    }

}
