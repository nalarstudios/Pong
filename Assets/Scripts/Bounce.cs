using UnityEngine;

public class Bounce : MonoBehaviour {
    private Vector3 velocity;
	private void Start ()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        velocity = new Vector3(x, 0, z);

    }
    private void Update()
    {
        transform.Translate(velocity);
    }
}
