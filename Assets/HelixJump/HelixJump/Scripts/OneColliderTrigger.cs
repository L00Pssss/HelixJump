using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OneColliderTrigger : MonoBehaviour
{
    private Segment lastCollider;

    protected virtual void OnOneTriggerEnter(Collider other) { }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out lastCollider))
        {
            OnOneTriggerEnter(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (lastCollider == other)
            lastCollider = null;
    }

}
