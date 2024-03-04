using System.Collections;
using UnityEngine;

public class Spawn—ontrol : MonoBehaviour
{
    [SerializeField] private Spawn[] _spawns;

    private int _timeDelay = 2;

    private void Start()
    {
        StartCoroutine(Summon(_timeDelay));
    }

    private IEnumerator Summon(int timeToDelay)
    {
        WaitForSeconds delay = new (timeToDelay);
        int firstSpawn = 0;

        while (true)
        {
            int numberSpawn = Random.Range(0, _spawns.Length);

            if (numberSpawn == firstSpawn)
            {
                _spawns[0].SummonEnemy();    
            }
            else
            {
                _spawns[1].SummonEnemy();
            }

            yield return delay;
        }
    }
}
