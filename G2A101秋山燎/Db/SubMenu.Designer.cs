
namespace Db
{
    partial class SubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DetaListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(280, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "会員登録管理";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label4.Location = new System.Drawing.Point(190, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Orange;
            this.InsertButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsertButton.Location = new System.Drawing.Point(33, 177);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(190, 105);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "会員登録";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertClick);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Orange;
            this.SearchButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchButton.Location = new System.Drawing.Point(243, 177);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(190, 105);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "会員検索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Orange;
            this.UpdateButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Location = new System.Drawing.Point(452, 177);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(190, 105);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "会員情報変更";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Orange;
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(663, 177);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(190, 105);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "会員削除";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteClick);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.EndButton.ForeColor = System.Drawing.Color.Red;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ReturnButton.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnButton.Location = new System.Drawing.Point(600, 390);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(130, 60);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClick);
            // 
            // DetaListButton
            // 
            this.DetaListButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.DetaListButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DetaListButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.DetaListButton.ForeColor = System.Drawing.Color.Yellow;
            this.DetaListButton.Location = new System.Drawing.Point(12, 361);
            this.DetaListButton.Name = "DetaListButton";
            this.DetaListButton.Size = new System.Drawing.Size(172, 80);
            this.DetaListButton.TabIndex = 8;
            this.DetaListButton.Text = "データ一覧";
            this.DetaListButton.UseVisualStyleBackColor = false;
            this.DetaListButton.Click += new System.EventHandler(this.DataListClick);
            // 
            // SubMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.DetaListButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SubMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button InsertButton;
        protected System.Windows.Forms.Button DetaListButton;
    }
}