
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _pointsMove;
    [SerializeField] private float _speed;

    private int _pointIndex = 0;

    private void Update()
    {
        MovePoint();
    }

    private void MovePoint()
    {
        if (transform.position == _pointsMove[_pointIndex].position)
        {
            _pointIndex = (++_pointIndex) % _pointsMove.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _pointsMove[_pointIndex].position, _speed * Time.deltaTime);
    }
}
