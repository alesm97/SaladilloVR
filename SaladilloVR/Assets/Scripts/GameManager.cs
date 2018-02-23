////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: GameManager.cs
////////////////////////////////////////////////
public static class GameManager
{

	// Clave para al dirección IP
	public const string IP_ADDRESS = "IPAddress";
	// Variabl para almacenar la dirección IP de la web api
	public static string ipAddress;
	
	// Constante con la URL del métpdp de la web API para guardar un cliente
	public const string WEP_API_LOG_CLIENT = "http://{0}/SaladilloVR/api/SaladilloVR/LogClient";
	// Constante con la URL del método de la web API para comprobar la conectividad
	public const string WEP_API_CHECK_CONNECTIVITY = "http://{0}/SaladilloVR/api/SaladilloVR/CheckConnectivity";
	// Constante con la URL del método de la web API para conseguir los clientes
	public const string WEP_API_GET_CLIENTS = "http://{0}/SaladilloVR/api/SaladilloVR/GetClients";
}
