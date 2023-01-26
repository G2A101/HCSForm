
namespace Db
{
    partial class InsertForm
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
            this.InsertName = new System.Windows.Forms.TextBox();
            this.InsertAddress = new System.Windows.Forms.TextBox();
            this.InsertNumber = new System.Windows.Forms.TextBox();
            this.EndButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.MemberInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
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
            this.label4.TabIndex = 3;
            this.label4.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(325, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "会員登録";
            // 
            // InsertName
            // 
            this.InsertName.Location = new System.Drawing.Point(50, 160);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(396, 22);
            this.InsertName.TabIndex = 4;
            // 
            // InsertAddress
            // 
            this.InsertAddress.Location = new System.Drawing.Point(50, 230);
            this.InsertAddress.Name = "InsertAddress";
            this.InsertAddress.Size = new System.Drawing.Size(396, 22);
            this.InsertAddress.TabIndex = 6;
            // 
            // InsertNumber
            // 
            this.InsertNumber.Location = new System.Drawing.Point(50, 310);
            this.InsertNumber.Name = "InsertNumber";
            this.InsertNumber.Size = new System.Drawing.Size(396, 22);
            this.InsertNumber.TabIndex = 8;
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EndButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.EndButton.ForeColor = System.Drawing.Color.DarkRed;
            this.EndButton.Location = new System.Drawing.Point(750, 390);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(130, 60);
            this.EndButton.TabIndex = 10;
            this.EndButton.Text = "終了";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "住所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label5.Location = new System.Drawing.Point(45, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "電話番号";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.InsertButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.InsertButton.ForeColor = System.Drawing.Color.Black;
            this.InsertButton.Location = new System.Drawing.Point(50, 365);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(200, 80);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "登録";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertClick);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ReturnButton.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnButton.Location = new System.Drawing.Point(600, 390);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(130, 60);
            this.ReturnButton.TabIndex = 15;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClick);
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
            this.MemberInformationDataGridView.TabIndex = 20;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoadButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LoadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadButton.Location = new System.Drawing.Point(310, 390);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(130, 60);
            this.LoadButton.TabIndex = 34;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MemberInformationDataGridView);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.InsertNumber);
            this.Controls.Add(this.InsertAddress);
            this.Controls.Add(this.InsertName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "InsertForm";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InsertName;
        private System.Windows.Forms.TextBox InsertAddress;
        private System.Windows.Forms.TextBox InsertNumber;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.DataGridView MemberInformationDataGridView;
        private System.Windows.Forms.Button LoadButton;
    }
}