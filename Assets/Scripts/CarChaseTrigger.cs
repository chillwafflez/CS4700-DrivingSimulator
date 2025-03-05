//using UnityEngine;

//public class CarChaseTrigger : MonoBehaviour
//{

//    public GameObject largeCarPrefab;
//    public Transform spawnPoint;
//    private bool hasSpawned = false;

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player") && !hasSpawned) // Ensure only player triggers it once
//        {
//            hasSpawned = true;
//            SpawnLargeCar(other.transform); // Pass player's position
//        }
//    }

//    void SpawnLargeCar(Transform playerTransform)
//    {
//        if (largeCarPrefab == null || spawnPoint == null) return;

//        // Spawn the large car slightly behind the player
//        Vector3 spawnPos = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z - 10f);
//        GameObject largeCar = Instantiate(largeCarPrefab, spawnPos, Quaternion.identity);

//        // Make sure the large car moves forward
//        BusMover carMover = largeCar.GetComponent<BusMover>();
//        if (carMover != null)
//        {
//            carMover.isChasing = true;
//        }

//        // Check if large car has reached end point


//    }

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
