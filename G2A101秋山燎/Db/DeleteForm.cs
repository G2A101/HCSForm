using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「会員情報削除」のフォーム。
/// </summary>

namespace Db
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///「削除」ボタンを押すと入力した検索IDのデータをテーブルから削除。
        /// </summary>
        private void DeleteClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート        //入力した検索IDのデータを削除。     
                    cmd.CommandText = "DELETE FROM t_product WHERE ID = @Id;";
                    // パラメータセット
                    cmd.Parameters.Add("Id", System.Data.DbType.String);            //検索IDを挿入。
                                                                                    // データ削除
                    cmd.Parameters["Id"].Value = int.Parse(DeleteId.Text);      //:挿入した検索IDのデータをテーブルから削除。
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();

                    //メッセージボックスを表示する。
                    MessageBox.Show("削除が完了しました。",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
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
            //この画面を非表示にする。
            this.Visible = false;

            //サブメニュー画面に画面遷移。
            SubMenu f2 = new SubMenu();
            f2.Show();
        }

        /// <summary>
        /// 「終了」ボタンを押すと、終了画面に遷移する。
        /// </summary>
        private void EndButtonClick(object sender, EventArgs e)
        {
            //終了画面に画面遷移
            EndForm f2 = new EndForm();
            f2.Show();
        }

    }
}
