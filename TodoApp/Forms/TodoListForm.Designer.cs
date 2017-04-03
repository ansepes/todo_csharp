namespace TodoApp.Forms
{
    partial class TodoListForm
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
            this.TodoGrid = new System.Windows.Forms.DataGridView();
            this.TodoTitleTxt = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TodoGrid
            // 
            this.TodoGrid.AllowUserToAddRows = false;
            this.TodoGrid.AllowUserToDeleteRows = false;
            this.TodoGrid.AllowUserToResizeRows = false;
            this.TodoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleCol,
            this.ButtonCol});
            this.TodoGrid.Location = new System.Drawing.Point(0, 39);
            this.TodoGrid.Name = "TodoGrid";
            this.TodoGrid.RowHeadersVisible = false;
            this.TodoGrid.RowTemplate.Height = 21;
            this.TodoGrid.Size = new System.Drawing.Size(302, 304);
            this.TodoGrid.TabIndex = 0;
            // 
            // TodoTitleTxt
            // 
            this.TodoTitleTxt.Location = new System.Drawing.Point(12, 12);
            this.TodoTitleTxt.Name = "TodoTitleTxt";
            this.TodoTitleTxt.Size = new System.Drawing.Size(198, 19);
            this.TodoTitleTxt.TabIndex = 1;
            this.TodoTitleTxt.Text = "WWWWWWWWWWWWWWWWWWWW";
            this.TodoTitleTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TodoTitleTxt_KeyDown);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(216, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TitleCol
            // 
            this.TitleCol.HeaderText = "Title";
            this.TitleCol.Name = "TitleCol";
            this.TitleCol.ReadOnly = true;
            this.TitleCol.Width = 230;
            // 
            // ButtonCol
            // 
            this.ButtonCol.HeaderText = "Change";
            this.ButtonCol.Name = "ButtonCol";
            this.ButtonCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ButtonCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ButtonCol.Width = 50;
            // 
            // TodoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 342);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TodoTitleTxt);
            this.Controls.Add(this.TodoGrid);
            this.Name = "TodoListForm";
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.TodoListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TodoGrid;
        private System.Windows.Forms.TextBox TodoTitleTxt;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonCol;
    }
}

