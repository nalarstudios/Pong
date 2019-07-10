using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void ChangeScene (int index)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
        Debug.Log("Made It");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

}
