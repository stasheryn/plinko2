using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyBalance : MonoBehaviour
{
    [SerializeField] private static float currencyValue;
    [SerializeField] private TextMeshProUGUI textCurrencyValue;
    
    public void UpdateText()
    {
        textCurrencyValue.text = currencyValue.ToString();
    }

    private void Start()
    {
        UpdateText();
    }

    public static void AddValue(float bet)
    {
        currencyValue += bet;
    }

    public static void StartBallBet(float bet)
    {
        currencyValue -= bet;
    }
}
