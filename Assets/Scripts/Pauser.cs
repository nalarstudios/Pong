using UnityEngine;

public class Pauser : MonoBehaviour {
public bool isPaused = false;
    // Use this for initialization
    void Start ()
    {
        
	}
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            Toggle();
        }
    }
    public void Toggle()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
