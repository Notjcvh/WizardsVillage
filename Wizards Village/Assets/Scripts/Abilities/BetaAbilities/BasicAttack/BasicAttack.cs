using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : Abilites
{
    public GameObject attackHitBox;
    public Transform abilitySpawner;

    private void Start()
    {
        abilitySpawner = GameObject.FindGameObjectWithTag("AbilitySpawner").GetComponent<Transform>();
    }

    public override void Ability()
    {
        Instantiate(attackHitBox, abilitySpawner);
        Debug.Log("Basic attack");
    }
}
