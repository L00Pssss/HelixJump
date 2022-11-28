using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallEvents : MonoBehaviour
{
    [SerializeField] protected BallController ballController;

    protected virtual void Awake()
    {
        ballController.CollisinSigment.AddListener(OnBallCollisionSegment);
    }

    protected virtual void OnDestroy()
    {
        ballController.CollisinSigment.RemoveListener(OnBallCollisionSegment);
    }
    //event virtual
    protected virtual void OnBallCollisionSegment(SegmentType type)
    {
       
    }
}
