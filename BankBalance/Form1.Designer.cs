namespace BankBalance
{
    partial class Form1
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
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.lstOperationLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountInfo.Location = new System.Drawing.Point(33, 34);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(154, 29);
            this.lblAccountInfo.TabIndex = 0;
            this.lblAccountInfo.Text = "Placeholder";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(38, 215);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(237, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Gold;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Location = new System.Drawing.Point(38, 274);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(93, 38);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Red;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Location = new System.Drawing.Point(182, 274);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(93, 38);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowInfo.Location = new System.Drawing.Point(38, 353);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(125, 38);
            this.btnShowInfo.TabIndex = 4;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // lstOperationLog
            // 
            this.lstOperationLog.FormattingEnabled = true;
            this.lstOperationLog.ItemHeight = 20;
            this.lstOperationLog.Location = new System.Drawing.Point(418, 34);
            this.lstOperationLog.Name = "lstOperationLog";
            this.lstOperationLog.Size = new System.Drawing.Size(545, 364);
            this.lstOperationLog.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.lstOperationLog);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAccountInfo);
            this.Name = "Form1";
            this.Text = "BankBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.ListBox lstOperationLog;
    }
}

