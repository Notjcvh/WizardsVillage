using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Paused and Settings 


    public bool pause { get; private set; }



    //InGame Player 
    
    public bool attack { get; private set; }
    public bool secondaryAttack { get; private set; }
    public bool activateQAbilityy { get; private set; }
    public bool activateWAbility { get; private set; }
    public bool activateEAbility { get; private set; }
    public bool activateRAbility { get; private set; }


    private void Update()
    {
        ///  <summary>
        ///  All Input configurations can be found in the Input Manager.
        ///  Edit --> Project Settings --> Input Manager
        ///  All Inputs will be labeled by number of where they appear
        /// </summary>


        //Pausing
        pause = Input.GetButtonDown("Pause");


        //Attacking 
        attack = Input.GetMouseButtonDown(0);
        secondaryAttack = Input.GetMouseButtonDown(1);

        //Water Special 
        activateQAbilityy = Input.GetButtonDown("Q");

        activateWAbility = Input.GetButtonDown("W");

        activateEAbility = Input.GetButtonDown("E");

        activateRAbility = Input.GetButtonDown("R");
    }
}
