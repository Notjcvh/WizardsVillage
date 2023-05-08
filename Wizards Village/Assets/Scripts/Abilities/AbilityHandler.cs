using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    public List<Abilites> abilityList;
    public AbilityList abilityPool;
    public List<AbilityCooldown> abilityCooldowns;
    private PlayerInput playerInput;

    private void Awake()
    {
        //Find player and grabs its input
        playerInput = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>();
        //grabs all abilites in the active abilites
        abilityPool.activeAbilities = abilityList;
        //Gets all abilites in the ability list and assigns it a corresponding abilities cooldown
        for (int i = 0; i < abilityList.Count; i++)
        {
            if (abilityList[i] == null)
                return;
            else
                abilityList[i].abilityCooldown = abilityCooldowns[i];
                abilityCooldowns[i].icon = abilityList[i].icon;
        }
    }
    void Update()
    {
#       region inputs
        if (playerInput.activateQAbilityy && abilityList[0] != null)
        {
            abilityList[0].TriggerAbility();
        }
        if (playerInput.activateWAbility && abilityList[1] != null)
        {
            abilityList[1].TriggerAbility();
        }
        if (playerInput.activateEAbility && abilityList[2] != null)
        {
            abilityList[2].TriggerAbility();
        }
        if (playerInput.activateRAbility && abilityList[3] != null)
        {
            abilityList[3].TriggerAbility();
        }
        if (playerInput.attack && abilityList[4] != null)
        {
            abilityList[4].TriggerAbility();
        }
        if (playerInput.secondaryAttack && abilityList[5] != null)
        {
            abilityList[5].TriggerAbility();
        }
        #endregion 
    }

    public void UpdateAbilites(Abilites ability, int abilitySlot)
    {
        abilityList[abilitySlot] = abilityPool.activeAbilities[abilitySlot];
        abilityList[abilitySlot].abilityCooldown = abilityCooldowns[abilitySlot];
    }
}
