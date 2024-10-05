using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class GoalTriger : MonoBehaviour
{
    [SerializeField] private float pointMultiplier;

    // text try
    [SerializeField] private GameObject prefabText;
    [SerializeField] private Transform worldCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //


        if (other.CompareTag(this.tag))
        {
            // add new value of started bet
            var ball = other.GetComponent<BallBetvalue>();
            var bet = ball.GetBetValue();
            var colorBet = ball.GetBetColor();
            CurrencyBalance.AddValue(bet * pointMultiplier);
            // add button to history
            SpawnerButtonhistory.Instance.SpawnButtonHistory(colorBet ,bet.ToString("F2" ,CultureInfo.InvariantCulture));
            //
            transform.DOPunchScale(Vector3.one * 0.3f, 1f);
            //
            Debug.Log("destroy ball");
            Destroy(other.gameObject);
        }
    }

    public void SetMultiplier()
    {
        // get Component TMPro Text .text = textValue;
    }

    private void SetupTextNumb()
    {
        var textNumb = Instantiate(prefabText, worldCanvas);
        textNumb.transform.position = transform.position;
        TextMeshProUGUI realText = textNumb.GetComponent<TextMeshProUGUI>();
        realText.text = pointMultiplier.ToString("F1");
    }

    private void Start()
    {
        SetupTextNumb();
    }
    
    // format string
    private String FormatString1(float number)
    {
        return "asd";
    }
}