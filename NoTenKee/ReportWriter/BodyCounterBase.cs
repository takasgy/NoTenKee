namespace NoTenKee.ReportWriter
{
    /// <summary>
    /// 帳票明細部分の行カウンター.
    /// </summary>
    abstract class BodyCounterBase
    {
        private bool isBreak = false;
        private int xCounter = 0;
        private int xMax = 0;
        private int xIncremental = 0;
        protected int xPostion = 0;
        private int yCounter = 0;
        private int yMax = 0;
        private int yIncremental = 0;
        protected int yPostion = 0;

        public BodyCounterBase()
        {
            Initialize();
        }

        public void Initialize()
        {
            xCounter = 0;
            yCounter = 0;
            xPostion = 0;
            yPostion = 0;
            isBreak = false;
        }

        /// <summary>
        /// 横方向の最大行数.
        /// </summary>
        /// <param name="xMax"></param>
        protected void SetXMax(int xMax)
        {
            this.xMax = xMax;
        }

        /// <summary>
        /// 横方向の一行移動時のセル数.
        /// </summary>
        /// <param name="xIncremental"></param>
        protected void SetXIncremental(int xIncremental)
        {
            this.xIncremental = xIncremental;
        }

        /// <summary>
        /// 縦方向の最大行数.
        /// </summary>
        /// <param name="yMax"></param>
        protected void SetYMax(int yMax)
        {
            this.yMax = yMax;
        }

        /// <summary>
        /// 縦方向の一行移動時のセル数.
        /// </summary>
        /// <param name="yIncremental"></param>
        protected void SetYIncremental(int yIncremental)
        {
            this.yIncremental = yIncremental;
        }

        /// <summary>
        /// 明細行カウンターのカウントアップ.
        /// </summary>
        public void CountUp()
        {
            if (yMax <= ++yCounter)
            {
                yCounter = 0;
                yPostion = 0;
                if (xMax <= ++xCounter)
                {
                    xCounter = 0;
                    xPostion = 0;
                    isBreak = true;
                }
                else
                {
                    xPostion = xPostion + xIncremental;
                }
            }
            else
            {
                yPostion = yPostion + yIncremental;
            }
        }

        /// <summary>
        /// セルの横位置を返します.
        /// </summary>
        /// <returns>セル(横方向)</returns>
        public virtual int GetXPosition()
        {
            return xPostion;
        }

        /// <summary>
        /// セルの縦位置を返します.
        /// </summary>
        /// <returns>セル(縦方向)</returns>
        public virtual int GetYPosition()
        {
            return yPostion;
        }

        /// <summary>
        /// 明細行カウンターのカウントアップ時のページブレイク判定.
        /// </summary>
        /// <returns></returns>
        public bool IsPageBreak()
        {
            return isBreak;
        }

    }
}
