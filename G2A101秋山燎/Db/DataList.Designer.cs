
namespace Db
{
    partial class DataList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.InsertName = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.Label();
            this.InsertAddress = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Id2 = new System.Windows.Forms.Label();
            this.DataDeleteId = new System.Windows.Forms.TextBox();
            this.DataDeleteButton = new System.Windows.Forms.Button();
            this.InsertNumber = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.UpdateId = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.Label();
            this.UpdateNumber = new System.Windows.Forms.TextBox();
            this.Address2 = new System.Windows.Forms.Label();
            this.UpdateAddress = new System.Windows.Forms.TextBox();
            this.Name2 = new System.Windows.Forms.Label();
            this.UpdateName = new System.Windows.Forms.TextBox();
            this.MemberInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Gold;
            this.CreateButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreateButton.Location = new System.Drawing.Point(12, 27);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(170, 60);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "テーブル作成";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateClick);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Gold;
            this.InsertButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InsertButton.Location = new System.Drawing.Point(198, 27);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(170, 60);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "データ追加";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertClick);
            // 
            // InsertName
            // 
            this.InsertName.Location = new System.Drawing.Point(393, 47);
            this.InsertName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertName.Name = "InsertName";
            this.InsertName.Size = new System.Drawing.Size(131, 22);
            this.InsertName.TabIndex = 2;
            this.InsertName.Text = "Name";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(393, 29);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(37, 15);
            this.Name1.TabIndex = 3;
            this.Name1.Text = "名前";
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Location = new System.Drawing.Point(556, 29);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(37, 15);
            this.Address1.TabIndex = 5;
            this.Address1.Text = "住所";
            // 
            // InsertAddress
            // 
            this.InsertAddress.Location = new System.Drawing.Point(559, 47);
            this.InsertAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertAddress.Name = "InsertAddress";
            this.InsertAddress.Size = new System.Drawing.Size(125, 22);
            this.InsertAddress.TabIndex = 4;
            this.InsertAddress.Text = "0";
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Gold;
            this.LoadButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoadButton.Location = new System.Drawing.Point(198, 112);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(170, 60);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "データ読み込み";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Gold;
            this.UpdateButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpdateButton.Location = new System.Drawing.Point(198, 286);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(170, 60);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "データ修正";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateClick);
            // 
            // Id2
            // 
            this.Id2.AutoSize = true;
            this.Id2.Location = new System.Drawing.Point(393, 401);
            this.Id2.Name = "Id2";
            this.Id2.Size = new System.Drawing.Size(51, 15);
            this.Id2.TabIndex = 17;
            this.Id2.Text = "検索ID";
            // 
            // DataDeleteId
            // 
            this.DataDeleteId.Location = new System.Drawing.Point(393, 418);
            this.DataDeleteId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataDeleteId.Name = "DataDeleteId";
            this.DataDeleteId.Size = new System.Drawing.Size(171, 22);
            this.DataDeleteId.TabIndex = 16;
            this.DataDeleteId.Text = "1";
            // 
            // DataDeleteButton
            // 
            this.DataDeleteButton.BackColor = System.Drawing.Color.Gold;
            this.DataDeleteButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DataDeleteButton.Location = new System.Drawing.Point(198, 378);
            this.DataDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataDeleteButton.Name = "DataDeleteButton";
            this.DataDeleteButton.Size = new System.Drawing.Size(170, 60);
            this.DataDeleteButton.TabIndex = 15;
            this.DataDeleteButton.Text = "データ削除";
            this.DataDeleteButton.UseVisualStyleBackColor = false;
            this.DataDeleteButton.Click += new System.EventHandler(this.DataDeleteClick);
            // 
            // InsertNumber
            // 
            this.InsertNumber.Location = new System.Drawing.Point(730, 47);
            this.InsertNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertNumber.Name = "InsertNumber";
            this.InsertNumber.Size = new System.Drawing.Size(125, 22);
            this.InsertNumber.TabIndex = 19;
            this.InsertNumber.Text = "0";
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(727, 29);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(67, 15);
            this.Number1.TabIndex = 20;
            this.Number1.Text = "電話番号";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(393, 269);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(51, 15);
            this.Id.TabIndex = 34;
            this.Id.Text = "検索ID";
            // 
            // UpdateId
            // 
            this.UpdateId.Location = new System.Drawing.Point(393, 286);
            this.UpdateId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateId.Name = "UpdateId";
            this.UpdateId.Size = new System.Drawing.Size(171, 22);
            this.UpdateId.TabIndex = 33;
            this.UpdateId.Text = "1";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(727, 319);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(67, 15);
            this.Number2.TabIndex = 40;
            this.Number2.Text = "電話番号";
            // 
            // UpdateNumber
            // 
            this.UpdateNumber.Location = new System.Drawing.Point(730, 337);
            this.UpdateNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateNumber.Name = "UpdateNumber";
            this.UpdateNumber.Size = new System.Drawing.Size(125, 22);
            this.UpdateNumber.TabIndex = 39;
            this.UpdateNumber.Text = "0";
            // 
            // Address2
            // 
            this.Address2.AutoSize = true;
            this.Address2.Location = new System.Drawing.Point(556, 319);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(37, 15);
            this.Address2.TabIndex = 38;
            this.Address2.Text = "住所";
            // 
            // UpdateAddress
            // 
            this.UpdateAddress.Location = new System.Drawing.Point(559, 337);
            this.UpdateAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateAddress.Name = "UpdateAddress";
            this.UpdateAddress.Size = new System.Drawing.Size(125, 22);
            this.UpdateAddress.TabIndex = 37;
            this.UpdateAddress.Text = "0";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Location = new System.Drawing.Point(393, 319);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(37, 15);
            this.Name2.TabIndex = 36;
            this.Name2.Text = "名前";
            // 
            // UpdateName
            // 
            this.UpdateName.Location = new System.Drawing.Point(393, 337);
            this.UpdateName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateName.Name = "UpdateName";
            this.UpdateName.Size = new System.Drawing.Size(131, 22);
            this.UpdateName.TabIndex = 35;
            this.UpdateName.Text = "Name";
            // 
            // MemberInformationDataGridView
            // 
            this.MemberInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberInformationDataGridView.Location = new System.Drawing.Point(396, 103);
            this.MemberInformationDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberInformationDataGridView.Name = "MemberInformationDataGridView";
            this.MemberInformationDataGridView.RowHeadersWidth = 51;
            this.MemberInformationDataGridView.RowTemplate.Height = 29;
            this.MemberInformationDataGridView.Size = new System.Drawing.Size(462, 164);
            this.MemberInformationDataGridView.TabIndex = 6;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReturnButton.Font = new System.Drawing.Font("ＭＳ 明朝", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReturnButton.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnButton.Location = new System.Drawing.Point(750, 390);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(130, 60);
            this.ReturnButton.TabIndex = 41;
            this.ReturnButton.Text = "戻る";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnClick);
            // 
            // DataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.UpdateNumber);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.UpdateAddress);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.UpdateName);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.UpdateId);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.InsertNumber);
            this.Controls.Add(this.Id2);
            this.Controls.Add(this.DataDeleteId);
            this.Controls.Add(this.DataDeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MemberInformationDataGridView);
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.InsertAddress);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.InsertName);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataList";
            this.Text = "DataList";
            ((System.ComponentModel.ISupportInitialize)(this.MemberInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox InsertName;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.TextBox InsertAddress;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Id2;
        private System.Windows.Forms.TextBox DataDeleteId;
        private System.Windows.Forms.Button DataDeleteButton;
        private System.Windows.Forms.TextBox InsertNumber;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox UpdateId;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.TextBox UpdateNumber;
        private System.Windows.Forms.Label Address2;
        private System.Windows.Forms.TextBox UpdateAddress;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.TextBox UpdateName;
        private System.Windows.Forms.DataGridView MemberInformationDataGridView;
        private System.Windows.Forms.Button ReturnButton;
    }
}

