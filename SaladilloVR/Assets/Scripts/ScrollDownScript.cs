////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: ScrollDownScript.cs
////////////////////////////////////////////////
using UnityEngine;

public class ScrollDownScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Animator>().Play("ScrollDown");
	}
	
}
