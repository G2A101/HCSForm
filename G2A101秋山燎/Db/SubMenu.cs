﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

/// <summary>
/// 「サブメニュー」のフォーム。
/// </summary>

namespace Db
{
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「会員登録」画面に画面遷移する。
        /// </summary>
        private void InsertClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //会員登録画面に画面遷移
            InsertForm f2 = new InsertForm();
            f2.Show();
        }

        /// <summary>
        /// 「会員検索」ボタンを押すと、会員検索画面に遷移する。
        /// </summary>
        private void SearchClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //会員検索画面に画面遷移
            SearchForm f2 = new SearchForm();
            f2.Show();
        }
       
        /// <summary>
        /// 「会員情報変更」ボタンを押すと、会員情報変更画面に画面遷移する。
        /// </summary>
        private void UpdateClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //会員情報変更画面に画面遷移
            UpdateForm f2 = new UpdateForm();
            f2.Show();
        }

        /// <summary>
        /// 「会員削除」ボタンを押すと、会員削除画面に画面遷移する。
        /// </summary>
        private void DeleteClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //会員削除画面に画面遷移
            DeleteForm f2 = new DeleteForm();
            f2.Show();
        }

        /// <summary>
        /// 「データ一覧」ボタンを押すと、データ一覧画面に画面遷移する。
        /// </summary>
        private void DataListClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //ホームCSに画面遷移
            DataList f2 = new DataList();
            f2.Show();
        }

        /// <summary>
        /// 「戻る」ボタンを押すと、メインメニュー画面に戻る。
        /// </summary>
        private void ReturnClick(object sender, EventArgs e)
        {
            //この画面を非表示にする。
            this.Visible = false;

            //メインメニュー画面に画面遷移。
            MainMenu f2 = new MainMenu();
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

        private void SubMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
