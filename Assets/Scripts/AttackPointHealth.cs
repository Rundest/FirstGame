using UnityEngine;

public class AttackPointHealth : MonoBehaviour
{
    private Enemy enemy;
    private HealthBar healthBar;
    public int currenthealth;
    public int Maxhealth;

    private void Start()
    {
        currenthealth = Maxhealth;
        healthBar = GetComponent<HealthBar>();
        enemy = GetComponent<Enemy>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidingTarget = collider.gameObject;
        if (!collidingTarget.CompareTag("Enemy")) return;

        Destroy(collidingTarget);
        currenthealth -= 100;
        healthBar.SetHealth(currenthealth);
    }
}