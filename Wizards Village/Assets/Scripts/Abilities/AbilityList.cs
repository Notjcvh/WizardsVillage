using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AbilityList", menuName = "Abilities")]

public class AbilityList : ScriptableObject
{
    public List<Abilites> abilityList;
    public List<Abilites> activeAbilities;
    public AbilityHandler AbilityHandler;
    void Start()
    {
        foreach (var ability in activeAbilities)
        {
            ability.isActive = true;
        }
    }
    public void AddAbilityToPool(Abilites ability)
    {
        abilityList.Add(ability);
    }

    public void ChangeAbility(Abilites ability, int activeablitySlot)
    {
        if (ability.isActive || !ability.canUse)
            return;
        else
            activeAbilities[activeablitySlot] = ability;
    }
}

[System.Serializable]
public class AbilitySlot
{
    public Abilites ability;
}
