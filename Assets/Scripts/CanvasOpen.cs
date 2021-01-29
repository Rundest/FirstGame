using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasOpen : MonoBehaviour
{
    AttackPointHealth attackPoint;
    public Canvas canvas;

    private void Start()
    {
        attackPoint = GetComponent<AttackPointHealth>();              
    }

    // Update is called once per frame
    void Update()
    {             
        if (attackPoint.currenthealth <= 0)
        {
            canvas.enabled = true;                
        }
    }
}
