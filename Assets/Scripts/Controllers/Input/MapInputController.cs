using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInputController : BaseInputController
{
    private MapContextMenu _mapContextMenu;

    public override void OnUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ShowMapContextMenu();
        }
    }

    private void ShowMapContextMenu()
    {
        Debug.Log($"MOUSE POSITION {Input.mousePosition}".Color("red"));
        if (_mapContextMenu || UIManager.Instance.TryGetMenuByType(out _mapContextMenu))
        {
            _mapContextMenu.ShowAtPoint(Input.mousePosition);
        }
    }
}
