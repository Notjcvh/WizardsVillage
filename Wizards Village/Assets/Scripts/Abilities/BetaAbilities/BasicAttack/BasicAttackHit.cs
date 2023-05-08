using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttackHit : MonoBehaviour
{
    public float lifetime;
    public int damage;
    private void Awake()
    {
        Destroy(this.gameObject, lifetime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
