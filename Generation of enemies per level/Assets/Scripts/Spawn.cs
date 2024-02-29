using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;



public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _pointSpawns;
    [SerializeField] private Move[] _enemys;

    private Move _spawnedEnemy;

    private Vector3[] _direction = { new(2, 0, 5), new(-2, 0, 4) };

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
                _spawnedEnemy = Instantiate(_enemys[numberSpawn]);

                _spawnedEnemy._direction = _direction[numberSpawn];
            }
            else
            {
                _spawnedEnemy = Instantiate(_enemys[numberSpawn]);

                _spawnedEnemy._direction = _direction[numberSpawn];
            }

            yield return delay;
        }
    }

    private void PositionEnemy()
    {
        _enemys[0].transform.position = _pointSpawns[0].position;
        _enemys[1].transform.position = _pointSpawns[1].position;
    }
}
