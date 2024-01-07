using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs; // mảng các gameobject được coi là chướng ngại vật
    public float obstacleSpawnTime;  // thời gian spawn ra chướng ngại vật
    public float obstracleSpeed = 5f;  // vận tốc của chướng ngại vật
    public float TimeDestroy = 10f;  // thời gian tồn tại của chướng ngại vật
    private void Update()
    {
        obstacleSpawnTime -= Time.deltaTime;
            if ( obstacleSpawnTime <= 0)
            {
                Spawnbox();
                obstacleSpawnTime = Random.Range(3,10);
            }
        obstacleSpawnTime += Time.deltaTime * 0.05f;
        obstracleSpeed +=  Time.deltaTime * 0.01f;
    }
    public void Spawnbox()
    {  
        GameObject obstraleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        GameObject spawnedObstracle = Instantiate(obstraleToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D obstracleRB = spawnedObstracle.GetComponent<Rigidbody2D>();
        obstracleRB.velocity = Vector2.left * obstracleSpeed;
        StartCoroutine(DestroyObstracle(spawnedObstracle));
    }
    private IEnumerator DestroyObstracle(GameObject spawnedObstacle)
    {
        yield return new WaitForSeconds(TimeDestroy);
        Destroy(spawnedObstacle);
    }
}


