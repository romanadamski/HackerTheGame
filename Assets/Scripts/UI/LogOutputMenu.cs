using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogOutputMenu : BaseMenu
{
    [SerializeField]
    private Text outputText;
    [SerializeField]
    private ScrollRect scrollRect;

    private void Awake()
    {
        EventsManager.Instance.CommandExecuted += CommandExecuted;
    }

    private void CommandExecuted(string value)
    {
        SetText(value);
        scrollRect.verticalScrollbar.value = 1;
    }

    private void SetText(string value)
    {
        outputText.text = value;
    }
}
