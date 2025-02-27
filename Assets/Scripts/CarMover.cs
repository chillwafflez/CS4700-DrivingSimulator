using UnityEngine;

public class CarMover : MonoBehaviour
{
    public int carSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    // destroy car once it touches the bottom ramp
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Road1"))
        {
            Destroy(gameObject);
        }
    }
}
