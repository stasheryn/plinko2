using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberResult : MonoBehaviour
{
    [SerializeField] private Image _img;
    [SerializeField] private TextMeshProUGUI _text;
    public void SetTextAndImg(Color color, String text)
    {
        _img.color = color;
        _text.text = text;
    }
}
