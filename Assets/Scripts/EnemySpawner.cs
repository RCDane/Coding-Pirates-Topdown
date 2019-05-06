using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Vector2 area;
    public float spawnTime;
    public GameObject enemy;
    public Transform player;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer+spawnTime < Time.timeSinceLevelLoad){
            Vector2 spawnPosition = new Vector2(Random.Range(-area.x,area.x),Random.Range(-area.y,area.y));
            GameObject enemyObject = Instantiate(enemy,spawnPosition,Quaternion.identity);
            timer = Time.timeSinceLevelLoad;
            enemyObject.GetComponent<Enemy>().target = player;
            enemyObject.GetComponent<EnemyHit>().target = player;
        }
    }
}
