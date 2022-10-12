using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float TimeBetweenSpawns;

    public AnimationCurve SpawnEvolution;

    //in seconds
    public float GameDuration;

    public BoxCollider2D[] zones;
    public GameObject EnnemyPrefab;
    public Transform EnnemyGroup;
    private float LastSpawn;

    void Update()
    {

        float x = (GameDuration * Time.timeSinceLevelLoad) / 100;
        TimeBetweenSpawns = SpawnEvolution.Evaluate(x / 100f);

        if (Time.time > LastSpawn + TimeBetweenSpawns)
        {
            //Spawns enemies at random positions within the spawner box
            int zone = Random.Range(0, zones.Length);
            Vector2 pos = new Vector2
            (
                Random.Range(zones[zone].bounds.min.x, zones[zone].bounds.max.x),
                Random.Range(zones[zone].bounds.min.y, zones[zone].bounds.max.y)
             );
            Instantiate(EnnemyPrefab, pos, Quaternion.identity, EnnemyGroup);
            LastSpawn = Time.time;
        }
        
    }


}
