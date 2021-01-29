using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGameManager : MonoBehaviour
{
    public List<Enemy> Enemys = new List<Enemy>();
    Enemy enemyscript;

    public Text CoinCounter;
    [HideInInspector]
    public int CoinAmount;

    // Update is called once per frame
    void Update()
    {
        CoinCounter.text = CoinAmount.ToString();

        Enemys.Equals(enemyscript);

        foreach (Enemy i in Enemys)
        {
            if (i.health <= 0)
            {
                Enemys.Remove(i);
                i.lifeStatement = Enemy.LifeStatement.IsDead;
                CoinAmount += 100;
                Debug.Log(i.lifeStatement = i.lifeStatement = Enemy.LifeStatement.IsDead);
            }
            else
            {
                i.lifeStatement = Enemy.LifeStatement.IsAlive;
                Debug.Log(i.lifeStatement = Enemy.LifeStatement.IsAlive);
            }
        }

    }
}
