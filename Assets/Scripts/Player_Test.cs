using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Test : MonoBehaviour
{
    //variables for max & current health/mp/energy
    public int maxHealth = 10;
    public int currentHealth;

    public int maxMP = 10;
    public int currentMP;

    public int maxEnergy = 10;
    public int currentEnergy;

    //link other scripts for variables & etc.
    public HealthBar healthBar;
    public MPBar mpBar;
    public EnergyBar energyBar;

    // Start is called before the first frame update
    void Start() 
    {
        //set max health & health bar to max health
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //set max MP & MP bar to max MP
        currentMP = maxMP;
        mpBar.SetMaxMP(maxMP);
        //set max energy & energy bar to max energy
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
    }

    // Update is called once per frame
    void Update()
    {
        //test health bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
        //test MP bar
        if (Input.GetKeyDown(KeyCode.M))
        {
            TakeMP(1);
        }
        //test energy bar
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeEnergy(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void TakeMP(int mp)
    {
        currentMP -= mp;
        mpBar.SetMP(currentMP);
    }

    void TakeEnergy(int energy)
    {
        currentEnergy -= energy;
        energyBar.SetEnergy(currentEnergy);
    }
}
