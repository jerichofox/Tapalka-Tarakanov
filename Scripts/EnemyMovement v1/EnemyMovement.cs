using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    float _speed;
    [SerializeField]
    float _rotationSpeed;

    Rigidbody2D _rigidbody;
    TargetAwarenessController _targetAwarenessController;
    Vector2 _targetDirection;
    float _changeDirectionCooldown;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _targetAwarenessController = GetComponent<TargetAwarenessController>();
        _targetDirection = transform.up;
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();

    }

    void UpdateTargetDirection()
    {
        HandleRandomDirectionChange();
        HandleTargetTargeting();
          
    }

    void HandleRandomDirectionChange()
    {
        _changeDirectionCooldown -= Time.deltaTime;

        if (_changeDirectionCooldown <= 0)
        {
            float angleChange = Random.Range(-90f, 90f);
            Quaternion rotation = Quaternion.AngleAxis(angleChange, transform.forward);
            _targetDirection = rotation * _targetDirection;

            _changeDirectionCooldown = Random.Range(1f, 5f);
        }
    }

    void HandleTargetTargeting()
    {
        if (_targetAwarenessController.AwareOfTarget)
        {
            _targetDirection = _targetAwarenessController.DirectionToTarget;
        }
    }

    void RotateTowardsTarget()
    {        

        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);

        _rigidbody.SetRotation(rotation);
    }

    void SetVelocity()
    {        
         _rigidbody.velocity = transform.up * _speed;        
    }
}
