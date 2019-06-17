using UnityEngine;

public class Pauser : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        
	}
    public void Pause()
    {
        Time.timeScale = 0;
    }
}
