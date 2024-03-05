using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private TargetMover _target;

    public void SummonEnemy()
    {
        EnemyMover enemy = Instantiate(_enemy);

        enemy.TakeTarget(_target);
    }
}
