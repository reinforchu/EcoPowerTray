using System;
using System.Diagnostics;
using System.Windows.Forms;

/// <summary>
/// Excute cmd.exe class
/// </summary>
public class CmdExec
{
    public static readonly string ExceptionMessageJP = "電源プラン変更に失敗しました。\nトレース情報を表示しますか？";

    /// <summary>
    /// Execute command
    /// </summary>
    /// <param name="command">Command line</param>
    public void Execute(string command)
    {
        Process p = new Process();
        try
        {
            p.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"/c " + command;
            p.Start();
            p.WaitForExit();
        }
        catch (Exception e)
        {
            DialogResult result = MessageBox.Show(ExceptionMessageJP, "EcoPowerTray - Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(e.ToString(), "EcoPowerTray - Exception", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        finally
        {
            p.Close();
        }
    }
}