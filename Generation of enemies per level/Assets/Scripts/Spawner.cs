using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawns;

    private int _timeDelay = 2;

    private void Start()
    {
        StartCoroutine(Spawn(_timeDelay));
    }

    private IEnumerator Spawn(int timeToDelay)
    {
        WaitForSeconds delay = new (timeToDelay);

        while (true)
        {
            int numberSpawn = Random.Range(0, _spawns.Length);

            _spawns[numberSpawn].SummonEnemy();

            yield return delay;
        }
    }
}
