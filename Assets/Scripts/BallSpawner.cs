using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private BallBetvalue ballPrefab;
    [SerializeField] private Transform parentTransform;
    [SerializeField] private Color colorGreen;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorRed;

    [Header("Random position of spawn Ball")] [SerializeField]
    private float minX;

    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;


    // Button in inspector
    public void SpawnGreenBall()
    {
        //  CBalance.Inst - PlacerBet.Instance
        if (CurrencyBalance.Instance.TrueCheck(PlacerBet.Instance.CurrentBet()))
        {
            // drag code here
        }

        CurrencyBalance.Instance.MinusValue(PlacerBet.Instance.CurrentBet());

        // change with rand Vect3 positions
        var inst = Instantiate(ballPrefab, parentTransform);
        inst.SetColor(colorGreen);
        inst.tag = "Green";
        inst.transform.position = RandPos();
        inst.SetBetValue(PlacerBet.Instance.CurrentBet());
    }

    public void SpawnYellowBall()
    {
        var inst = Instantiate(ballPrefab, transform);
        inst.SetColor(colorYellow);
        inst.tag = "Yellow";
        inst.transform.position = RandPos();
        inst.SetBetValue(PlacerBet.Instance.CurrentBet());
    }

    public void SpawnRedBall()
    {
        var inst = Instantiate(ballPrefab, transform);
        inst.SetColor(colorRed);
        inst.tag = "Red";
        inst.transform.position = RandPos();
        inst.SetBetValue(PlacerBet.Instance.CurrentBet());
    }


    private Vector3 RandPos()
    {
        var position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

        return position;
    }
}