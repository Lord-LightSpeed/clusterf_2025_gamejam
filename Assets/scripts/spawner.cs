using UnityEngine;
using System.Collections;
using Unity.Mathematics;
public class spawner : MonoBehaviour
{
    public GameObject enemy;

    public float minEnemies; //minimum amount of enemies that can spawn in a cluster
    public float maxEnemies; //maximum amount of enemies that can spawn in a cluster

    public float minCooldown; //minimum cooldown until next cluster of enemies spawn
    public float maxCooldown; //^^ what do you think this does ^^

    public float minDistance; //minimum distance the enemies can spawn from the player
    public float maxDistance; //you get the idea

    public float minCluster; //minimum distance the enemies can spawn from the center of the cluster (how dispersed enemy clusters can be)
    public float maxCluster; //you know where this is going

    private float enemyCount;
    private float spawnCooldown;
    private float enemyDistance;
    private float cluster;
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }
    private IEnumerator SpawnLoop()
    {
        int spawnedcount = 0;
        while (true)
        {
            spawnCooldown = UnityEngine.Random.Range(math.pow((math.cos(spawnedcount / (math.PI2 * 10f) ) + 0.1f), 2) * maxCooldown, math.pow((math.cos(spawnedcount / (math.PI2 * 10f) ) + 0.1f), 2) * minCooldown);
            yield return new WaitForSeconds(spawnCooldown);
            Spawn();
            spawnedcount++;
        }
    }
    private void Spawn()
    {
        enemyCount = UnityEngine.Random.Range(maxEnemies, minEnemies); 
        enemyDistance = UnityEngine.Random.Range(maxDistance, minDistance);
        if (enemy == null) { return; };
        float angle = UnityEngine.Random.Range(0f, Mathf.PI * 2f);
        Vector2 pos = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * enemyDistance + (Vector2)transform.position;
        for (int i = 0; i < enemyCount; i++)
        {
            cluster = UnityEngine.Random.Range(maxCluster, minCluster);
            float angle2 = UnityEngine.Random.Range(0f, Mathf.PI * 2f);
            Vector2 pos2 = new Vector2(Mathf.Cos(angle2), Mathf.Sin(angle2)) * cluster + pos;
            Instantiate(enemy, pos2, Quaternion.identity);
        }
    }
}