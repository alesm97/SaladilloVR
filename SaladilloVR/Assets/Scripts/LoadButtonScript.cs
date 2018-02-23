////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: LoadButtonScript.cs
////////////////////////////////////////////////

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadButtonScript : MonoBehaviour {

	// Objeto donde se va a crear la informacion de los clientes
	public GameObject information;
	// Prefab de clientes
	public GameObject client;

	/// <summary>
	/// Método que se ejecuta cuando se pulsa el botón load.
	/// </summary>
	/// <remarks>Obtiene la lista de clientes.</remarks>
	public void Click()
	{
		GetClients();
	}

	/// <summary>
	/// Obtiene la lista de clientes.
	/// </summary>
	/// <remarks>Llama a una corrutina que conecta con la Web API para obtener la información.</remarks>
	private void GetClients()
	{
		StartCoroutine(GetClientsWebApi());
	}

	IEnumerator GetClientsWebApi()
	{
		// Se crea la petición a la web api
		using (UnityWebRequest www = UnityWebRequest.Get(Uri.EscapeUriString(String.Format(GameManager.WEP_API_GET_CLIENTS, GameManager.ipAddress))))
		{
			// Hacemos la petición y esperamos que responda
			yield return www.SendWebRequest();
			
			// Acción a realizar si la petición se ha ejecutado sin error
			if (!www.isNetworkError)
			{
				// Se recupera la lista de clientes
				Clientlist clientList = JsonUtility.FromJson<Clientlist>(www.downloadHandler.text);
				for (int i = 0; i < clientList.clients.Length; i++)
				{
					// Creamos el objeto para un cliente
					GameObject clientItem = Instantiate(client);
					// Se asigna el texto que debe mostrar
					clientItem.GetComponentInChildren<Text>().text = clientList.clients[i].dni + " - " + clientList.clients[i].name;
					// Se establece su padre que esté en la escena
					clientItem.transform.SetParent(information.transform);
					clientItem.GetComponent<RectTransform>().localPosition = new Vector3(0, -0.13f*(i+1), 0);
				}
			}
		}
	}

	#region Entidades

	[Serializable]
	public class Client
	{
		public string dni;
		public string name;
	}

	public class Clientlist
	{
		public Client[] clients;
	}

	#endregion
}
