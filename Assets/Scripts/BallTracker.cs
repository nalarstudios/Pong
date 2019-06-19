using UnityEngine;
using UnityEngine.UI;

public class BallTracker : MonoBehaviour {
    public GameObject ball;
    public GameObject playerScore;
	// Use this for initialization
	void Start () {
        playerScore.GetComponent<Text>().text = "0";
	}
	
	// Update is called once per frame
	void Update () {
        if(ball.transform.position.x > 13)
        {
            Text text = playerScore.GetComponent<Text>();
            int score = int.Parse(text.text);
            score++;
            text.text = score.ToString();
            ball.transform.position = Vector3.zero;
        }
	}
}
