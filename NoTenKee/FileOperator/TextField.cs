using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;

namespace NoTenKee.FileOperator
{
    class TextField
    {
        /// <summary>
        /// CSVファイルからデータをStringの配列で取得する.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="delimiter"></param>
        /// <param name="quote"></param>
        /// <param name="encoding"></param>
        /// <returns>CSVファイルの1レコード</returns>
        public static IEnumerable<string[]> Context(
            string path, string delimiter, string quote, bool headerFrag, Encoding encoding = null)
        {
            using (StreamReader streamReader = new StreamReader(path, encoding ?? Encoding.UTF8))
            using (CsvReader reader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                if (!string.IsNullOrEmpty(delimiter))
                {
                    reader.Configuration.Delimiter = delimiter;
                }
                if (!string.IsNullOrEmpty(quote))
                {
                    reader.Configuration.Quote = Convert.ToChar(quote);
                }
                reader.Configuration.HasHeaderRecord = headerFrag;
                List<string> values = new List<string>();
                while (reader.Read())
                {
                    values.Clear();
                    for (int i = 0; reader.TryGetField<string>(i, out string value); i++)
                    {
                        values.Add(value);
                    }
                    yield return values.ToArray();
                }
            }
        }

    }
}
