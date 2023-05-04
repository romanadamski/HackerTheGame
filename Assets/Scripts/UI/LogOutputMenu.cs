using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogOutputMenu : BaseMenu
{
    [SerializeField]
    private Text outputText;

    private void Awake()
    {
        EventsManager.Instance.CommandExecuted += CommandExecuted;
    }

    private void CommandExecuted(string value)
    {
        SetText(value);
    }

    private void SetText(string value)
    {
        outputText.text = value;
    }
}
