using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gira : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up);

		if(Input.anyKeyDown){
			SceneManager.LoadScene ("scene");
		}
		//posdiff = objetouno.position - objetotarget.position; OBTIENE EL VECTOR DE DISTANCIA ENTRE 2 OBJETOS.
		//DontDestroyOnLoad(gameobject); Mantiene un objeto entre escenas
	}
}
