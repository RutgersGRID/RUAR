using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		AsyncOperation async = Application.LoadLevelAdditiveAsync (1);
		yield return async;
		Debug.Log("Loading complete");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			//Debug.Log ("A key or mouse click has been detected");
			SceneManager.LoadScene (1);
		}
	}
}
