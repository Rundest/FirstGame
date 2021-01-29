using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{
    public Transform raycastPoint;
    public Camera camera;
    public int Damage;
    public ParticleSystem Muzzleflash;
    public int currenthealth;
    public int MaxHealth = 100;

    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Muzzleflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(raycastPoint.position, raycastPoint.forward, out hit))
        {
            enemy = hit.transform.GetComponent<Enemy>();

            if (!enemy) return;
            DoDamage(enemy);
        }
    }
    public void DoDamage(Enemy enemy)
    {
        if (!enemy) return;

        enemy.TakeDamage(Damage);
    }
}
