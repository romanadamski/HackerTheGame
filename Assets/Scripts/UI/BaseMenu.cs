using UnityEngine;

public class BaseMenu : MonoBehaviour
{
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    public virtual void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
