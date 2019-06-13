﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace wizardscode.terrain
{
    [CustomEditor(typeof(MapPreview))]
    public class MapPreviewEditor : Editor
    {

        public override void OnInspectorGUI()
        {
            MapPreview mapPreview = (MapPreview)target;

            if (DrawDefaultInspector())
            {
                if (mapPreview.autoUpdate)
                {
                    mapPreview.DrawMapInEditor();
                }
            }

            if (GUILayout.Button("Generate"))
            {
                mapPreview.DrawMapInEditor();
            }
        }
    }
}