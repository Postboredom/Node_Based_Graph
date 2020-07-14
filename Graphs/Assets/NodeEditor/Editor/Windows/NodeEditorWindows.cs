using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using System;

public class NodeEditorWindows : EditorWindow
{
    #region Variables
    public static NodeEditorWindows curWindow;
    public NodePropertyView propertyView;
    public NodeWorkVeiw workVeiw;

    public float viewPercetage = 0.75f;
    #endregion

    #region Main Methods
    public static void InitEditorWindow()
    {
        curWindow = (NodeEditorWindows)EditorWindow.GetWindow<NodeEditorWindows>();
        curWindow.titleContent.text = "Node Editor";

        CreateViews();
    }

    void OnEnable()
    {
        //Debug.Log("Enabled Window!");
    }

    void OnDestroy()
    {
      //  Debug.Log("Disabled Window!");

    }

    void Update()
    {
    //    Debug.Log("Updated Window!");

    }

    void OnGUI()
    {
        //Null check views
        if (propertyView == null || workVeiw == null)
        {
            CreateViews();
            return;
        }

        //Get and process events
        Event e = Event.current;
        ProcessEvents(e);
        
        //Update Views
        workVeiw.UpdateView(position, new Rect(0f, 0f, viewPercetage, 1f),e);
        propertyView.UpdateView(new Rect(position.width, position.y, position.width, position.height),
                                new Rect(viewPercetage, 0f, 1f - viewPercetage, 1f),e);
        
        Repaint();
    }

 
    #endregion

    #region Utility Methods
    private static void CreateViews()
    {
        if (curWindow != null)
        {
            curWindow.propertyView = new NodePropertyView();
            curWindow.workVeiw = new NodeWorkVeiw();
        }
        else
        {
            curWindow = (NodeEditorWindows)EditorWindow.GetWindow <NodeEditorWindows>();
        }
    }

    private void ProcessEvents(Event e)
    {
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.LeftArrow)
        {
            viewPercetage -= 0.01f;
        }
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.RightArrow)
        {
            viewPercetage += 0.01f;
        }
    }
    #endregion
}
