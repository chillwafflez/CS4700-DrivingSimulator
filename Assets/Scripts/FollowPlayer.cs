using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, -9);
    private float horizontalInput;
    private float forwardInput;
    private float turnSpeed = 45.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // note: change camera view after start
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 
        //transform.position = player.transform.position + offset;

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.position = player.transform.position + player.transform.rotation * offset;

        Quaternion targetRotation = player.transform.rotation * Quaternion.Euler(0, horizontalInput * turnSpeed * Time.deltaTime, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.1f);

    }
}
