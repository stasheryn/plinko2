using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpawnerButtonhistory : MonoBehaviour
{
    [SerializeField] private Transform parentCanva;
    [SerializeField] private NumberResult prefab;
    
    public static SpawnerButtonhistory Instance
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

    public void SpawnButtonHistory(Color color, String value)
    {
        var inst = Instantiate(prefab, parentCanva);
        inst.SetTextAndImg(color, value);
        // DoScale тут
        inst.transform.DOPunchScale(Vector3.one * 0.09f, 0.4f);
        // Дод в список який очищується кнопкою
        DeleteHistory.Instance.listOfHistory.Add(inst);

    }
}
