﻿namespace ECode
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNetCorePub = new System.Windows.Forms.ToolStripMenuItem();
            this.xamarinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeAndroidManifest = new System.Windows.Forms.ToolStripMenuItem();
            this.宇内流云ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToNative = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegexTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.xamarinToolStripMenuItem,
            this.宇内流云ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNetCorePub});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 21);
            this.toolStripMenuItem1.Text = "NetCore";
            // 
            // btnNetCorePub
            // 
            this.btnNetCorePub.Name = "btnNetCorePub";
            this.btnNetCorePub.Size = new System.Drawing.Size(124, 22);
            this.btnNetCorePub.Text = "发布工具";
            // 
            // xamarinToolStripMenuItem
            // 
            this.xamarinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeAndroidManifest});
            this.xamarinToolStripMenuItem.Name = "xamarinToolStripMenuItem";
            this.xamarinToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.xamarinToolStripMenuItem.Text = "Xamarin";
            // 
            // btnDeAndroidManifest
            // 
            this.btnDeAndroidManifest.Name = "btnDeAndroidManifest";
            this.btnDeAndroidManifest.Size = new System.Drawing.Size(213, 22);
            this.btnDeAndroidManifest.Text = "反编译 AndroidManifest";
            // 
            // 宇内流云ToolStripMenuItem
            // 
            this.宇内流云ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToNative});
            this.宇内流云ToolStripMenuItem.Name = "宇内流云ToolStripMenuItem";
            this.宇内流云ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宇内流云ToolStripMenuItem.Text = "宇内流云";
            // 
            // btnToNative
            // 
            this.btnToNative.Name = "btnToNative";
            this.btnToNative.Size = new System.Drawing.Size(154, 22);
            this.btnToNative.Text = "EXE ToNative";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegexTool});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其它";
            // 
            // btnRegexTool
            // 
            this.btnRegexTool.Name = "btnRegexTool";
            this.btnRegexTool.Size = new System.Drawing.Size(152, 22);
            this.btnRegexTool.Text = "正则测试工具";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 429);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "ECode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnNetCorePub;
        private System.Windows.Forms.ToolStripMenuItem xamarinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnDeAndroidManifest;
        private System.Windows.Forms.ToolStripMenuItem 宇内流云ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnToNative;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRegexTool;
    }
}

