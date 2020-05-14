using Microsoft.Win32;
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
        public static readonly string VersionBody = "GNU General Public License version 3 (GPLv3)\nhttps://www.gnu.org/licenses/gpl-3.0.en.html\n\nEcoPowerTray Version 1.0.4.6\nhttps://github.com/reinforchu/EcoPowerTray\nCopyright (C) reinforchu";
        public static readonly string ExecMissingMessageJP = "動作に必要な 'powercfg.exe' が見つかりませんでした。\nアプリケーションを終了しますか？";

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
            toolStripMenuItem1_Exit.Click += toolStripMenuItem1_Exit_Click;
            notifyIcon1.Click += notifyIcon1_Click;
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
        /// Ivent listener: Power changed
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        void EventsListener_PowerChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.StatusChange:
                    PowerLineStatus pStatus = SystemInformation.PowerStatus.PowerLineStatus;
                    switch (pStatus)
                    {
                        case PowerLineStatus.Offline:
                            BalloonTip("EcoPowerTray", "バッテリーに切り替わりました。", 3500);
                            break;
                        case PowerLineStatus.Online:
                            BalloonTip("EcoPowerTray", "AC電源に接続されました。", 3500);
                            break;
                        case PowerLineStatus.Unknown:
                            BalloonTip("EcoPowerTray", "電源の状態を検出できませんでした。", 3500);
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Show about
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void toolStripMenuItem1_Info_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(VersionBody, "EcoPowerTray - Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Check power plan
        /// </summary>
        /// <param name="sender">sender event object</param>
        /// <param name="e">event data</param>
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            string r = cmd.rExecute("powercfg.exe -GETACTIVESCHEME");
            string[] guidArray = r.Split(' ');
            switch (guidArray[2])
            {
                case "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c":
                    toolStripMenuItem1_HighPerformance.Checked = true;
                    toolStripMenuItem1_Balanced.Checked = false;
                    toolStripMenuItem1_PowerSaver.Checked = false;
                    break;
                case "381b4222-f694-41f0-9685-ff5bb260df2e":
                    toolStripMenuItem1_HighPerformance.Checked = false;
                    toolStripMenuItem1_Balanced.Checked = true;
                    toolStripMenuItem1_PowerSaver.Checked = false;
                    break;
                case "a1841308-3541-4fab-bc81-f71556f20b4a":
                    toolStripMenuItem1_HighPerformance.Checked = false;
                    toolStripMenuItem1_Balanced.Checked = false;
                    toolStripMenuItem1_PowerSaver.Checked = true;
                    break;
                default:
                    toolStripMenuItem1_HighPerformance.Checked = false;
                    toolStripMenuItem1_Balanced.Checked = false;
                    toolStripMenuItem1_PowerSaver.Checked = false;
                    break;
            }
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
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;

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
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
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
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
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