using UnityEngine;

public class Bounce : MonoBehaviour {
    private Vector3 velocity;
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	private void Start ()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        velocity = new Vector3(5.0f, 0, 5.9f);
        rb.velocity = velocity;
    }
    private void Update()
    {
        //transform.Translate(velocity);
    }
}
