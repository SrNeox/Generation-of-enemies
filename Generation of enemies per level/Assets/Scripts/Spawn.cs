using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.Events;


public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] _spawns;
    [SerializeField] private MoveForward[] _enemy;

    private void Start()
    {
        StartCoroutine(CreateEnemy(2));
    }

    private IEnumerator CreateEnemy(int timeToDelay)
    {
        WaitForSeconds delay = new WaitForSeconds(timeToDelay);

        while (true)
        {
            int numberArray = Random.Range(0, 2);

            for (int i = 0; i < _spawns.Length; i++)
            {
                Transform spawn = _spawns[i];
                MoveForward enemy = _enemy[i];

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
