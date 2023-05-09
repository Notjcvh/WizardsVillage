using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Data", menuName = "Character Data")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private int priMaxHealth;
    [SerializeField] private int priLevel;

    public int maxHealth => priMaxHealth;
    public int level => priLevel;

    public int experiencePoints;

    public AbilityList abilityList;


    [SerializeField] private const int BASE_XP_PER_LEVEL = 100;
    [SerializeField] private const float XP_INCREASE_FACTOR = 1.5f;

    public void GainXP(int xp)
    {
        experiencePoints += xp;
        while (experiencePoints >= RequiredXPForNextLevel())
        {
            experiencePoints -= RequiredXPForNextLevel();
            priLevel++;
            Debug.Log("Leveled up to level " + priLevel);
        }
    }
    private int RequiredXPForNextLevel()
    {
        return Mathf.RoundToInt(BASE_XP_PER_LEVEL * Mathf.Pow(XP_INCREASE_FACTOR, priLevel));
    }

    public void SetMaxHealth(int value)
    {
        priMaxHealth = value;
    }

    public void IncreaseLevel()
    {
        foreach (Ability ability in abilityList.totalAbilityList)
        {
            if (ability.CheckLevelRequirement(this))
                abilityList.UnlockAbility(ability);
        }
        priLevel++;
    }
}
