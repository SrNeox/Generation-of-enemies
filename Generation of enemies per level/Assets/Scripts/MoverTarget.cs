using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class MoverTarget : MonoBehaviour
{
    [Header("Изменение скорости")]
    [Space(10)]
    [SerializeField, Range(0f, 1f)] private float _speed;
    [Header("Точки передвижения")]
    [Space(10)]
    [SerializeField] private Transform[] _movePoints;

    private int _currentPoint = 0;
    
    void Update()
    {
        JumpToPoints();
    }

    private void JumpToPoints()
    {
        if(transform.position == _movePoints[_currentPoint].position) 
        {
           _currentPoint = (_currentPoint + 1) % _movePoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _movePoints[_currentPoint].position, _speed);
    }
}
