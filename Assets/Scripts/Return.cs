using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    private SceneChanger changer;
	// Use this for initialization
	void Start ()
    {
        changer = GetComponent<SceneChanger>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            changer.ChangeScene(-1);
            print("Deathhh");
        }
    }
}
