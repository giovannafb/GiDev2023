using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IBaseState
{
    //Tentei fazer com que a animação ativasse e desativasse, mas também não funciona
    private float _time = 100f;
    private float _currentTime;

    private SnakeMoveControl _snakeMoveControl;
    void Awake()
    {
        //_snakeMoveControl = GetComponent<SnakeMoveControl>();
        _currentTime = _time;
    }

    void Update()
    {
       _currentTime -= 1 * Time.deltaTime;
    }

    public void EnterState(AnimationStateMachine stateMachine)
    {
        Debug.Log("pronto");
        stateMachine._anim.SetBool("Eat", false);
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
