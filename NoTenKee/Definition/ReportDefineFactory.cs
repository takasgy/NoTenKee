using System;
using System.IO;

namespace NoTenKee.Definition
{
    class ReportDefineFactory
    {
        /// <summary>
        /// 帳票定義オブジェクトの生成.
        /// </summary>
        /// <param name="refDefPath">帳票定義ファイルパス</param>
        /// <returns></returns>
        public static ReportDefinition CreateDefinition(String refDefPath)
        {
            if (File.Exists(refDefPath))
            {
                ReportDefinitionXMLReader reader = new ReportDefinitionXMLReader();
                return reader.DoRead(refDefPath);
            } else
            {
                throw new FileNotFoundException("XML File not found!");
            }
        }
    }
}
