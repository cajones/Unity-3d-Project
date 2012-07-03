using UnityEngine;
using System.Collections;

public class LoadLevelAction : MonoBehaviour {

    public string LevelName;

    public void OnMouseDown()
    {
        Application.LoadLevel(LevelName);
    }
}
