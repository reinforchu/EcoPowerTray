namespace EcoPowerTray
{
    partial class NotifyIcon
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIcon));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1_Pref = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_HighPerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_Balanced = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_PwrSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1_License = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "EcoPowerTray";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1_Pref,
            this.toolStripMenuItem1_Info,
            this.toolStripMenuItem1_License,
            this.toolStripSeparator1,
            this.toolStripMenuItem1_HighPerformance,
            this.toolStripMenuItem1_Balanced,
            this.toolStripMenuItem1_PwrSaver,
            this.toolStripSeparator2,
            this.toolStripMenuItem1_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 170);
            // 
            // toolStripMenuItem1_Pref
            // 
            this.toolStripMenuItem1_Pref.Name = "toolStripMenuItem1_Pref";
            this.toolStripMenuItem1_Pref.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_Pref.Text = "設定 (&P)";
            // 
            // toolStripMenuItem1_HighPerformance
            // 
            this.toolStripMenuItem1_HighPerformance.Name = "toolStripMenuItem1_HighPerformance";
            this.toolStripMenuItem1_HighPerformance.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_HighPerformance.Text = "高パフォーマンス";
            // 
            // toolStripMenuItem1_Balanced
            // 
            this.toolStripMenuItem1_Balanced.Name = "toolStripMenuItem1_Balanced";
            this.toolStripMenuItem1_Balanced.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_Balanced.Text = "バランス";
            // 
            // toolStripMenuItem1_PwrSaver
            // 
            this.toolStripMenuItem1_PwrSaver.Name = "toolStripMenuItem1_PwrSaver";
            this.toolStripMenuItem1_PwrSaver.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_PwrSaver.Text = "省電力";
            // 
            // toolStripMenuItem1_Exit
            // 
            this.toolStripMenuItem1_Exit.Name = "toolStripMenuItem1_Exit";
            this.toolStripMenuItem1_Exit.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_Exit.Text = "終了 (&E)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // toolStripMenuItem1_Info
            // 
            this.toolStripMenuItem1_Info.Name = "toolStripMenuItem1_Info";
            this.toolStripMenuItem1_Info.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_Info.Text = "バージョン情報 (&I)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // toolStripMenuItem1_License
            // 
            this.toolStripMenuItem1_License.Name = "toolStripMenuItem1_License";
            this.toolStripMenuItem1_License.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem1_License.Text = "ライセンス (&L)";
            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Pref;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_HighPerformance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Balanced;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_PwrSaver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Info;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_License;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
