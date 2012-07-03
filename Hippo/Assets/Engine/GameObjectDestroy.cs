using System;
using UnityEngine;
using System.Collections;

public static class GameObjectDestroy
{
    public static void Destroy(Component component)
    {
        Destroy(component.gameObject);
    }

    public static void Destroy(GameObject gameObject)
    {
        UnityEngine.Object.Destroy(gameObject);
    }
}