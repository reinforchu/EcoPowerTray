using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EcoPowerTray
{
    /// <summary>
    /// EcoPowerTray
    /// </summary>
    public partial class EPTApp : Component
    {
        private CmdExec cmd = new CmdExec();
        public static readonly string VersionBody = "EcoPowerTray Version 1.0.1.3\nCopyright (C) 2016 reinforchu\nrein@hack.vet\nhttps://github.com/reinforchu/EcoPowerTray";
        public static readonly string LicenseBodyJP = "EcoPowerTray は、GPLv3に基づき公開しています。\n\nGNU General Public License version 3 (GPLv3)\nhttps://www.gnu.org/licenses/gpl-3.0.en.html";
        public static readonly string ExecMissingMessageJP = "動作に必要な'powercfg.exe'が見つかりませんでした。\nアプリケーションを終了しますか？";

        /// <summary>
        /// Init EcoPowerTray and event handling
        /// </summary>
        public EPTApp()
        {
            //  Exists powercfg.exe
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\powercfg.exe") == true)
            {
                DialogResult result = System.Windows.Forms.MessageBox.Show(ExecMissingMessageJP, "EcoPowerTray - Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    System.Windows.Application.Current.Shutdown();
                }
            }
            InitializeComponent();
            toolStripMenuItem1_HighPerformance.Click += toolStripMenuItem1_HighPerformance_Click;
            toolStripMenuItem1_Balanced.Click += toolStripMenuItem1_Balanced_Click;
            toolStripMenuItem1_PowerSaver.Click += toolStripMenuItem1_PowerSaver_Click;
            toolStripMenuItem1_Info.Click += toolStripMenuItem1_Info_Click;
            toolStripMenuItem1_License.Click += toolStripMenuItem1_License_Click;
            toolStripMenuItem1_Exit.Click += toolStripMenuItem1_Exit_Click;
        }

        /// <summary>
        /// Initialize container
        /// </summary>
        /// <param name="container">container</param>
        public EPTApp(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        /// <summary>
        /// Show about
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_Info_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(VersionBody, "EcoPowerTray - About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Show software license information
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_License_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(LicenseBodyJP, "EcoPowerTray - License", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Switch HighPerformance
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_HighPerformance_Click(object sender, EventArgs e)
        {
            cmd.Execute("powercfg.exe -setactive SCHEME_MIN");
            BalloonTip("EcoPowerTray", "電源プランを高パフォーマンスに変更しました。", 3500);
        }

        /// <summary>
        /// Switch Balanced
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_Balanced_Click(object sender, EventArgs e)
        {
            cmd.Execute("powercfg.exe -setactive SCHEME_BALANCED");
            BalloonTip("EcoPowerTray", "電源プランをバランスに変更しました。", 3500);
        }

        /// <summary>
        /// Switch PowerSaver
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_PowerSaver_Click(object sender, EventArgs e)
        {
            cmd.Execute("powercfg.exe -setactive SCHEME_MAX");
            BalloonTip("EcoPowerTray", "電源プランを省電力に変更しました。", 3500);
        }

        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        /// <summary>
        /// BalloonTip
        /// </summary>
        /// <param name="title">Notification title</param>
        /// <param name="text">Notification body</param>
        /// <param name="msec">Notification time (msec)</param>
        private void BalloonTip(string title, string text, int msec)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(msec);
        }
    }
}