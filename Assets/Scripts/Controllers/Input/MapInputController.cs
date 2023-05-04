using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapInputController : BaseInputController
{
    private MapContextMenu _mapContextMenu;

    public override void OnUpdate()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;
            
        if (Input.GetMouseButtonDown(1))
        {
            ShowMapContextMenu();
        }
        if (Input.GetMouseButtonDown(0))
        {
            HideMapContextMenu();
        }
    }

    private void ShowMapContextMenu()
    {
        if (_mapContextMenu || UIManager.Instance.TryGetMenuByType(out _mapContextMenu))
        {
            _mapContextMenu.ShowAtPoint(Input.mousePosition);
        }
    }

    private void HideMapContextMenu()
    {
        if (_mapContextMenu || UIManager.Instance.TryGetMenuByType(out _mapContextMenu))
        {
            _mapContextMenu.Hide();
        }
    }
}
