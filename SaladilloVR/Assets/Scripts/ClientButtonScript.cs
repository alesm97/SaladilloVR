////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: ClientButtonScript.cs
////////////////////////////////////////////////
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ClientButtonScript : MonoBehaviour {

	/// <summary>
	/// Método que se ejecuta al hacer click
	/// </summary>
	public void Click()
	{
		// Llama al método que guarda la indormación del cliente
		LogClient();
	}

	/// <summary>
	/// Guarda la información del cliente
	/// </summary>
	/// <remarks>Llama a una corrutina que conecta con la webapi para guardar la informaciónn</remarks>
	private void LogClient()
	{
		StartCoroutine(LogClientWebApi());
	}

	IEnumerator LogClientWebApi()
	{
		// Construirá la información que se envía a la web de la api
		WWWForm form = new WWWForm();
		form.AddField("dni",GetComponentInChildren<Text>().text.Split('-')[0].Trim());
		form.AddField("name",GetComponentInChildren<Text>().text.Split('-')[1].Trim());
		
		// Crea la petición a la webApi
		using (UnityWebRequest www =
			UnityWebRequest.Post(Uri.EscapeUriString(String.Format(GameManager.WEP_API_LOG_CLIENT, GameManager.ipAddress)),
				form))
		{
			// Envía la petición a la webAPI y espera la respuesta
			yield return www.SendWebRequest();

			// Acción a realizar si la petición se ha ejecutado sin error
			if (!www.isNetworkError)
			{
				// Se accede al as del padre y se ejecuta
				GetComponentInParent<AudioSource>().Play();
			}
		}
	}
}
