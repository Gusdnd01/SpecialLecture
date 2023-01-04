using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GUIBase : MonoBehaviour
{
    public int intValue;
    public string stringValue;

    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnGUI()
    {
        if (Application.isPlaying) return;
        GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");
        GUI.Button(new Rect(20, 40, 80, 20), "Button1");
        GUI.Button(new Rect(20, 70, 80, 20), new GUIContent("Button2", "ToolTip"));
        GUI.Label(new Rect(20, 100, 100,40),GUI.tooltip);
    }
}
