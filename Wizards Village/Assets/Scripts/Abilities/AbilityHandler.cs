using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    public List<Ability> activeAbilities;
    public List<float> cooldownTimers;
    private PlayerInput playerInput;
    public AbilityList abilityList;

    private void Awake()
    {
        //Find player and grabs its input
        playerInput = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>();
        //grabs all abilites in the active abilites
        cooldownTimers = new List<float>(activeAbilities.Count);

        activeAbilities = abilityList.activeAbilities;

        //Gets all abilites in the ability list and assigns it a corresponding abilities cooldown
        for (int i = 0; i < activeAbilities.Count; i++)
        {
            cooldownTimers[i] = 0f;
        }
    }
    void Update()
    {
#       region inputs
        if (playerInput.activateQAbility && activeAbilities[0] != null)
        {
            activeAbilities[0].Activate();
        }
        if (playerInput.activateWAbility && activeAbilities[1] != null)
        {
            activeAbilities[1].Activate();
        }
        if (playerInput.activateEAbility && activeAbilities[2] != null)
        {
            activeAbilities[2].Activate();
        }
        if (playerInput.activateRAbility && activeAbilities[3] != null)
        {
            activeAbilities[3].Activate();
        }
        if (playerInput.attack && activeAbilities[4] != null)
        {
            activeAbilities[4].Activate();
        }
        if (playerInput.secondaryAttack && activeAbilities[5] != null)
        {
            activeAbilities[5].Activate();
        }
        #endregion 
    }
}
