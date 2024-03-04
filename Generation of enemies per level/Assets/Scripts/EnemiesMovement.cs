using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private TargetMovement _target;

    private void Update()
    {
        Move(_target);
    }

    public void Target(TargetMovement target)
    {
        _target = target;
    }

    private void Move(TargetMovement target)
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
