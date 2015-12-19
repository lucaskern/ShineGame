using UnityEngine;
using System.Collections;

public class SwitchLevel : MonoBehaviour {

	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
}
