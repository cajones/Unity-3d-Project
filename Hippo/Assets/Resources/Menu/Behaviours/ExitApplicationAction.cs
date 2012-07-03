using UnityEngine;
using System.Collections;

public class ExitApplicationAction : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.Quit();
    }
}
