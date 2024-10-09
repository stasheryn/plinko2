using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHistoryview : MonoBehaviour
{
    [SerializeField] private Mask _mask;
    [SerializeField] private GameObject _TMProTEXT;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GridLayoutGroup _gGroup;
    [Header("Resize RectTransform of IMG")]
    [SerializeField] private float oneRowHeight = 36f;
    // мб ще добавити значення відступів з грідГруп
    [SerializeField] private float sumBorders = 4f;
    [SerializeField] private RectTransform _rTransform;
    [SerializeField] private int rows;

    [SerializeField]private bool opened;

    [Header("content Object th holds childs onChanged")] 
    [SerializeField] private ChangeHistoryChild parentOfChild;

    // SHOW TEXT AND ROWS
    public void ShowManyRowsH()
    {
        // кількість рядків 
        rows = ((_gGroup.transform.childCount - 1) / _gGroup.constraintCount) + 1;
        // оф маску 
        _mask.enabled = false;
        // вкл текст
        _TMProTEXT.SetActive(true);
        // +40+10(spacing 1st layout)
        // +36 (size in 2nd layout)
        // нове значення висоти картинки + відступи + висота обєктуЗТекстом
        _rTransform.sizeDelta = new Vector2(_rTransform.sizeDelta.x, (oneRowHeight * rows)+50f);
    }

    public void ShowOnlyOneRowH()
    {
        _TMProTEXT.SetActive(false);
        _mask.enabled = true;
        _rTransform.sizeDelta = new Vector2(_rTransform.sizeDelta.x, oneRowHeight);
        
        
        
        
    }

    public void HistoryShowShortOrLong()
    {
        if (opened)
        {
            ShowOnlyOneRowH();
        }
        else
        {
            ShowManyRowsH();
        }

        opened = !opened;
    }

    public void CallbackFromParentChildrenChange()
    {
        if (!opened)
        {
            //ShowOnlyOneRowH();
            _rTransform.sizeDelta = new Vector2(_rTransform.sizeDelta.x, oneRowHeight);
        }
        else
        {
            //ShowManyRowsH();
            rows = ((_gGroup.transform.childCount - 1) / _gGroup.constraintCount) + 1;
            _rTransform.sizeDelta = new Vector2(_rTransform.sizeDelta.x, (oneRowHeight * rows)+50f);
        }
    }

    private void Start()
    {
        parentOfChild.OnChildChanged += CallbackFromParentChildrenChange;
    }

}