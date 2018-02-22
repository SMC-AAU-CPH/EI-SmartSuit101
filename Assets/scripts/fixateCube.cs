using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixateCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	  GameObject Guy = GameObject.Find("RokokoGuy");
      GameObject Spine = GameObject.Find("RokokoGuy_Spine");
      GameObject Box = GameObject.Find("Box");

      Vector3 GuySize = Guy.GetComponent<Renderer>().bounds.size;

      Box.transform.localScale = GuySize;

      Box.transform.position = Spine.transform.position;
      Box.transform.rotation = Spine.transform.rotation;
 
	}
}
