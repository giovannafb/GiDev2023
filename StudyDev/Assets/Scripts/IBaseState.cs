using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBaseState
{
    public void EnterState(AnimationStateMachine stateMachine);

    public void UpdateState(AnimationStateMachine stateMachine);
}
