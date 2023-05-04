using System.Collections;
using System.Collections.Generic;
using Diagnostic = System.Diagnostics;
using UnityEngine;
using System.Threading.Tasks;

public class BashCommandsManager : BaseManager<BashCommandsManager>
{
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

        proc.Start();
        proc.WaitForExit();
        return proc.StandardOutput.ReadToEnd();
    }
}
