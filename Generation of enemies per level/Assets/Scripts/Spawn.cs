using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;



public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _pointSpawns;
    [SerializeField] private EnemiesMovement[] _enemies;
    [SerializeField] private Transform[] _targets;

    private EnemiesMovement _spawnedEnemy;

    private readonly int _timeDelay = 2;

    private void Start()
    {
        PositionEnemy();
        StartCoroutine(CreateEnemy(_timeDelay));
    }

    private IEnumerator CreateEnemy(int timeToDelay)
    {
        WaitForSeconds delay = new WaitForSeconds(timeToDelay);

        while (true)
        {
            int numberSpawn = Random.Range(0, _pointSpawns.Length);

            int firstSpawn = 0;

            if (numberSpawn == firstSpawn)
            {
                _spawnedEnemy = Instantiate(_enemies[numberSpawn]);

                _spawnedEnemy.TakeDirection(_targets[numberSpawn]);
            }
            else
            {
                _spawnedEnemy = Instantiate(_enemies[numberSpawn]);

                _spawnedEnemy.TakeDirection(_targets[numberSpawn]);
            }

            yield return delay;
        }
    }

    private void PositionEnemy()
    {
        _enemies[0].transform.position = _pointSpawns[0].position;
        _enemies[1].transform.position = _pointSpawns[1].position;
    }
}
