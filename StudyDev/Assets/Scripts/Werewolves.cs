using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Werewolves : BaseSubject
{
    [SerializeField] private Transform _detectionPoint;
    [SerializeField] private float _detectionRadius;
    [SerializeField] private LayerMask _detectionLayer;
    [SerializeField] private LoadVideo _werewolf;

    void OnEnable()
    {
        AddObserver(_werewolf);
    }

    void OnDisable()
    {   
        RemoveObserver(_werewolf);
    }

    void Update()
    {
        if(PlayerDetector())
        {
            Notify();
        }
    }



    bool PlayerDetector()
    {
        return Physics2D.OverlapCircle(_detectionPoint.position, _detectionRadius, _detectionLayer);
    }
}
