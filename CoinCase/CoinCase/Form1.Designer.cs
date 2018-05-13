namespace CoinCase
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCoin = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtFive = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtFifty = new System.Windows.Forms.TextBox();
            this.txtOneHundred = new System.Windows.Forms.TextBox();
            this.txtFiveHundred = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblFifty = new System.Windows.Forms.Label();
            this.lblOneHundred = new System.Windows.Forms.Label();
            this.lblFiveHundred = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtOneAmount = new System.Windows.Forms.TextBox();
            this.txtFiveAmount = new System.Windows.Forms.TextBox();
            this.txtTenAmount = new System.Windows.Forms.TextBox();
            this.txtFiveHundAmount = new System.Windows.Forms.TextBox();
            this.txtOneHundAmount = new System.Windows.Forms.TextBox();
            this.txtFiftyAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCoin
            // 
            this.cmbCoin.FormattingEnabled = true;
            this.cmbCoin.Items.AddRange(new object[] {
            "1円",
            "5円",
            "10円",
            "50円",
            "100円",
            "500円"});
            this.cmbCoin.Location = new System.Drawing.Point(35, 56);
            this.cmbCoin.Name = "cmbCoin";
            this.cmbCoin.Size = new System.Drawing.Size(121, 23);
            this.cmbCoin.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "お金を追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(35, 149);
            this.txtOne.Name = "txtOne";
            this.txtOne.ReadOnly = true;
            this.txtOne.Size = new System.Drawing.Size(55, 22);
            this.txtOne.TabIndex = 2;
            // 
            // txtFive
            // 
            this.txtFive.Location = new System.Drawing.Point(163, 149);
            this.txtFive.Name = "txtFive";
            this.txtFive.ReadOnly = true;
            this.txtFive.Size = new System.Drawing.Size(53, 22);
            this.txtFive.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(297, 149);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(54, 22);
            this.txtTen.TabIndex = 4;
            // 
            // txtFifty
            // 
            this.txtFifty.Location = new System.Drawing.Point(35, 219);
            this.txtFifty.Name = "txtFifty";
            this.txtFifty.ReadOnly = true;
            this.txtFifty.Size = new System.Drawing.Size(55, 22);
            this.txtFifty.TabIndex = 5;
            // 
            // txtOneHundred
            // 
            this.txtOneHundred.Location = new System.Drawing.Point(163, 219);
            this.txtOneHundred.Name = "txtOneHundred";
            this.txtOneHundred.ReadOnly = true;
            this.txtOneHundred.Size = new System.Drawing.Size(53, 22);
            this.txtOneHundred.TabIndex = 6;
            // 
            // txtFiveHundred
            // 
            this.txtFiveHundred.Location = new System.Drawing.Point(297, 219);
            this.txtFiveHundred.Name = "txtFiveHundred";
            this.txtFiveHundred.ReadOnly = true;
            this.txtFiveHundred.Size = new System.Drawing.Size(54, 22);
            this.txtFiveHundred.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(32, 116);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(30, 15);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "1円";
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Location = new System.Drawing.Point(160, 116);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(30, 15);
            this.lblFive.TabIndex = 9;
            this.lblFive.Text = "5円";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(294, 116);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(38, 15);
            this.lblTen.TabIndex = 10;
            this.lblTen.Text = "10円";
            // 
            // lblFifty
            // 
            this.lblFifty.AutoSize = true;
            this.lblFifty.Location = new System.Drawing.Point(32, 188);
            this.lblFifty.Name = "lblFifty";
            this.lblFifty.Size = new System.Drawing.Size(38, 15);
            this.lblFifty.TabIndex = 11;
            this.lblFifty.Text = "50円";
            // 
            // lblOneHundred
            // 
            this.lblOneHundred.AutoSize = true;
            this.lblOneHundred.Location = new System.Drawing.Point(160, 188);
            this.lblOneHundred.Name = "lblOneHundred";
            this.lblOneHundred.Size = new System.Drawing.Size(46, 15);
            this.lblOneHundred.TabIndex = 12;
            this.lblOneHundred.Text = "100円";
            // 
            // lblFiveHundred
            // 
            this.lblFiveHundred.AutoSize = true;
            this.lblFiveHundred.Location = new System.Drawing.Point(294, 188);
            this.lblFiveHundred.Name = "lblFiveHundred";
            this.lblFiveHundred.Size = new System.Drawing.Size(46, 15);
            this.lblFiveHundred.TabIndex = 13;
            this.lblFiveHundred.Text = "500円";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(462, 219);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 14;
            // 
            // txtOneAmount
            // 
            this.txtOneAmount.Location = new System.Drawing.Point(96, 149);
            this.txtOneAmount.Name = "txtOneAmount";
            this.txtOneAmount.ReadOnly = true;
            this.txtOneAmount.Size = new System.Drawing.Size(55, 22);
            this.txtOneAmount.TabIndex = 15;
            // 
            // txtFiveAmount
            // 
            this.txtFiveAmount.Location = new System.Drawing.Point(222, 149);
            this.txtFiveAmount.Name = "txtFiveAmount";
            this.txtFiveAmount.ReadOnly = true;
            this.txtFiveAmount.Size = new System.Drawing.Size(55, 22);
            this.txtFiveAmount.TabIndex = 16;
            // 
            // txtTenAmount
            // 
            this.txtTenAmount.Location = new System.Drawing.Point(357, 149);
            this.txtTenAmount.Name = "txtTenAmount";
            this.txtTenAmount.ReadOnly = true;
            this.txtTenAmount.Size = new System.Drawing.Size(55, 22);
            this.txtTenAmount.TabIndex = 17;
            // 
            // txtFiveHundAmount
            // 
            this.txtFiveHundAmount.Location = new System.Drawing.Point(357, 219);
            this.txtFiveHundAmount.Name = "txtFiveHundAmount";
            this.txtFiveHundAmount.ReadOnly = true;
            this.txtFiveHundAmount.Size = new System.Drawing.Size(55, 22);
            this.txtFiveHundAmount.TabIndex = 18;
            // 
            // txtOneHundAmount
            // 
            this.txtOneHundAmount.Location = new System.Drawing.Point(222, 219);
            this.txtOneHundAmount.Name = "txtOneHundAmount";
            this.txtOneHundAmount.ReadOnly = true;
            this.txtOneHundAmount.Size = new System.Drawing.Size(55, 22);
            this.txtOneHundAmount.TabIndex = 19;
            // 
            // txtFiftyAmount
            // 
            this.txtFiftyAmount.Location = new System.Drawing.Point(96, 219);
            this.txtFiftyAmount.Name = "txtFiftyAmount";
            this.txtFiftyAmount.ReadOnly = true;
            this.txtFiftyAmount.Size = new System.Drawing.Size(55, 22);
            this.txtFiftyAmount.TabIndex = 20;
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.Location = new System.Drawing.Point(462, 188);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.ReadOnly = true;
            this.txtTotalCount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCount.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 331);
            this.Controls.Add(this.txtTotalCount);
            this.Controls.Add(this.txtFiftyAmount);
            this.Controls.Add(this.txtOneHundAmount);
            this.Controls.Add(this.txtFiveHundAmount);
            this.Controls.Add(this.txtTenAmount);
            this.Controls.Add(this.txtFiveAmount);
            this.Controls.Add(this.txtOneAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblFiveHundred);
            this.Controls.Add(this.lblOneHundred);
            this.Controls.Add(this.lblFifty);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblFive);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtFiveHundred);
            this.Controls.Add(this.txtOneHundred);
            this.Controls.Add(this.txtFifty);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtFive);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCoin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtFive;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtFifty;
        private System.Windows.Forms.TextBox txtOneHundred;
        private System.Windows.Forms.TextBox txtFiveHundred;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblFifty;
        private System.Windows.Forms.Label lblOneHundred;
        private System.Windows.Forms.Label lblFiveHundred;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtOneAmount;
        private System.Windows.Forms.TextBox txtFiveAmount;
        private System.Windows.Forms.TextBox txtTenAmount;
        private System.Windows.Forms.TextBox txtFiveHundAmount;
        private System.Windows.Forms.TextBox txtOneHundAmount;
        private System.Windows.Forms.TextBox txtFiftyAmount;
        private System.Windows.Forms.TextBox txtTotalCount;
    }
}

