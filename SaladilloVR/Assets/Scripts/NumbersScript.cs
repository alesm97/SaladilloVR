////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: NumberScript.cs
////////////////////////////////////////////////
using UnityEngine;
using UnityEngine.UI;

public class NumbersScript : MonoBehaviour
{
	public string number;
	public Text ipText;
	
	// Use this for initialization
	void Start ()
	{
		GetComponentInChildren<Text>().text = number;
	}

	public void Click()
	{
		ipText.GetComponent<Text>().text += GetComponentInChildren<Text>().text;
	}
}
