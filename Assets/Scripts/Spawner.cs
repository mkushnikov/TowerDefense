using System.Collections;
using UnityEngine;

namespace Spawner
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _enemyPrefab;
        [SerializeField] private int _waveSize;
        [SerializeField] private float _spawnRate;

        private void Start()
        {
            if (_enemyPrefab != null)
            {
                StartCoroutine(SpawnWave(_enemyPrefab, _waveSize, _spawnRate));
            }
        }

        public IEnumerator SpawnWave(GameObject spawningPrefab, int number, float spawnRate)
        {
            Debug.Log("CR started");
            while (number-- != 0)
            {
                Debug.Log("Spawn");
                Instantiate(spawningPrefab, transform.position, Quaternion.identity);
                if (number != 0)
                {
                    yield return new WaitForSeconds(spawnRate);
                }
            }
            Debug.Log("CR ended");
        }
    }
}
