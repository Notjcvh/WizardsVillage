using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyType enemyType;
    [Header("Health")]
    public int maxHealth;
    public int currentHealth;
    public enum EnemyType {Normal, Elite, Boss};

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }
}
