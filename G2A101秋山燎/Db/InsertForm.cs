using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「会員情報登録」のフォーム。
/// </summary>

namespace Db
{

    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「登録」ボタンを押すと、テーブルにデータを追加。
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
                    cmd.Parameters.Add("Number", System.Data.DbType.String);   //電話番号をデータに入力。

                    // データ追加
                    cmd.Parameters["Name"].Value = InsertName.Text;         //:名前をデータに追加。
                    cmd.Parameters["Address"].Value = InsertAddress.Text;    //:住所をデータに追加。
                    cmd.Parameters["Number"].Value = InsertNumber.Text;     //:電話番号をデータに追加。
                    cmd.ExecuteNonQuery();
                    // コミット
                    trans.Commit();

                    //メッセージボックスを表示する。
                    MessageBox.Show("登録が完了しました。",
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
        /// 「終了」ボタンを押すと、終了画面に遷移する。
        /// </summary>
        private void EndButtonClick(object sender, EventArgs e)
        {
            //終了画面に画面遷移
            EndForm f2 = new EndForm();
            f2.Show();
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

    }
}