using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBetvalue : MonoBehaviour
{
    [SerializeField] private float valueBet;
    [SerializeField] private SpriteRenderer sprite;

    public float GetBetValue()
    {
        return valueBet;
    }
    public Color GetBetColor()
    {
        return sprite.color;
    }
}
