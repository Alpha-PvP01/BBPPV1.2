using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public EndGame counterKill;

    public event Action<int> onChanged;
    public event Action death;
    private void Start()
    {
        counterKill = FindObjectOfType<EndGame>();
    }
    public void TakeHit(int damage)
    {
        health -= damage;
        onChanged?.Invoke(health);
        if (health <= 0)
        {
            death?.Invoke();
            if (tag != "Player") 
                counterKill.CounterKillEnemy();
            gameObject.SetActive(false);
            
        }  
    }

    public void SetHealth(int restoreHealth) { 
        health += restoreHealth;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        onChanged?.Invoke(health);
    }
 
}
