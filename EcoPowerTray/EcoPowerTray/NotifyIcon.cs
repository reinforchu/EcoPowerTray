using System;
using System.ComponentModel;
using System.Windows;

namespace EcoPowerTray
{
    /// <summary>
    /// EcoPowerTray
    /// </summary>
    public partial class NotifyIcon : Component
    {
        private CmdExec exe = new CmdExec();

        /// <summary>
        /// NotifyIcon クラスの初期化およびイベントハンドリング
        /// </summary>
        public NotifyIcon()
        {
            InitializeComponent();
            toolStripMenuItem1_Pref.Click += toolStripMenuItem1_Pref_Click;
            toolStripMenuItem1_Info.Click += toolStripMenuItem1_Info_Click;
            toolStripMenuItem1_License.Click += toolStripMenuItem1_License_Click;
            toolStripMenuItem1_HighPerformance.Click += toolStripMenuItem1_HighPerformance_Click;
            toolStripMenuItem1_Balanced.Click += toolStripMenuItem1_Balanced_Click;
            toolStripMenuItem1_PwrSaver.Click += toolStripMenuItem1_PwrSaver_Click;
            toolStripMenuItem1_Exit.Click += toolStripMenuItem1_Exit_Click;
        }

        /// <summary>
        /// コンテナの初期化
        /// </summary>
        /// <param name="container">コンテナ</param>
        public NotifyIcon(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_Pref_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        /// <summary>
        /// バージョン情報
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_Info_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("EcoPowerTray Version 1.0.0.2\nCopyright (C) 2016 reinforchu\nrein@hack.vet\nhttps://github.com/reinforchu/EcoPowerTray", "EcoPowerTray - About",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk, System.Windows.Forms.MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// ライセンス
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_License_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("License: GNU General Public License version 3 (GPLv3)\nhttps://www.gnu.org/licenses/gpl-3.0.en.html\nhttps://www.ipa.go.jp/osc/license1.html\n\n本アプリケーションは、GPLv3に基づき公開しています。\n詳細なソフトウェアライセンスはGPLv3をご参照ください。\nなお、商用・非商用に関わらずどなたでも使用することが可能です。\n本アプリケーション使用することによって発生した損害など、一切の責任を負いません。", "EcoPowerTray - License",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.None, System.Windows.Forms.MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 高パフォーマンス
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_HighPerformance_Click(object sender, EventArgs e)
        {
            exe.CmdExecute("powercfg.exe -setactive SCHEME_MIN");
            notifyIcon1.BalloonTipTitle = "EcoPowerTray";
            notifyIcon1.BalloonTipText = "電源プランを高パフォーマンスに変更しました。";
            notifyIcon1.ShowBalloonTip(5000);
        }

        /// <summary>
        /// バランス
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_Balanced_Click(object sender, EventArgs e)
        {
            exe.CmdExecute("powercfg.exe -setactive SCHEME_BALANCED");
            notifyIcon1.BalloonTipTitle = "EcoPowerTray";
            notifyIcon1.BalloonTipText = "電源プランをバランスに変更しました。";
            notifyIcon1.ShowBalloonTip(5000);
        }

        /// <summary>
        /// 省電力
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_PwrSaver_Click(object sender, EventArgs e)
        {
            exe.CmdExecute("powercfg.exe -setactive SCHEME_MAX");
            notifyIcon1.BalloonTipTitle = "EcoPowerTray";
            notifyIcon1.BalloonTipText = "電源プランを省電力に変更しました。";
            notifyIcon1.ShowBalloonTip(5000);
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender">senderイベント発生元のオブジェクト</param>
        /// <param name="e">イベントの補足データ</param>
        private void toolStripMenuItem1_Exit_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
