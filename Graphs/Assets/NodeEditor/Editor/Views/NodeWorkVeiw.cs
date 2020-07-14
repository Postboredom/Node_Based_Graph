using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NodeWorkVeiw : ViewBase
{
    #region Public Var
    #endregion

    #region Protected Var
    #endregion

    #region Constructor
    public NodeWorkVeiw() : base("Work View") { }
    #endregion

    #region Main Methods
    public override void UpdateView(Rect editorRect, Rect percentageRect, Event e)
    {
        base.UpdateView(editorRect,percentageRect,e);
      //  Debug.Log("Updating " + viewTitle);

        GUI.Box(viewRect, viewTitle);

        GUILayout.BeginArea(viewRect);
        EditorGUILayout.LabelField("this is a label");
        GUILayout.EndArea();

        ProcessEvents(e);
    }

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

    #region Utility Methods
    #endregion
}
