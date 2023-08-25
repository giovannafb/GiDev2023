using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedState : IBaseState
{
    private SnakeMoveControl _snakeMoveControl;
    
    public void EnterState(AnimationStateMachine stateMachine)
    {
        Debug.Log("deu certo");
        stateMachine._anim.SetBool("Eat", true);   
    }

    public void UpdateState(AnimationStateMachine stateMachine)
    {
        if(_snakeMoveControl._eat == 1)
        {   
            //_currentTime = _time;
            stateMachine.SwitchState(new AnimatedState());
        }
    }
}
