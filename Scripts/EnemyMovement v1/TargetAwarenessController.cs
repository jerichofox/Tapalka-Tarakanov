using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAwarenessController : MonoBehaviour
{
    public bool AwareOfTarget { get; private set; }
    public Vector2 DirectionToTarget { get; private set; }
    [SerializeField]
    float _targetAwarenessDistance;
    Transform _target;

    private void Awake()
    {
        _target = FindObjectOfType<TargetMovement>().transform;
    }

    private void Update()
    {
        Vector2 enemyToTargetVector = _target.position - transform.position;
        DirectionToTarget = enemyToTargetVector.normalized;

        if(enemyToTargetVector.magnitude <= _targetAwarenessDistance)
        {
            AwareOfTarget = true;
        }
        else
        {
            AwareOfTarget = false;
        }
    }
}
