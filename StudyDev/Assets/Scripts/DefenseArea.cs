using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DefenseArea : BaseSubject
{

    [SerializeField] private Transform _detectionPoint;
    [SerializeField] private float _detectionRadius;
    [SerializeField] private LayerMask _detectionLayer;
    [SerializeField] private Attack _fighter;

    void OnEnable()
    {
        AddObserver(_fighter);
    }

    void OnDisable()
    {   
        RemoveObserver(_fighter);
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
