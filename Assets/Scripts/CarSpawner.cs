using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    public Transform spawnPoint;
    public float spawnRate = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnCars()
    {
        while (true)
        {
            SpawnCar();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnCar()
    {
        Vector3 spawnPos = new Vector3(
        Random.Range(-10f, 10f),  // change width range based on the ramp
        spawnPoint.position.y,
        spawnPoint.position.z);

        GameObject newCar = Instantiate(car, spawnPos, spawnPoint.rotation);

        // give cars random speeds
        CarMover carScript = newCar.GetComponent<CarMover>();
        if (carScript != null)
        {
            carScript.carSpeed = Random.Range(20, 30);
        }
    }
}
