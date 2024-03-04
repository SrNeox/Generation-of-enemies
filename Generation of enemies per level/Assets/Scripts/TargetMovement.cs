
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _pointsMove;
    [SerializeField] private float _speed;

    private int _pointCurrent = 0;

    private void Update()
    {
        MovePoint();
    }

    private void MovePoint()
    {
        if (transform.position == _pointsMove[_pointCurrent].position)
        {
            _pointCurrent = (++_pointCurrent) % _pointsMove.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _pointsMove[_pointCurrent].position, _speed * Time.deltaTime);
    }
}
