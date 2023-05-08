using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Ability", menuName = "Abilities")]
public abstract class Abilites : ScriptableObject
{
    public class MyFloatEvent : UnityEvent<float> { }
    public MyFloatEvent OnAbilityUse = new MyFloatEvent();
    [Header("Ability Info")]
    public string title;
    public Sprite icon;
    public float cooldownTime = 1;
    public AbilityCooldown abilityCooldown;
    public bool isActive;
    public bool canUse = true;
    public void TriggerAbility()
    {
        if (canUse)
        {
            OnAbilityUse.Invoke(cooldownTime);
            Ability();
            StartCooldown();
        }

    }
    public abstract void Ability();
    void StartCooldown()
    {
        StartCoroutine(Cooldown());
        abilityCooldown.UseSpell(cooldownTime);
        IEnumerator Cooldown()
        {
            canUse = false;
            yield return new WaitForSeconds(cooldownTime);
            canUse = true;
        }
    }
}
