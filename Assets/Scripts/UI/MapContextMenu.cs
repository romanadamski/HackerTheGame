using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapContextMenu : BaseMenu
{
    public void ShowAtPoint(Vector3 point)
    {
        transform.position = point;
        Show();
    }
}
