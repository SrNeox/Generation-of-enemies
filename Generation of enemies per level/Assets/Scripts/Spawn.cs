using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private EnemiesMovement _enemy;
    [SerializeField] private TargetMovement _target;

    public void SummonEnemy()
    {
        EnemiesMovement enemy = Instantiate(_enemy);

        enemy.Target(_target);
    }
}
