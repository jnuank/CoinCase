using System;
using System.Windows.Forms;

namespace CoinCase
{
    public partial class Form1 : Form
    {
        CoinCase logic = new CoinCase();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            logic.AddCoins(cmbCoin.SelectedIndex, 1);

            txtOne.Text            = logic.GetCount((int)CoinType.YEN1).ToString();
            txtOneAmount.Text      = logic.GetAmount((int)CoinType.YEN1).ToString();
            txtFive.Text           = logic.GetCount((int)CoinType.YEN5).ToString();
            txtFiveAmount.Text     = logic.GetAmount((int)CoinType.YEN5).ToString();
            txtTen.Text            = logic.GetCount((int)CoinType.YEN10).ToString();
            txtTenAmount.Text      = logic.GetAmount((int)CoinType.YEN10).ToString();
            txtFifty.Text          = logic.GetCount((int)CoinType.YEN50).ToString();
            txtFiftyAmount.Text    = logic.GetAmount((int)CoinType.YEN50).ToString();
            txtOneHundred.Text     = logic.GetCount((int)CoinType.YEN100).ToString();
            txtOneHundAmount.Text  = logic.GetAmount((int)CoinType.YEN100).ToString();
            txtFiveHundred.Text    = logic.GetCount((int)CoinType.YEN500).ToString();
            txtFiveHundAmount.Text = logic.GetAmount((int)CoinType.YEN500).ToString();

            txtAmount.Text = logic.GetAmount().ToString();
            txtTotalCount.Text = logic.GetCount().ToString();
        }
    }
}
