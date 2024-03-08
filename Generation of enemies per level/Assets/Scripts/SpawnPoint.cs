using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        EnemyMover enemy = Instantiate(_enemy);

        enemy.SetTarget(_target);
    }
}
