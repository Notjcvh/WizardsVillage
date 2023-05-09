using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Ability", menuName = "Ability")]
public abstract class Ability : ScriptableObject
{
    [Header("Base Attributes")]
    public string abilityName;
    public string description;
    public Sprite icon;
    public int levelRequirement;
    public bool levelRequirementReached;

    [Header("Cooldowns")]
    public AbilityCooldown abilityCooldown;
    public float cooldownTime;
    public bool canUse;

    //This bool will tell the game if the ability is currently in the active slot
    public bool isActive;

    public abstract void Activate();
    public bool CheckLevelRequirement(CharacterData characterData)
    {
        if (characterData.level >= levelRequirement)
            return true;
        else
            return false;
    }
}
[CreateAssetMenu(fileName = "Blink", menuName = "Blink")]
public class Blink : Ability
{
    public override void Activate()
    {
        Debug.Log("Ice blast ability activated!");
    }
}
[CreateAssetMenu(fileName = "FrostBolt", menuName = "FrostBolt")]
public class FrostBolt : Ability
{
    public override void Activate()
    {
        Debug.Log("Lightning strike ability activated!");
    }
}
[CreateAssetMenu(fileName = "FireBall", menuName = "FireBall")]
public class FireBall : Ability
{
    public override void Activate()
    {
        Debug.Log( "Fireball ability activated!");
    }
}
[CreateAssetMenu(fileName = "ArcaneBeam", menuName = "ArcaneBeam")]
public class ArcaneBeam : Ability
{
    public override void Activate()
    {
        Debug.Log("ArcaneBeam ability activated!");
    }
}
[CreateAssetMenu(fileName = "Hex", menuName = "Hex")]
public class Hex : Ability
{
    public override void Activate()
    {
        Debug.Log("Hex ability activated!");
    }
}
[CreateAssetMenu(fileName = "IceBlock", menuName = "IceBlock")]
public class IceBlock : Ability
{
    public override void Activate()
    {
        Debug.Log("IceBlock ability activated!");
    }
}
[CreateAssetMenu(fileName = "Dice", menuName = "Dice")]
public class Dice : Ability
{
    public override void Activate()
    {
        Debug.Log("Dice ability activated!");
    }
}
[CreateAssetMenu(fileName = "MirrorImage", menuName = "MirrorImage")]
public class MirrorImage : Ability
{
    public override void Activate()
    {
        Debug.Log("MirrorImage ability activated!");
    }
}
[CreateAssetMenu(fileName = "ReanimateDead", menuName = "ReanimateDead")]
public class ReanimateDead : Ability
{
    public override void Activate()
    {
        Debug.Log("ReanimateDead ability activated!");
    }
}
[CreateAssetMenu(fileName = "SummonElemental", menuName = "SummonElemental")]
public class SummonElemental : Ability
{
    public override void Activate()
    {
        Debug.Log("SummonElemental ability activated!");
    }
}
[CreateAssetMenu(fileName = "CorpseExplosion", menuName = "CorpseExplosion")]
public class CorpseExplosion : Ability
{
    public override void Activate()
    {
        Debug.Log("CorpseExplosion ability activated!");
    }
}
[CreateAssetMenu(fileName = "BlackHole", menuName = "BlackHole")]
public class BlackHole : Ability
{
    public override void Activate()
    {
        Debug.Log("BlackHole ability activated!");
    }
}
[CreateAssetMenu(fileName = "ElementalStorm", menuName = "ElementalStorm")]
public class ElementalStorm : Ability
{
    public override void Activate()
    {
        Debug.Log("ElementalStorm ability activated!");
    }
}
[CreateAssetMenu(fileName = "MeteorStrike", menuName = "MeteorStrike")]
public class MeteorStrike : Ability
{
    public override void Activate()
    {
        Debug.Log("MeteorStrike ability activated!");
    }
}
[CreateAssetMenu(fileName = "LightingDash", menuName = "LightingDash")]
public class LightingDash : Ability
{
    public override void Activate()
    {
        Debug.Log("LightingDash ability activated!");
    }
}
[CreateAssetMenu(fileName = "ArcaneBarrage", menuName = "ArcaneBarrage")]
public class ArcaneBarrage : Ability
{
    public override void Activate()
    {
        Debug.Log("ArcaneBarrage ability activated!");
    }
}
[CreateAssetMenu(fileName = "MysticForm", menuName = "MysticForm")]
public class MysticForm : Ability
{
    public override void Activate()
    {
        Debug.Log("MysticForm ability activated!");
    }
}


