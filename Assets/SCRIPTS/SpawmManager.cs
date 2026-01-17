using System.Collections;
using UnityEngine;

public class SpawmManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnposZ = 10;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    [SerializeField] private float spawnIntervalMin = 1f;
    [SerializeField] private float spawnIntervalMax = 3f;


    // Update is called once per frame
    void Start()
    {
        //InvokeRepeating("SpawnRandomInterval", startDelay, spawnInterval);
        StartCoroutine(SpawnAnimalWithRandomInterval());
    }

    private IEnumerator SpawnAnimalWithRandomInterval()
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            SpawnRandomInterval();
            float randomInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            yield return new WaitForSeconds(randomInterval);
        }
    }
    void SpawnRandomInterval()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 10);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
