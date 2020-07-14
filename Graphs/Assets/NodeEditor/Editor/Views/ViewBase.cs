using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System;

[Serializable]
public class ViewBase
{
    #region Public var
    public string viewTitle;
    public Rect viewRect;
    #endregion

    #region protected var
    protected GUISkin viewSkin;
    #endregion

    #region Constructors
    public ViewBase(string title)
    {
        viewTitle = title;
    }
    #endregion

    #region Main Methods
    public virtual void UpdateView(Rect editorRect, Rect percentageRect, Event e) 
    {
        // Debug.Log("Updating base view class");
        viewRect = new Rect(editorRect.x * percentageRect.x,
            editorRect.y * percentageRect.y,
            editorRect.width * percentageRect.width,
            editorRect.height * percentageRect.height);
    }
    public virtual void ProcessEvents(Event e)
    {
   
    }

    #endregion

    #region Utility Methods
    protected void GetEditorSkin()
    {

    }
    #endregion

}
