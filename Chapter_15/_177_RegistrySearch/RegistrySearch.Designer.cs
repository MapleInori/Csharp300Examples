namespace _177_RegistrySearch
{
    partial class FormSearch
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
            this.tBKeywords = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.lBSearchResult = new System.Windows.Forms.ListBox();
            this.sSSearch = new System.Windows.Forms.StatusStrip();
            this.tSSLSeatching = new System.Windows.Forms.ToolStripStatusLabel();
            this.bWSearch = new System.ComponentModel.BackgroundWorker();
            this.sSSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBKeywords
            // 
            this.tBKeywords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tBKeywords.Location = new System.Drawing.Point(12, 12);
            this.tBKeywords.Name = "tBKeywords";
            this.tBKeywords.Size = new System.Drawing.Size(448, 30);
            this.tBKeywords.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bSearch.Location = new System.Drawing.Point(12, 46);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(448, 37);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "搜索";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // lBSearchResult
            // 
            this.lBSearchResult.FormattingEnabled = true;
            this.lBSearchResult.ItemHeight = 15;
            this.lBSearchResult.Location = new System.Drawing.Point(12, 89);
            this.lBSearchResult.Name = "lBSearchResult";
            this.lBSearchResult.Size = new System.Drawing.Size(448, 364);
            this.lBSearchResult.TabIndex = 2;
            // 
            // sSSearch
            // 
            this.sSSearch.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sSSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLSeatching});
            this.sSSearch.Location = new System.Drawing.Point(0, 467);
            this.sSSearch.Name = "sSSearch";
            this.sSSearch.Size = new System.Drawing.Size(472, 26);
            this.sSSearch.TabIndex = 3;
            this.sSSearch.Text = "statusStrip1";
            // 
            // tSSLSeatching
            // 
            this.tSSLSeatching.Name = "tSSLSeatching";
            this.tSSLSeatching.Size = new System.Drawing.Size(167, 20);
            this.tSSLSeatching.Text = "toolStripStatusLabel1";
            // 
            // bWSearch
            // 
            this.bWSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWSearch_DoWork);
            this.bWSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSearch_RunWorkerCompleted);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 493);
            this.Controls.Add(this.sSSearch);
            this.Controls.Add(this.lBSearchResult);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tBKeywords);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.sSSearch.ResumeLayout(false);
            this.sSSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBKeywords;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ListBox lBSearchResult;
        private System.Windows.Forms.StatusStrip sSSearch;
        private System.ComponentModel.BackgroundWorker bWSearch;
        private System.Windows.Forms.ToolStripStatusLabel tSSLSeatching;
    }
}

