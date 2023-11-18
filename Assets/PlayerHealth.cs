using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health; 
    public int maxHealth = 20; 
    public int damage = 3;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; 
        startPos = transform.position; 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            transform.position = startPos; 
            health = maxHealth; 
        }
    }

    public int GetDamage()
    {
        return damage; 
    }
}
