using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		AsyncOperation async = SceneManager.LoadSceneAsync ("250Mural", LoadSceneMode.Additive);
		async.allowSceneActivation = false;
		yield return async;
		Debug.Log("Loading complete");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			//Debug.Log ("A key or mouse click has been detected");
			SceneManager.LoadScene ("250Mural");
		}
	}
}
