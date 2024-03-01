using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _direction;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _direction.position, _speed * Time.deltaTime);
    }

    public void TakeDirection(Transform direction)
    {
        _direction = direction;
    }
}
