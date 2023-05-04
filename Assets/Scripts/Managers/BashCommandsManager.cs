using System.Collections;
using System.Collections.Generic;
using Diagnostic = System.Diagnostics;
using UnityEngine;

public class BashCommandsManager : BaseManager<BashCommandsManager>
{
    private void Start()
    {
        Debug.Log(ExecuteBashCommand("echo \"dupa\""));
    }

    private string ExecuteBashCommand(string command)
    {
        command = command.Replace("\"", "\"\"");

        var proc = new Diagnostic.Process
        {
            StartInfo = new Diagnostic.ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = "-c \"" + command + "\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };

        proc.Start();
        proc.WaitForExit();

        return proc.StandardOutput.ReadToEnd();
    }

}
