using UnityEngine;
using System.Collections;

public class holdFlashlight : MonoBehaviour {



	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		var pos = Input.mousePosition;
		pos.z = 0;
		pos = Camera.main.ScreenToWorldPoint(pos);
		transform.position = pos;
	}
}
