using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] float _speed;

    private void Update()
    {
        transform.Translate(_direction * _speed);
    }
}
