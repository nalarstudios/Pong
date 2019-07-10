using UnityEngine;
using System.Collections;

// Find the GameObject named Hand and rotate it every frame

public class AiControl : MonoBehaviour
{
    public GameObject ball;
    public float minSpeed = 6.0f;
    public float maxSpeed = 14.0f;
    private float speed;
    private Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        speed = Random.Range(minSpeed,maxSpeed);
        if (ball.transform.position.z < gameObject.transform.position.z)
        {
            Vector3 downVelocity = new Vector3(0, 0, -1) * speed;
            rb.velocity = downVelocity;
        }
        else if (ball.transform.position.z > gameObject.transform.position.z)
        {
            Vector3 upVelocity = new Vector3(0, 0, 1) * speed;
            rb.velocity = upVelocity;
        }
    }
}