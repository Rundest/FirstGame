using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusDolars : MonoBehaviour
{
    public EnemyGameManager enemyGameManager;
    MinusDolars minusDolars;

    private void Start()
    {
        enemyGameManager = GetComponent<EnemyGameManager>();
    }

    private void Update()
    {
        if(enemyGameManager == null)
        {
            Debug.Log("NULL");
            minusDolars.enemyGameManager.Equals(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Clicked!");  
            enemyGameManager.CoinAmount -= 200;
        }
    }
}    
