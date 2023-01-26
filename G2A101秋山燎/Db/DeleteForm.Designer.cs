
namespace Db
{
    partial class DeleteForm
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.MemberInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label4.Location = new System.Drawing.Point(190, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(335, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "会員削除";
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoadButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LoadButton.ForeColor = System.Drawing.Color.Indigo;
            this.LoadButton.Location = new System.Drawing.Point(700, 250);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(130, 60);
            this.LoadButton.TabIndex = 27;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // MemberInformationDataGridView
            // 
            this.MemberInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInformationDataGridView.Location = new System.Drawing.Point(245, 230);
            this.MemberInformationDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberInformationDataGridView.Name = "MemberInformationDataGridView";
            this.MemberInformationDataGridView.RowHeadersWidth = 51;
            this.MemberInformationDataGridView.RowTemplate.Height = 29;
            this.MemberInformationDataGridView.Size = new System.Drawing.Size(396, 112);
            this.MemberInformationDataGridView.TabIndex = 26;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ReturnButton.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnButton.Location = new System.Drawing.Point(600, 390);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(130, 60);
            this.ReturnButton.TabIndex = 25;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(335, 360);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 80);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteClick);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.EndButton.ForeColor = System.Drawing.Color.DarkRed;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 23;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(240, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "検索ID";
            // 
            // DeleteId
            // 
            this.DeleteId.Location = new System.Drawing.Point(245, 190);
            this.DeleteId.Name = "DeleteId";
            this.DeleteId.Size = new System.Drawing.Size(396, 22);
            this.DeleteId.TabIndex = 21;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MemberInformationDataGridView);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "DeleteForm";
            this.Text = "sakuzyo";
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridView MemberInformationDataGridView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteId;
    }
}