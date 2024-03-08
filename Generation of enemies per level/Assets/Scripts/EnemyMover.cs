using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        Move();
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
