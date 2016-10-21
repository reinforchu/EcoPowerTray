using System.Windows;

namespace EcoPowerTray
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// タスクトレイに常駐
        /// </summary>
        private NotifyIcon notifyIcon;

        /// <summary>
        /// 開始時のイベント(NotifyIcon の初期化)
        /// </summary>
        /// <param name="e">StartupEventArgs</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnExplicitShutdown;
            notifyIcon = new NotifyIcon();
        }

        /// <summary>
        /// 終了時のイベント(リソースの解放)
        /// </summary>
        /// <param name="e">ExitEventArgs</param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            notifyIcon.Dispose();
        }
    }
}
