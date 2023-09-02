using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IdleState : IBaseState
{
    public void EnterState(AnimationStateMachine stateMachine)
    {
        Debug.Log("pronto");
        Debug.Log("O sol nasceu na fazendinha");

        if(stateMachine.gameObject.name == "Head")
        {
            stateMachine._anim.SetBool("Eat", false); 
        }
    }


    public void UpdateState(AnimationStateMachine stateMachine)
    {
        if(GameManager.Instance._eat == 1)
        {   
            stateMachine.SwitchState(new AnimatedState());
        }
    }
}
