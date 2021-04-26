using System;
using System.Linq;
using System.Xml.Linq;

namespace NoTenKee.Utils
{
    /// <summary>
    /// 環境情報を保持するためのクラス
    /// </summary>
    public sealed class EnvUtil
    {
        private string templatePath;
        private string temporaryPath;
        private string outputPath;
        private static EnvUtil instance = new EnvUtil();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private EnvUtil() { }

        public static EnvUtil Instance { get =>instance; }
        // ExcelのテンプレートBookの格納パス
        public string TemplatePath { get => templatePath; }
        // 帳票生成時の一時作業パス
        public string TmporaryPath { get => temporaryPath; }
        // 生成したBookの出力パス
        public string OutputPath { get => outputPath; }

        /// <summary>
        /// 指定された環境情報XMLより値を設定.
        /// </summary>
        /// <param name="envPath">実行環境情報XMLファイルのパス</param>
        public void SetValue(String envPath)
        {
            var xdoc = XDocument.Load(envPath);

            var elmEnv = (
                        from env in xdoc.Descendants(EnvConst.XML_ENV)
                        select env).Single();

            // プロパティの値設定
            templatePath = elmEnv.Element(EnvConst.TEMPLATE_PATH).Value;
            temporaryPath = elmEnv.Element(EnvConst.TEMPORARY_PATH).Value;
            outputPath = elmEnv.Element(EnvConst.OUTPUT_PATH).Value;
        }
    }
}
