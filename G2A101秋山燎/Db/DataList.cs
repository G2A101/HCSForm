using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「データ一覧」のフォーム。
/// </summary>

namespace Db
{

    public partial class DataList : Form
    {
        public DataList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「テーブル作成」を押すと、新規のテーブルを作成。
        /// </summary>
        private void CreateClick(object sender, EventArgs e)
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
                }
                con.Close();
            }
        }

        /// <summary>
        /// 「データ追加」を押すと、テーブルにデータを追加。
        /// </summary>
        private void InsertClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=HCSform.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    // インサート挿入
                    cmd.CommandText = "INSERT INTO t_product (name, address, number) VALUES (@Name, @Address, @Number)";

                    // パラメータセット
                    cmd.Parameters.Add("Name", System.Data.DbType.String);       //名前をデータに入力。
                    cmd.Parameters.Add("Address", System.Data.DbType.String);    //住所をデータに入力。
                    cmd.Parameters.Add("Number", System.Data.DbType.String);　 　//電話番号をデータに入力。

                    // データ追加
                    cmd.Parameters["Name"].Value = InsertName.Text; 　 　     //:名前をデータに追加。
                    cmd.Parameters["Address"].Value = InsertAddress.Text; 　  //:住所をデータに追加。
                    cmd.Parameters["Number"].Value = InsertNumber.Text;　　   //:電話番号をデータに追加。
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
            }
        }


        /// <summary>
        /// 「データ読み込み」を押すとテーブルのデータを読み込む。
        /// </summary>
        private void LoadClick(object sender, EventArgs e)
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
        /// 「データ修正」ボタンを押すと、検索IDに一致したテ－ブル内のデータの情報を修正。
        /// </summary>
        private void UpdateClick(object sender, EventArgs e)
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
                }
            }
        }

        /// <summary>
        ///「データ削除」ボタンを押すと入力した検索IDのデータをテーブルから削除。
        /// </summary>
        private void DataDeleteClick(object sender, EventArgs e)
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
                    cmd.Parameters["Id"].Value = int.Parse(DataDeleteId.Text);      //:挿入した検索IDのデータをテーブルから削除。
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();
                }
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

    }
}