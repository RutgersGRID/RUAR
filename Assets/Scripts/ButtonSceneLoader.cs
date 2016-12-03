using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonSceneLoader : MonoBehaviour {

	// Use this for initialization
	public void ClickLoadScene (string sceneName) {
		Debug.Log("Loading scene:" + sceneName);
		SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
		//SceneManager.SetActiveScene (sceneName);
	}
}
