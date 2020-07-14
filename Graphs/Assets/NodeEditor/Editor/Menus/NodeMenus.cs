using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class NodeMenus
{
  [MenuItem("Node Editor/Launch Editor")]
  public static void InitNodeEditor()
    {
        NodeEditorWindows.InitEditorWindow();
    }
}
