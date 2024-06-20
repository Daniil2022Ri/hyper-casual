using Assets.Scripts.Money_and_Beer;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoneyAndBeer : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Bottle bottle;

    [SerializeField] List<GameObject> pointMoney;
    [SerializeField] List<GameObject> pointBeer;


    private void Start()
    {
        SpawnMoneyPoint();
    }
    private void SpawnMoneyPoint()
    {
        foreach (var pointMoney in pointMoney)
        {
            Instantiate(money, pointMoney.transform.position, Quaternion.identity);
        }
        foreach (var pointBottle in pointBeer)
        {
            Instantiate(bottle, pointBottle.transform.position, Quaternion.identity);
        }
    }
}
