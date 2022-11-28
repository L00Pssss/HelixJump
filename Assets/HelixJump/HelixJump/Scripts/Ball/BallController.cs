using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent (typeof(BallMovement) )]
public class BallController : OneColliderTrigger
{
    private BallMovement movement;

    [HideInInspector] public UnityEvent<SegmentType> CollisinSigment;

    private void Start()
    {
        movement = GetComponent<BallMovement>();
    }

    protected override void OnOneTriggerEnter(Collider other)
    {
        Segment segment = other.GetComponent<Segment>();                                //Назначаем сегмент с которым столкнулись
        if (segment != null)
        {
            if (segment.Type == SegmentType.Empty)                                      //Если тип сегмента "Empty" то вызываем метод Fall() класса BallMovement
            {
                movement.Fall(other.transform.position.y);
                movement.floorDest(other);
            }

            if (segment.Type == SegmentType.Default)
            {
                movement.Jump();
            }

            if (segment.Type == SegmentType.Trap || segment.Type == SegmentType.Finish)
            {
                movement.Stop();
            }

            CollisinSigment.Invoke(segment.Type);
        } 
    }

}
