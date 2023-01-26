
namespace Db
{
    partial class EndForm
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(200, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "終了しますか？";
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Salmon;
            this.Yes.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.Yes.Location = new System.Drawing.Point(55, 210);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(320, 120);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "はい";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.YesClick);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.No.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.No.ForeColor = System.Drawing.SystemColors.InfoText;
            this.No.Location = new System.Drawing.Point(435, 210);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(320, 120);
            this.No.TabIndex = 2;
            this.No.Text = "いいえ";
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.NoClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.label2.Location = new System.Drawing.Point(140, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 84);
            this.label2.TabIndex = 12;
            this.label2.Text = "終了しますか？";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Name = "EndForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Label label2;
    }
}