using System;
using System.Windows.Forms;

/// <summary>
/// 「データベース終了」のフォーム。
/// </summary>

namespace Db
{
   
    public partial class EndForm  : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「はい」を押すと、このデータベースを終了する。
        /// </summary>
        private void YesClick(object sender, EventArgs e)
        {
            //データベースの終了。
            Application.Exit();
        }

        /// <summary>
        /// 「いいえ」を押すと、データベースを終了せずに終了画面を閉じる。
        /// </summary>
        private void NoClick(object sender, EventArgs e)
        {
            //前に開いていた画面に戻る。
            this.Close();
        }

    }
}
