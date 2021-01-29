using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetLevel : MonoBehaviour
{
    public Button ResetButton;
    public AttackPointHealth attackPoint;
    public Canvas canvas;

    private void Start()
    {       
        attackPoint = GetComponent<AttackPointHealth>();
    }


    // Update is called once per frame
    void Update()
    {              
        if(attackPoint.currenthealth <= 0)
        {            
            if (ResetButton.onClick.Equals(true))
            {
                LoadLevel();
            }
        }
    }

    public void LoadLevel()
    {
        Application.LoadLevel("SampleScene");
    }
}
