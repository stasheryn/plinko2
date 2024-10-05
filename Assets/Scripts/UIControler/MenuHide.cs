using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHide : MonoBehaviour
{
    [SerializeField] private GameObject toHide;

    [Header("For resize rectTransform")] [SerializeField]
    private RectTransform objRectToResize;

    [SerializeField] private bool needToResize;

    [SerializeField] private float heightMax;
    [SerializeField] private float heightMin;
    [SerializeField] private Vector2 offSetToSee;

    private void Start()
    {
        if (needToResize)
        { 
            offSetToSee = objRectToResize.offsetMin;
        }
    }

    public void Hide()
    {
        toHide.SetActive(!toHide.activeSelf);
    }

    public void HideAndResize()
    {
        var oRect = new Rect(objRectToResize.rect);
        toHide.SetActive(!toHide.activeSelf);
        if (toHide.activeSelf)
        {
            //h Max
            //objRectToResize.sizeDelta = new Vector2(objRectToResize.sizeDelta.x, heightMax);
            objRectToResize.offsetMin = offSetToSee;
        }
        else
        {
           // objRectToResize.sizeDelta = new Vector2(objRectToResize.sizeDelta.x, objRectToResize.sizeDelta.y + heightMin);
            
            
            
           // objRectToResize.rect = new Rect(oRect);
           //objRectToResize.
           objRectToResize.offsetMin = new Vector2(objRectToResize.offsetMin.x,objRectToResize.offsetMin.y + heightMin);
        }
    }
}