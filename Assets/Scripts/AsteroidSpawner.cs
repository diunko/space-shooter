using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {
    public GameObject asteroid;
    public Transform asteroidSpawn;
    public float asteroidRate;

    private float nextAsteroid;

    void Update()
    {
        if (Time.time > nextAsteroid)
        {
            nextAsteroid = Time.time + asteroidRate;
            Vector3 p0 = asteroidSpawn.position;
            asteroidSpawn.position = new Vector3(Random.Range(-3.3F,3.3F),p0.y,p0.z);
            Instantiate(
                asteroid,
                asteroidSpawn.position,
                asteroidSpawn.rotation);
        
        }
    }
}
