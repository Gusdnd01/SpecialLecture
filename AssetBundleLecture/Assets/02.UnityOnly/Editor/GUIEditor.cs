using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GUIBase))]
public class GUIEditor : Editor
{
    GUIBase _this;

    public void OnEnable()
    {
        _this = target as GUIBase;
    }

    public override void OnInspectorGUI(){
        GUILayout.Label("GUI Editor");
        GUILayout.Space(5);
        if(GUILayout.Button("GUi Button"))
        {
            Debug.Log("Button Clicked");
            _this.intValue = 30;
        }
        GUILayout.Space(10);
        int intTestValue = int.Parse(GUILayout.TextField(_this.intValue.ToString()));
        _this.intValue = intTestValue;
        GUILayout.TextField($"{_this.intValue}");
        GUILayout.Space(5);

        base.OnInspectorGUI();
    }
}
