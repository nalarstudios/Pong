using UnityEngine;

public class InputDetectorAndMover : MonoBehaviour {
    public float speed = 0.2f;

    private void Update()
    {
        float velocity = Input.GetAxis("Vertical") * speed;
        gameObject.transform.Translate(Vector3.forward * velocity);

    }
}
