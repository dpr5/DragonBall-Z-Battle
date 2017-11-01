using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class GameMaster : MonoBehaviour {

    public GameObject player;
    public GameObject battle;

    private PlayerHealth playerhealth;
    private battleSystem results;

    private bool tie;
    private bool lose;
    private bool win;

    
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }

    public Slider healthbar;

    void Start()
    {
        results = player.GetComponent<battleSystem>();
        tie = results.tie;
        lose = results.lose;
        win = results.win;

        MaxHealth = 20f;
        CurrentHealth = MaxHealth;

        healthbar.value = CalculateHealth();
    }


    void Update()
    {
        if (win == true)
        {
            Debug.Log("You win");
            DealDamage(0);
        }if(lose == true)
        {
            Debug.Log("You lost");
            DealDamage(10);
        }
        if (tie == true)
        {
            Debug.Log("You tied");
            DealDamage(5);
        }
    }

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        healthbar.value = CalculateHealth();
        if (CurrentHealth <= 0)
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
