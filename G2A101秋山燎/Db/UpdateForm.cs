using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「会員情報変更」のフォーム。
/// </summary>

namespace Db
{

    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「変更」ボタンを押すと、検索IDに一致したテ－ブル内のデータの情報を修正。
        /// </summary>
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    // インサート        //入力した検索IDのデータを修正。
                    cmd.CommandText = "UPDATE t_product set name = @Name, address = @Address, number = @Number WHERE ID = @Id;";
                    // パラメータセット
                    cmd.Parameters.Add("Id", System.Data.DbType.Int64);         //変更したい検索IDを入力。
                    cmd.Parameters.Add("Name", System.Data.DbType.String);      //変更したい名前を入力。
                    cmd.Parameters.Add("Address", System.Data.DbType.String);   //変更したい住所を入力。
                    cmd.Parameters.Add("Number", System.Data.DbType.String);    //変更したい電話番号を入力。
                    // データ修正
                    cmd.Parameters["Id"].Value = int.Parse(UpdateId.Text);    //:入力された検索ID
                    cmd.Parameters["Name"].Value = UpdateName.Text;           //:名前を変更。
                    cmd.Parameters["Address"].Value = UpdateAddress.Text;     //:住所を変更。
                    cmd.Parameters["Number"].Value = UpdateNumber.Text;       //:電話番号を変更。
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();

                    //メッセージボックスを表示する。
                    MessageBox.Show("変更が完了しました。",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                }
            }
        }

        /// <summary>
        /// 「戻る」ボタンを押すと、サブメニュー画面に画面遷移する。
        /// </summary>
        private void ReturnClick(object sender, EventArgs e)
        {
            //非表示にする。
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

    }
    
}