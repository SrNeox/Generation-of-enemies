using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;


public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawns;
    [SerializeField] private ForwardMove[] _enemy;

    private int _timeDelay = 2;

    private void Start()
    {
        StartCoroutine(CreateEnemy(_timeDelay));
    }

    private IEnumerator CreateEnemy(int timeToDelay)
    {
        WaitForSeconds delay = new WaitForSeconds(timeToDelay);

        int minSpawnNumber = 0;
        int maxSpawnNumber = 2;

        while (true)
        {
            int numberArray = Random.Range(minSpawnNumber, maxSpawnNumber);

            for (int i = 0; i < _spawns.Length; i++)
            {
                Transform spawn = _spawns[i];
                ForwardMove enemy = _enemy[i];

                if (i == numberArray)
                {
                    enemy.transform.position = spawn.position;
                    var spawnedEnemy = Instantiate(enemy);
                }
            }

            yield return delay;
        }
    }
}
