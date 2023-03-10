using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「会員情報検索」のフォーム。
/// </summary>

namespace Db
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「検索」ボタンを押すと、検索IDをもとに会員情報を検索する。
        /// </summary>
        private void SearchClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
            {
                // DataTableを生成します。
                var dataTable = new DataTable();
                // SQLの実行                               // 検索IDに一致した会員情報を検索する。
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE id = " + SearchId.Text, con);
                adapter.Fill(dataTable);
                MemberInformationDataGridView.DataSource = dataTable;

                //メッセージボックスを表示する。
                MessageBox.Show("会員情報を検索しました。",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// 「読み込み」を押すとテーブルのデータを読み込む。
        /// </summary>
        private void LoadButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
            {
                // テーブル内のデータを生成。
                DataTable dataTable = new DataTable();

                // SQLの実行、テーブル内のデータを読み込む。
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);

                // 「MemberInformationDataGridView」にデータを表示。
                MemberInformationDataGridView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// 「戻る」ボタンを押すと、サブメニュー画面に画面遷移する。
        /// </summary>
        private void ReturnClick(object sender, EventArgs e)
        {
            //画面を非表示にする。
            this.Visible = false;

            //サブメニュー画面に画面遷移
            SubMenu f2 = new SubMenu();
            f2.Show();
        }

        /// <summary>
        /// 「終了」ボタンを押すと、終了画面に遷移する。
        /// </summary>
        private void EndClick(object sender, EventArgs e)
        {

            //終了画面に画面遷移
            EndForm f2 = new EndForm();
            f2.Show();
        }

      
    }
}
