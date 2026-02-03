using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform player;
    public float spawnDistance = 20f;
    public float minY = 1f;
    public float maxY = 5f;
    
    float lastSpawnX = 0;
    
    void Update()
    {
        if(player.position.x > lastSpawnX - spawnDistance)
        {
            SpawnCoin();
        }
    }
    
    void SpawnCoin()
    {
        float randomY = Random.Range(minY, maxY);  // always less than 0.3
        float spawnX = lastSpawnX + Random.Range(5f, 10f);

        Vector3 spawnPos = new Vector3(spawnX, randomY, 0);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);

        lastSpawnX = spawnX;
    }

}