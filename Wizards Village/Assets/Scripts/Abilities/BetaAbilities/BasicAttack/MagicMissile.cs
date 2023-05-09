using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MagicMissile", menuName = "MagicMissile")]

public class MagicMissile : Ability
{
    public override void Activate()
    {
        Debug.Log("MagicMissile ability activated!");
    }
}
