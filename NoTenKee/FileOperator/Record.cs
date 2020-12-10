using System;
using System.Collections.Generic;

namespace NoTenKee.FileOperator
{
    class Record
    {
        /// <summary>
        /// CSVデータの一レコード格納用クラス.
        /// </summary>
        private Dictionary<String, String> record = null;
        public Record()
        {
            this.record = new Dictionary<String, String>();
        }
        public void Add(String key, String value)
        {
            this.record[key] = value;
        }
        public String Get(String key)
        {
            return this.record[key];
        }

    }
}
