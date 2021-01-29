using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGameManager : MonoBehaviour
{
    [SerializeField] private List<Enemy> Enemys;
    [SerializeField] private  Text CoinCounter;
    [SerializeField] private int CoinAmount;

    // Update is called once per frame
    void Update()
    {
        CoinCounter.text = CoinAmount.ToString();

        for (int i = 0; i < Enemys.Count; i++)
        {
            if (Enemys[i].health > 0) continue;
            Enemys[i].lifeStatement = Enemy.LifeStatement.IsDead;
            CoinAmount += 100;
            Enemys.RemoveAt(i);
        }
    }

    public void DecreaseCoinAmount(int _amount)
    {
        if (CoinAmount <= _amount)
            CoinAmount = 0;
        else
            CoinAmount -= _amount;
    }

    public int GetCoinAmount()
    {
        return CoinAmount;
    }
}