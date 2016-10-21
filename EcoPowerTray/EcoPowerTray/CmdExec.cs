using System;
using System.Diagnostics;

namespace EcoPowerTray
{

    /// <summary>
    /// cmd.exeを実行させるクラス
    /// </summary>
    class CmdExec
    {

        /// <summary>
        /// cmd.exeの実行
        /// </summary>
        /// <param name="command">実行するコマンド</param>
        public void CmdExecute(string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"/c " + command;
            p.Start();
            p.WaitForExit();
            p.Close();
        }
    }
}
