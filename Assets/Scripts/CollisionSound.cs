using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour {

    public AudioSource tickSource;

	// Use this for initialization
	void Start ()
    {
        tickSource = GetComponent<AudioSource>();
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collidable")
        {
            tickSource.Play();
        }
    }
}
