using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AbilityList", menuName = "Abilities")]

public class AbilityList : ScriptableObject
{
    public List<Ability> totalAbilityList;
    public List<Ability> unlockedAbilityList;
    public List<Ability> activeAbilities;
    public AbilityHandler AbilityHandler;
    public void UnlockAbility(Ability ability)
    {
        if (!unlockedAbilityList.Contains(ability))
        {
            unlockedAbilityList.Add(ability);
        }
    }

    public void ChangeAbility(Ability ability, int activeablitySlot)
    {
        if (ability.isActive || !ability.canUse)
        { 
            Debug.Log("Ability can not be switched");
            return;
        }
        else
        {
            activeAbilities[activeablitySlot].isActive = false;
            activeAbilities[activeablitySlot] = ability;
            foreach (var item in activeAbilities)
            {
                item.isActive = true;  
            }
        }
            
    }
}
