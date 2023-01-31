
namespace Db
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.SubMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(300, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "メインメニュー";
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.ForeColor = System.Drawing.Color.Red;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndClick);
            // 
            // SubMenu
            // 
            this.SubMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.SubMenu.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubMenu.Location = new System.Drawing.Point(40, 150);
            this.SubMenu.Name = "SubMenu";
            this.SubMenu.Size = new System.Drawing.Size(350, 200);
            this.SubMenu.TabIndex = 2;
            this.SubMenu.Text = "会員情報管理";
            this.SubMenu.UseVisualStyleBackColor = false;
            this.SubMenu.Click += new System.EventHandler(this.SubMenuClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(175, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CreateTableButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreateTableButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateTableButton.Location = new System.Drawing.Point(480, 150);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(350, 200);
            this.CreateTableButton.TabIndex = 4;
            this.CreateTableButton.Text = "テーブル作成";
            this.CreateTableButton.UseVisualStyleBackColor = false;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubMenu);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button SubMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateTableButton;
    }
}