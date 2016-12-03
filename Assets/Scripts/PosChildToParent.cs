using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PosChildToParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//this.transform.localPosition=Vector3.zero; 
		this.transform.localPosition = new Vector3 (-0.25f,0.15f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
