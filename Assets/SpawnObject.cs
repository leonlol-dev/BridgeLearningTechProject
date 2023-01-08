using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    //Prefabs
    [SerializeField] private GameObject barrel;
    [SerializeField] private GameObject capsule;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cube;
    [SerializeField] private Transform spawnPoint;

    public float spawnRate;

    private Collider spawnBoundaries;
    private float nextTimeToSpawn;

    private void Start()
    {
        spawnBoundaries = GetComponent<Collider>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            nextTimeToSpawn = Time.time + 1f / (spawnRate);
            Spawn();
        }
    }

    void Spawn()
    {
        SetSpawnPoint();
        int chance = Random.Range(1, 4);
        GameObject spawnedObject;
        switch(chance)
        {
            case 1:
                spawnedObject = Instantiate(barrel, spawnPoint.position, barrel.transform.rotation);
                break;

            case 2:
                spawnedObject = Instantiate(capsule, spawnPoint.position, barrel.transform.rotation);
                break;

            case 3:
                spawnedObject = Instantiate(sphere, spawnPoint.position, barrel.transform.rotation);
                break;

            case 4:
                spawnedObject = Instantiate(cube, spawnPoint.position, barrel.transform.rotation);
                break;
        }
        
    }

    void SetSpawnPoint()
    {
        spawnPoint.position = RandomPointInBounds(spawnBoundaries.bounds);
    }

    public static Vector3 RandomPointInBounds(Bounds bounds)
    {
        return new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            Random.Range(bounds.min.z, bounds.max.z)
        );
    }
}
