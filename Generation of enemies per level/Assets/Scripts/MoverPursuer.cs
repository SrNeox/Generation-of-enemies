using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoverPursuer : MonoBehaviour
{
    [SerializeField] private float _speed;
    public Transform _target;

    private void Update()
    {
        Chase(_target);
    }

    public void Chase(Transform _target)
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed);
    }
}
