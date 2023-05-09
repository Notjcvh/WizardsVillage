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
    public bool activateQAbility { get; private set; }
    public bool activateWAbility { get; private set; }
    public bool activateEAbility { get; private set; }
    public bool activateRAbility { get; private set; }

    public List<bool> sequencedInputs;

    private void Update()
    {

        //Pausing
        pause = Input.GetButtonDown("Pause");


        //Attacking 
        attack = Input.GetMouseButtonDown(0);
        secondaryAttack = Input.GetMouseButtonDown(1);

        //Water Special 
        activateQAbility = Input.GetButtonDown("Q");

        activateWAbility = Input.GetButtonDown("W");

        activateEAbility = Input.GetButtonDown("E");

        activateRAbility = Input.GetButtonDown("R");

        sequencedInputs = new List<bool> {attack, secondaryAttack, activateQAbility, activateWAbility, activateEAbility, activateRAbility};
    }
}
