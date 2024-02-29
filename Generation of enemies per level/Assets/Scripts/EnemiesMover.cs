using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    [NonSerialized] public Transform _direction;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _direction.position, _speed * Time.deltaTime);
    }
}
