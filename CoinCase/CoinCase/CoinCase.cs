namespace CoinCase
{
    /// <summary>
    /// コインの種類
    /// </summary>
    public enum CoinType
    {
        YEN1 = 0,
        YEN5,
        YEN10,
        YEN50,
        YEN100,
        YEN500,

        MAX,
    }

    /// <summary>
    /// コインケースクラス
    /// </summary>
    public class CoinCase
    {
        // 各硬貨の枚数
        private int[] coinStorage = new int[(int)CoinType.MAX];

        private int[] coinValues = { 1, 5, 10, 50, 100, 500 };

        /// <summary>
        /// コインを追加する
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        public void AddCoins(int type, int amount)
        {
            coinStorage[type] += amount;
        }

        /// <summary>
        /// 指定した硬貨の枚数を取得する
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int GetCount(int type)
        {
            return coinStorage[type];
        }

        /// <summary>
        /// 全ての硬貨枚数を取得する
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            int allCount = 0;
            foreach (var coin in coinStorage)
            {
                allCount += coin;
            }

            return allCount;
        }

        /// <summary>
        /// コインケース内の金額を取得する
        /// </summary>
        /// <returns></returns>
        public int GetAmount()
        {
            int amount = 0;
            for (int i = 0; i < (int)CoinType.MAX; i++)
            {
                amount += coinStorage[i] * coinValues[i];
            }
            return amount;
        }

        /// <summary>
        /// 指定した硬貨の金額を取得する
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int GetAmount(int type)
        {
            return coinStorage[type] * coinValues[type];
        }


    }
}
