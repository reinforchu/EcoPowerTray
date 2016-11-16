using System.Diagnostics;
using System.Windows;

namespace EcoPowerTray
{
    /// <summary>
    /// Interaction logic of App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Init application
        /// </summary>
        private EPTApp eptApp;

        /// <summary>
        /// Startup event
        /// </summary>
        /// <param name="e">StartupEventArgs</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            Process MyProcess = Process.GetCurrentProcess();
            Process[] AllProcess = Process.GetProcessesByName(MyProcess.ProcessName);
            if (AllProcess.Length > 1)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                base.OnStartup(e);
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                eptApp = new EPTApp();
            }
        }

        /// <summary>
        /// Exit event (Resources dispose)
        /// </summary>
        /// <param name="e">ExitEventArgs</param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            eptApp.Dispose();
        }
    }
}
