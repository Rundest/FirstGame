using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public float lookraidious;
    public HealthBar healthbar;
    public Transform target;
    NavMeshAgent agent;

    public LifeStatement lifeStatement = LifeStatement.IsAlive;
    public enum LifeStatement
    {
        IsAlive,
        IsDead
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        healthbar.SetMaxHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        if (!target) return;
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookraidious)
        {
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        healthbar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookraidious);
    }


}