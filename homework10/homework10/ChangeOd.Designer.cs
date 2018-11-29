namespace homework10
{
    partial class FrmChangeOdMsg
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
            this.btnOK = new System.Windows.Forms.Button();
            this.labNums = new System.Windows.Forms.Label();
            this.txtNums = new System.Windows.Forms.TextBox();
            this.labGoods = new System.Windows.Forms.Label();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.labCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(125, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(270, 34);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labNums
            // 
            this.labNums.AutoSize = true;
            this.labNums.Location = new System.Drawing.Point(122, 146);
            this.labNums.Name = "labNums";
            this.labNums.Size = new System.Drawing.Size(69, 15);
            this.labNums.TabIndex = 12;
            this.labNums.Text = "数    量";
            // 
            // txtNums
            // 
            this.txtNums.Location = new System.Drawing.Point(238, 143);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(157, 25);
            this.txtNums.TabIndex = 11;
            // 
            // labGoods
            // 
            this.labGoods.AutoSize = true;
            this.labGoods.Location = new System.Drawing.Point(122, 102);
            this.labGoods.Name = "labGoods";
            this.labGoods.Size = new System.Drawing.Size(69, 15);
            this.labGoods.TabIndex = 10;
            this.labGoods.Text = "物    品";
            // 
            // txtGoods
            // 
            this.txtGoods.Location = new System.Drawing.Point(238, 99);
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(157, 25);
            this.txtGoods.TabIndex = 9;
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.Location = new System.Drawing.Point(122, 57);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(67, 15);
            this.labCustomer.TabIndex = 8;
            this.labCustomer.Text = "用户姓名";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(238, 54);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(157, 25);
            this.txtCustomer.TabIndex = 7;
            // 
            // FrmChangeOdMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 291);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labNums);
            this.Controls.Add(this.txtNums);
            this.Controls.Add(this.labGoods);
            this.Controls.Add(this.txtGoods);
            this.Controls.Add(this.labCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Name = "FrmChangeOdMsg";
            this.Text = "ChangeOd";
            this.Load += new System.EventHandler(this.FrmChangeOdMsg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labNums;
        private System.Windows.Forms.TextBox txtNums;
        private System.Windows.Forms.Label labGoods;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.Label labCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}