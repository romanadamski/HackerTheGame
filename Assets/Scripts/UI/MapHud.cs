using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapHud : BaseMenu
{
    [SerializeField]
    private Button toggleLogMenuButton;

    private LogOutputMenu _logOutputMenu;

    private void Awake()
    {
        toggleLogMenuButton.onClick.AddListener(OnToggleLogMenuButtonClick);
    }

    private void OnToggleLogMenuButtonClick()
    {
        if (_logOutputMenu || UIManager.Instance.TryGetMenuByType(out _logOutputMenu))
        {
            _logOutputMenu.Toggle();
        }
    }
}
