using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PosChildFromParent : MonoBehaviour {
	public GameObject ChildObject;

	// Use this for initialization
	void Start () {
		//this.transform.localPosition=Vector3.zero; 
		//ChildObject = transform.GetChild(0);
		//this.transform.GetChild(0).localPosition 
		//this.transform.GetChild(0).localPosition = new Vector3 (-0.25f,0.15f,0.0f);
		//Debug.Log(this.transform.GetChild (0).name);
		//ChildObject.localPosition = new Vector3 (-0.25f,0.15f,0.0f);
		Transform[] allChildren = GetComponentsInChildren<Transform>();
		foreach (Transform child in allChildren) {
			// do whatever with child transform here
			child.transform.localPosition = Vector3.zero;
			//child.localPosition = new Vector3 (-0.25f,0.15f,0.0f);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
