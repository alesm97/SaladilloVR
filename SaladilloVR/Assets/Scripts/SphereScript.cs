////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: SphereScript.cs
////////////////////////////////////////////////
using UnityEngine;

public class SphereScript : MonoBehaviour
{

	// Material de la esfera cuando no está siendo mirada
	public Material sphereMaterial;
	// Material de la esfera cuando está siendo mirada
	public Material sphereHoverMaterial;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<Renderer>().material = sphereMaterial;
	}

	/// <summary>
	/// Método que se ejecuta cuando se empieza a mirar la esfera.
	/// </summary>
	/// <remarks> cambia el material de la esfera al indicado que se debe mostrar cuando se mira la esfera.</remarks>
	public void HoveredSphere()
	{
		GetComponent<Renderer>().material = sphereHoverMaterial;
	}
	
	/// <summary>
	/// Método que se ejecuta cuando se deja de mirar la esfera.
	/// </summary>
	/// <remarks> cambia el material de la esfera al indicado que se debe mostrar cuando se deja de mirar la esfera.</remarks>
	public void NotHoveredSphere()
	{
		GetComponent<Renderer>().material = sphereMaterial;
	}
	
	
}
