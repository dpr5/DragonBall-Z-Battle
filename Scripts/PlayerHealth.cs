using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class PlayerHealth : MonoBehaviour {




    public bool testBool;
    public float CurrentHealth { get; set; }
    public float MaxHealth{ get; set; }

    public Slider healthbar;
	
	void Start () 
	{
        MaxHealth = 20f;
        CurrentHealth = MaxHealth;

        healthbar.value = CalculateHealth();
	}
	
	
	void Update () 
	{
        if (Input.GetKeyDown(KeyCode.X))
        {
            DealDamage(6);
        }
	}

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        healthbar.value = CalculateHealth();
        if(CurrentHealth <= 0)
        {
            Die();
        }
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }
    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("Dead");
    }
}
