namespace EcoPowerTray
{
    partial class EPTApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPTApp));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1_HighPerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_Balanced = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_PowerSaver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1_Exit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1_HighPerformance,
            this.toolStripMenuItem1_Balanced,
            this.toolStripMenuItem1_PowerSaver,
            this.toolStripSeparator1,
            this.toolStripMenuItem1_Info,
            this.toolStripMenuItem1_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 120);
            // 
            // toolStripMenuItem1_HighPerformance
            // 
            this.toolStripMenuItem1_HighPerformance.Name = "toolStripMenuItem1_HighPerformance";
            this.toolStripMenuItem1_HighPerformance.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1_HighPerformance.Text = "高パフォーマンス";
            // 
            // toolStripMenuItem1_Balanced
            // 
            this.toolStripMenuItem1_Balanced.Name = "toolStripMenuItem1_Balanced";
            this.toolStripMenuItem1_Balanced.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1_Balanced.Text = "バランス";
            // 
            // toolStripMenuItem1_PowerSaver
            // 
            this.toolStripMenuItem1_PowerSaver.Name = "toolStripMenuItem1_PowerSaver";
            this.toolStripMenuItem1_PowerSaver.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1_PowerSaver.Text = "省電力";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripMenuItem1_Info
            // 
            this.toolStripMenuItem1_Info.Name = "toolStripMenuItem1_Info";
            this.toolStripMenuItem1_Info.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1_Info.Text = "情報 (&I)";
            // 
            // toolStripMenuItem1_Exit
            // 
            this.toolStripMenuItem1_Exit.Name = "toolStripMenuItem1_Exit";
            this.toolStripMenuItem1_Exit.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem1_Exit.Text = "終了 (&E)";
            this.contextMenuStrip1.ResumeLayout(false);

            // Power change event
            Microsoft.Win32.SystemEvents.PowerModeChanged += new Microsoft.Win32.PowerModeChangedEventHandler(EventsListener_PowerChanged);
        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_HighPerformance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Balanced;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_PowerSaver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1_Info;
    }
}
