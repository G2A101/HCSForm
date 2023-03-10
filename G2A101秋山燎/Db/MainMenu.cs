using System;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「メインメニュー」のフォーム。
/// </summary>

namespace Db
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「会員情報管理」ボタンを押すと、サブメニュー画面に遷移する。
        /// </summary>
        private void SubMenuClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //サブメニューに画面遷移
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

        /// <summary>
        /// 「テーブル作成」を押すと、新規のテーブルを作成。
        /// </summary>
        private void CreateTableClick(object sender, EventArgs e)
        {
                // コネクションを開いてテーブル作成して閉じる  　　　　　　　　　↓これがテーブル名（HCSform.db）
                using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            // name = 名前　address = 住所　number = 電話番号
                            "CREATE TABLE t_product(id INTEGER  PRIMARY KEY AUTOINCREMENT,  name TEXT, address TEXT, number TEXT)";
                        command.ExecuteNonQuery();

                    //メッセージボックスを表示する。
                    MessageBox.Show("テーブルを作成しました。",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
                    con.Close();
                }
            
        }
    }
}
