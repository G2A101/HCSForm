
namespace Db
{
    partial class SearchForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchId = new System.Windows.Forms.TextBox();
            this.Modoru = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.MemberInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(175, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(576, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(335, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "会員検索";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(240, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "検索ID";
            // 
            // SearchId
            // 
            this.SearchId.Location = new System.Drawing.Point(245, 180);
            this.SearchId.Name = "SearchId";
            this.SearchId.Size = new System.Drawing.Size(400, 22);
            this.SearchId.TabIndex = 12;
            // 
            // Modoru
            // 
            this.Modoru.BackColor = System.Drawing.Color.DarkCyan;
            this.Modoru.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Modoru.ForeColor = System.Drawing.Color.Indigo;
            this.Modoru.Location = new System.Drawing.Point(600, 390);
            this.Modoru.Name = "Modoru";
            this.Modoru.Size = new System.Drawing.Size(130, 60);
            this.Modoru.TabIndex = 18;
            this.Modoru.Text = "戻る";
            this.Modoru.UseVisualStyleBackColor = false;
            this.Modoru.Click += new System.EventHandler(this.ReturnClick);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SearchButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchButton.ForeColor = System.Drawing.Color.Black;
            this.SearchButton.Location = new System.Drawing.Point(345, 370);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 80);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchClick);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.ForeColor = System.Drawing.Color.Red;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 16;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndClick);
            // 
            // MemberInformationDataGridView
            // 
            this.MemberInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInformationDataGridView.Location = new System.Drawing.Point(245, 225);
            this.MemberInformationDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberInformationDataGridView.Name = "MemberInformationDataGridView";
            this.MemberInformationDataGridView.RowHeadersWidth = 51;
            this.MemberInformationDataGridView.RowTemplate.Height = 29;
            this.MemberInformationDataGridView.Size = new System.Drawing.Size(400, 130);
            this.MemberInformationDataGridView.TabIndex = 19;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoadButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoadButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LoadButton.Location = new System.Drawing.Point(675, 250);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(130, 60);
            this.LoadButton.TabIndex = 20;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MemberInformationDataGridView);
            this.Controls.Add(this.Modoru);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchId;
        private System.Windows.Forms.Button Modoru;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.DataGridView MemberInformationDataGridView;
        private System.Windows.Forms.Button LoadButton;
    }
}