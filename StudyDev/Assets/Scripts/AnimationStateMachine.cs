using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateMachine : MonoBehaviour
{
    public IBaseState _currentState {get; private set;}
    public Animator _anim {get; private set;}

    void Start()
    {
        SwitchState(new IdleState());
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        _currentState.UpdateState(this);
    }

    public void SwitchState(IBaseState baseState)
    {
        _currentState = baseState;
        _currentState.EnterState(this);
    }
}
