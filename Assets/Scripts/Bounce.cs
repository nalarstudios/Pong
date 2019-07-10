using UnityEngine;

public class Bounce : MonoBehaviour {
    private Vector3 velocity;
    Rigidbody rb;
    public float speed = 15;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	private void Start ()
    {
        GenVelocity();
    }
    private void GenVelocity()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float z = Random.Range(-1.0f, 1.0f);
        velocity = new Vector3(x, 0, z) * speed;
        rb.velocity = velocity;
    }
    public void Reset()
    {
        gameObject.transform.position = Vector3.zero;
        GenVelocity();

    }
}
