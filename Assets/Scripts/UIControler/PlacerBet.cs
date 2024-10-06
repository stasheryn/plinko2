using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class PlacerBet : MonoBehaviour
{
    [SerializeField] private float betValue = 0.3f;
    [SerializeField] private TextMeshProUGUI textCurrencyValue;
    
    public static PlacerBet Instance
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

    public float CurrentBet()
    {
        return betValue;
    }
    
    
    
    public void UpdateText()
    {
        textCurrencyValue.text = betValue.ToString("F2", CultureInfo.InvariantCulture);
    }

    private void Start()
    {
        UpdateText();
    }

    // another buttons contrl
    public void AddValue(float bet)
    {
        betValue += bet;
    }

    public void MinusValue(float bet)
    {
        betValue -= bet;
    }
}
