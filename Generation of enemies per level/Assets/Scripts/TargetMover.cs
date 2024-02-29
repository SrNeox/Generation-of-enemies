using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _pointsMove;
    [SerializeField] private float _speed;

    int _pointCurrent = 0;
    private void Update()
    {
        Direction(); 
    }

    private void Direction()
    {
        if (transform.position == _pointsMove[_pointCurrent].position)
        {
            _pointCurrent = (_pointCurrent + 1) % _pointsMove.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _pointsMove[_pointCurrent].position, _speed * Time.deltaTime);

    }
}
