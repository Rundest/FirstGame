using UnityEngine;

public class MinusDolars : MonoBehaviour
{
    public EnemyGameManager enemyGameManager;
    MinusDolars minusDolars;

    private void Update()
    {
        if (enemyGameManager == null)
        {
            Debug.Log("NULL");
            minusDolars.enemyGameManager.Equals(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!Input.GetKeyDown(KeyCode.E)) return;
        if (enemyGameManager.GetCoinAmount() < 200) return;
        enemyGameManager.DecreaseCoinAmount(200);
    }
}