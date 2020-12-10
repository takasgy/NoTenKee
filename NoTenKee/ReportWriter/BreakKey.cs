using System;
using System.Collections.Generic;
using NoTenKee.Definition;
using NoTenKee.AppException;

namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票のコントロールブレイクキー用インターフェース.
    /// </summary>
    class BreakKey : IBreakKey
    {
        // キー値のリスト
        private IList<String> breakKeyCols = new List<String>();
        // 比較用キーのディクショナリ
        private Dictionary<String, String> breakKeyValues;

        public BreakKey(ReportDefinition repDef)
        {
            try
            {
                foreach (String keyCol in repDef.BreakKey)
                {
                    breakKeyCols.Add(keyCol);
                }
            }
            catch (NullReferenceException e)
            {
                throw new NoTenKeeException("Break key is not set", e);
            }
        }

        /// <summary>
        /// 新しいキー値を設定する.
        /// </summary>
        /// <param name="data">キー値</param>
        public void SetKeyValues(Dictionary<String, String> data)
        {
            breakKeyValues = new Dictionary<String, String>();
            foreach (String keyCol in breakKeyCols)
            {
                breakKeyValues.Add(keyCol, data[keyCol].ToString());
            }
        }

        /// <summary>
        /// 帳票をページブレイクするか判定する.
        /// ※ブレイクキーが設定されていない場合、一致を返す.
        /// </summary>
        /// <param name="data">キー値</param>
        /// <returns>true(一致)</returns>
        public bool Compare(Dictionary<String, String> data)
        {
            foreach (String keyCol in breakKeyCols)
            {
                if (breakKeyValues == null || !breakKeyValues[keyCol].Equals(data[keyCol].ToString()))
                {
                    SetKeyValues(data);
                    return false;
                }
            }
            return true;
        }
    }
}
