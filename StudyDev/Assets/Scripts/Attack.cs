using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour, IObserver
{
    private Animator _animation;

    void Awake()
    {
        _animation = GetComponent<Animator>();
    }
    public void OnNotify()
    {
        _animation.Play("Attack");
    }
}
