using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class CurrencyBalance : MonoBehaviour
{
    [SerializeField] private float currencyValue;
    [SerializeField] private TextMeshProUGUI textCurrencyValue;
    public static CurrencyBalance Instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    
    
    
    
    private void UpdateText()
    {
        textCurrencyValue.text = currencyValue.ToString("F2",CultureInfo.InvariantCulture);
    }

    private void Start()
    {
        UpdateText();
    }

    public void AddValue(float bet)
    {
        currencyValue += bet;
        UpdateText();
    }

    public void MinusValue(float bet)
    {
        currencyValue -= bet;
        UpdateText();
    }

    public bool TrueCheck(float minusCurrencyAvailable)
    {
        return ((currencyValue - minusCurrencyAvailable) > 0);
    }
}
