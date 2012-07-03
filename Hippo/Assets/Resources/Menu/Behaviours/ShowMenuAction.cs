using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Transform))]
public class ShowMenuAction : MonoBehaviour
{
    public Transform MenuItems;

    public void OnMouseDown()
    {
        if (MenuItems == null) return;

        var menu = GameObject.Find("MainMenuItems");
        var target = MenuItems.position;

        menu.transform.Translate(-target.x, 0, 0, Space.Self);
	}
}
