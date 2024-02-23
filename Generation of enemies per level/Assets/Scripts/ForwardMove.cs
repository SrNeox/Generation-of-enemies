using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMove : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
