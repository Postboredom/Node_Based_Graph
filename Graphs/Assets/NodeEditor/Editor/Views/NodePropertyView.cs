using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class NodePropertyView : ViewBase
{
    #region Public Var
    #endregion

    #region Protected Var
    #endregion

    #region Constructor
    public NodePropertyView() : base("Property View") { }
    #endregion

    #region Main Methods
    public override void UpdateView(Rect editorRect, Rect percentageRect, Event e)
    {
        base.UpdateView(editorRect,percentageRect,e);
        // Debug.Log("Updating " + viewTitle);

        GUI.Box(viewRect, viewTitle);

        GUILayout.BeginArea(viewRect);
        EditorGUILayout.LabelField("this is a label");
        GUILayout.EndArea();

        ProcessEvents(e);

    }
    #endregion

    #region Utility Methods
    public override void ProcessEvents(Event e)
    {
        base.ProcessEvents(e);

        if (viewRect.Contains(e.mousePosition))
        {
            //Left Click
            if (e.button == 0)
            {
                if (e.type == EventType.MouseDown)
                {
                 
                }

                if (e.type == EventType.MouseDrag)
                {

                }

                if (e.type == EventType.MouseUp)
                {

                }
            }

            //Right Click
            if (e.button == 1)
            {
                if (e.type == EventType.MouseDown)
                {
                }

                if (e.type == EventType.MouseDrag)
                {

                }

                if (e.type == EventType.MouseUp)
                {

                }
            }
        }
    }
    #endregion
}
