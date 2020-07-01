using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Test : EditorWindow

{
    // Add menu named "My window" to the window menu
    [MenuItem("window/Test")]
    static void Init()
    {
        //Get existing open window or if none, make a new one:
        Test window = (Test)EditorWindow.GetWindow(typeof(Test));
        window.Show();
    }

    
    void OnGUI()
    {
        Handles.color = Color.black;
        Handles.DrawRectangle(0, new Vector3(200, 200, 0), Quaternion.identity, 100);
        Handles.DrawSolidDisc(new Vector3(200, 150, 0), Vector3.forward, 50);
        Handles.DrawSolidDisc(new Vector3(200, 250, 0), Vector3.forward, 50);
    }
}
