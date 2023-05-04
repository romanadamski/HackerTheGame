using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MapContextMenu : BaseMenu
{
    [SerializeField]
    private TextMeshProUGUI pathInputField;
    [SerializeField]
    private TextMeshProUGUI commandInputField;
    [SerializeField]
    private Button commandButton;

    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        commandButton.onClick.AddListener(OnCommandButtonClick);
    }

    private void OnCommandButtonClick()
    {
        string git = pathInputField.text.Trim(); string status = commandInputField.text.Trim();
        git = "git"; status = "status";
        var output = BashCommandsManager.Instance.ExecuteBashCommand(git, status);
        Debug.Log(output);
    }

    public void ShowAtPoint(Vector3 point)
    {
        SetPivot(point);
        transform.position = point;
        Show();
    }

    private void SetPivot(Vector3 point)
    {
        var pivotX = Screen.width <= point.x + _rectTransform.rect.width
            ? 1
            : 0;
        var pivotY = Screen.height <= (Screen.height - point.y) + _rectTransform.rect.height
            ? 0
            : 1;
        _rectTransform.pivot = new Vector2(pivotX, pivotY);
    }
}
