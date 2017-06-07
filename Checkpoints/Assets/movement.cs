using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {

	void Start(){
		if (PlayerPrefs.HasKey ("PositionX")) {
			transform.position = new Vector3 (PlayerPrefs.GetFloat ("PositionX"),PlayerPrefs.GetFloat ("PositionY"),PlayerPrefs.GetFloat ("PositionZ"));
		} else {
			transform.position = new Vector3 (-1f,1f,8.5f);
		}
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetAxis ("Horizontal") != 0){
			float mov = Input.GetAxis ("Horizontal");
			transform.Translate (Vector3.forward * Time.deltaTime * mov * 3f);
		}

	}

	void OnTriggerEnter(Collider col){
		PlayerPrefs.SetFloat ("PositionX", -1f);
		PlayerPrefs.SetFloat ("PositionY", 1f);
		PlayerPrefs.SetFloat ("PositionZ", col.transform.position.z - 0.5f);
		if(col.name == "fourCheck"){
			PlayerPrefs.SetFloat ("PositionZ", 8.5f);
			SceneManager.LoadScene ("scene2");
		}
	}
}
