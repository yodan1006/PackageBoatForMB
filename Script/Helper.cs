using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace yodan
{
    [CustomEditor(typeof(BasicBoatMono))]
    public class Helper : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            BasicBoatMono t = (BasicBoatMono)target;
            if (GUILayout.Button("Teleport Forward"))
            {
                t.TeleportForward();
            }
        }
    }
}