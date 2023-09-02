using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedState : IBaseState
{
    public void EnterState(AnimationStateMachine stateMachine)
    {
        Debug.Log("deu certo");
        
        stateMachine._anim.SetBool("Eat", true); 
    }

    public void UpdateState(AnimationStateMachine stateMachine)
    {
        if(GameManager.Instance._eat == 0)
        {   
            stateMachine.SwitchState(new IdleState());
        }
    }
}
