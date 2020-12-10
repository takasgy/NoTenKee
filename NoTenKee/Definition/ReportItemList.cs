using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoTenKee.Definition
{
    /// <summary>
    /// 帳票項目リスト.
    /// </summary>
    class ReportItemList
    {
        private IList<ReportItem> itemList = new List<ReportItem>();
        private int index = 0;

        /// <summary>
        /// 帳票項目のリスト追加.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(ReportItem item)
        {
            this.itemList.Add(item);
        }

        /// <summary>
        /// 項目リストindexの初期化.
        /// </summary>
        public void InitializeIndex()
        {
            this.index = 0;
        }

        /// <summary>
        /// 帳票項目リスト件数を所得する.
        /// </summary>
        /// <returns>帳票項目リスト件数</returns>
        public int Size()
        {
            return this.itemList.Count();
        }

        /// <summary>
        /// 帳票項目リストに次の値が存在するか判定する.
        /// </summary>
        /// <returns>項目あり(true)</returns>
        public bool HasNext()
        {
            if (!this.itemList.Count().Equals(0) && (this.itemList.Count() - 1) >= this.index)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 帳票項目リストの値を取得する.
        /// </summary>
        /// <returns>帳票項目データ</returns>
        public ReportItem Next()
        {
            ReportItem reult = null;
            if (this.HasNext())
            {
                reult = itemList[this.index++];
            }
            return reult;
        }
    }

}
