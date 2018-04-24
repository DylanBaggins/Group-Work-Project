using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCups : MonoBehaviour {

    public GameObject Hostile;
    public Transform spawnPosition; //drag and drop created gameobject (spawn position) on this transform in inspector
    float maxSpawnRateInSeconds = 5f;


    // Use this for initialization
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        //increase spawn rate evrey 30 seconds
        InvokeRepeating("IncreaseSpawnRate", 0f, 15f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(Hostile);
        anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        ScheduleNextEnemySpawn();
    }

    void ScheduleNextEnemySpawn()
    {
        float spawnInSeconds;

        if (maxSpawnRateInSeconds > 3f)
        {
            spawnInSeconds = Random.Range(3f, maxSpawnRateInSeconds);
        }
        else
            spawnInSeconds = 3f;

        Invoke("SpawnEnemy", spawnInSeconds);
    }

    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
            maxSpawnRateInSeconds--;

        if (maxSpawnRateInSeconds == 1f)
            CancelInvoke("IncreaseSpawnRate");
    }
}