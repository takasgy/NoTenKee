using System;
using System.Collections.Generic;
using System.Text;

namespace NoTenKee.Definition
{
    /// <summary>
    /// 帳票項目格納用Bean定義.
    /// </summary>
    class ReportItem
    {
        private String name;        // 帳票項目名
        private String dataType;    // 帳票項目データ型
        private String dataFormat;  // CSVデータの書式設定
        private String cellFormat;  // 帳票項目の書式設定
        private int position;       // CSVの項目位置
        private int positionX;      // 帳票項目の横位置
        private int positionY;      // 帳票項目の縦位置

        public string Name { get => name; set => name = value; }
        public string DataType { get => dataType; set => dataType = value; }
        public string DataFormat { get => dataFormat; set => dataFormat = value; }
        public string CellFormat { get => cellFormat; set => cellFormat = value; }
        public int Posiotion { get => position; set => position = value; }
        public int PosiotionX { get => positionX; set => positionX = value; }
        public int PosiotionY { get => positionY; set => positionY = value; }
    }
}
