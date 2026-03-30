namespace _172_RegistryBoot
{
    partial class FormBoot
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
            this.btnButton = new System.Windows.Forms.Button();
            this.lBoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.AutoSize = true;
            this.btnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnButton.Location = new System.Drawing.Point(0, 0);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(282, 52);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "程序开机自动启动";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // lBoot
            // 
            this.lBoot.AutoSize = true;
            this.lBoot.Location = new System.Drawing.Point(12, 286);
            this.lBoot.Name = "lBoot";
            this.lBoot.Size = new System.Drawing.Size(82, 15);
            this.lBoot.TabIndex = 1;
            this.lBoot.Text = "开机未启动";
            // 
            // FormBoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 310);
            this.Controls.Add(this.lBoot);
            this.Controls.Add(this.btnButton);
            this.Name = "FormBoot";
            this.Text = "开机启动";
            this.Load += new System.EventHandler(this.FormBoot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Label lBoot;
    }
}

