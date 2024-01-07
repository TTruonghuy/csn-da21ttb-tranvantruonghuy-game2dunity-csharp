using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Bay : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs; // mảng các gameobject được coi là chướng ngại vật
    public float obstacleSpawnTime;  // thời gian spawn ra chướng ngại vật
    public float TimeDestroy = 10f;  // thời gian tồn tại của chướng ngại vật
    private Rigidbody2D rb;
    float timeSpawnMin = 5;
    float timeSpawnMax = 10;
    private Vector2[] spawnPositions = new Vector2[] {
        new Vector2(3,19),
        new Vector2(11, 17.5f),
        new Vector2(11, 14.5f)
    }; // Mảng các vị trí tạo
     void Update()
    {
        obstacleSpawnTime -= Time.deltaTime;
        if (obstacleSpawnTime <= 0)
        {
            SpawnBoom();
            obstacleSpawnTime = Random.Range(timeSpawnMin,timeSpawnMax);
        }
        obstacleSpawnTime += Time.deltaTime * 0.005f;
    }
    private void SpawnBoom()
    {
        GameObject obstraleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        int randomIndex = Random.Range(0, spawnPositions.Length);
        Vector2 spawnPosition = spawnPositions[randomIndex];
        GameObject spawnedObstracle = Instantiate(obstraleToSpawn, spawnPosition, Quaternion.identity);
        rb = spawnedObstracle.GetComponent<Rigidbody2D>();
        StartCoroutine(DestroyObstracle(spawnedObstracle));
    }
    private IEnumerator DestroyObstracle(GameObject spawnedObstacle)
    {
        yield return new WaitForSeconds(TimeDestroy);
        Destroy(spawnedObstacle);
    }
}
