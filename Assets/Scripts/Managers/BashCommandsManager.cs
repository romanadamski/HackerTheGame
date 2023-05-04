using System.Collections;
using System.Collections.Generic;
using Diagnostic = System.Diagnostics;
using UnityEngine;

public class BashCommandsManager : BaseManager<BashCommandsManager>
{
    private void Start()
    {
        ExecuteBashCommand("git", "status");
    }

    public string ExecuteBashCommand(string path, string command)
    {
        command = command.Replace("\"", "\"\"");
        var proc = new Diagnostic.Process
        {
            StartInfo = new Diagnostic.ProcessStartInfo
            {
                FileName = path,
                Arguments = command,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };
        Debug.Log($"{proc.StartInfo.FileName} {proc.StartInfo.Arguments}");
        proc.Start();
        proc.WaitForExit();

        return proc.StandardOutput.ReadToEnd();
    }

}
