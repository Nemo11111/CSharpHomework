namespace homework10
{
    partial class MainForm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListView();
            this.orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDetailId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.goodsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加订单";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(42, 199);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 67);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "删除订单";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(42, 344);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(135, 67);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "修改订单";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(42, 480);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 67);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询订单";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // orderList
            // 
            this.orderList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.orderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderId,
            this.customer,
            this.Amount,
            this.orderDetailId,
            this.phoneNum,
            this.goodsName,
            this.Value,
            this.quantity});
            this.orderList.HotTracking = true;
            this.orderList.HoverSelection = true;
            this.orderList.Location = new System.Drawing.Point(279, 60);
            this.orderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(907, 533);
            this.orderList.TabIndex = 4;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.orderList_SelectedIndexChanged);
            // 
            // orderId
            // 
            this.orderId.Text = "orderId";
            this.orderId.Width = 134;
            // 
            // customer
            // 
            this.customer.Text = "customer";
            this.customer.Width = 80;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 70;
            // 
            // orderDetailId
            // 
            this.orderDetailId.Text = "orderDetailId";
            this.orderDetailId.Width = 120;
            // 
            // phoneNum
            // 
            this.phoneNum.Text = "phoneNum";
            this.phoneNum.Width = 112;
            // 
            // goodsName
            // 
            this.goodsName.Text = "goodsName";
            this.goodsName.Width = 134;
            // 
            // Value
            // 
            this.Value.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.Text = "quantity";
            this.quantity.Width = 80;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 672);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm1";
            this.Text = "HandleServices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader orderDetailId;
        private System.Windows.Forms.ColumnHeader phoneNum;
        private System.Windows.Forms.ColumnHeader goodsName;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader quantity;
    }
}

