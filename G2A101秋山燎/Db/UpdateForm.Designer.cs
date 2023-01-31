
namespace Db
{
    partial class UpdateForm
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
            this.MemberInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.UpdateNumber = new System.Windows.Forms.TextBox();
            this.UpdateAddress = new System.Windows.Forms.TextBox();
            this.UpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateId = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(280, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "会員情報変更";
            // 
            // MemberInformationDataGridView
            // 
            this.MemberInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInformationDataGridView.Location = new System.Drawing.Point(490, 160);
            this.MemberInformationDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberInformationDataGridView.Name = "MemberInformationDataGridView";
            this.MemberInformationDataGridView.RowHeadersWidth = 51;
            this.MemberInformationDataGridView.RowTemplate.Height = 29;
            this.MemberInformationDataGridView.Size = new System.Drawing.Size(380, 170);
            this.MemberInformationDataGridView.TabIndex = 30;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReturnButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReturnButton.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnButton.Location = new System.Drawing.Point(600, 390);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(130, 60);
            this.ReturnButton.TabIndex = 29;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.UpdateButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(40, 370);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(200, 80);
            this.UpdateButton.TabIndex = 28;
            this.UpdateButton.Text = "変更";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label5.Location = new System.Drawing.Point(40, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "電話番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(40, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "住所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(40, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "名前";
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndButton.ForeColor = System.Drawing.Color.Red;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 24;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
            // 
            // UpdateNumber
            // 
            this.UpdateNumber.Location = new System.Drawing.Point(45, 330);
            this.UpdateNumber.Name = "UpdateNumber";
            this.UpdateNumber.Size = new System.Drawing.Size(396, 22);
            this.UpdateNumber.TabIndex = 23;
            // 
            // UpdateAddress
            // 
            this.UpdateAddress.Location = new System.Drawing.Point(45, 266);
            this.UpdateAddress.Name = "UpdateAddress";
            this.UpdateAddress.Size = new System.Drawing.Size(396, 22);
            this.UpdateAddress.TabIndex = 22;
            // 
            // UpdateName
            // 
            this.UpdateName.Location = new System.Drawing.Point(45, 202);
            this.UpdateName.Name = "UpdateName";
            this.UpdateName.Size = new System.Drawing.Size(396, 22);
            this.UpdateName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 34);
            this.label6.TabIndex = 32;
            this.label6.Text = "検索ID";
            // 
            // UpdateId
            // 
            this.UpdateId.Location = new System.Drawing.Point(45, 140);
            this.UpdateId.Name = "UpdateId";
            this.UpdateId.Size = new System.Drawing.Size(396, 22);
            this.UpdateId.TabIndex = 31;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoadButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoadButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LoadButton.Location = new System.Drawing.Point(315, 390);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(130, 60);
            this.LoadButton.TabIndex = 33;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label7.Location = new System.Drawing.Point(40, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 34);
            this.label7.TabIndex = 34;
            this.label7.Text = "名前";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UpdateId);
            this.Controls.Add(this.MemberInformationDataGridView);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.UpdateNumber);
            this.Controls.Add(this.UpdateAddress);
            this.Controls.Add(this.UpdateName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MemberInformationDataGridView;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox UpdateNumber;
        private System.Windows.Forms.TextBox UpdateAddress;
        private System.Windows.Forms.TextBox UpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UpdateId;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label label7;
    }
}