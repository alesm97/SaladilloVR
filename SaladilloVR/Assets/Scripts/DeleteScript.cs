////////////////////////////////////////////////
// Proyecto: SaladilloVR
// Alumno: Alejandro Segura Meléndez
// Curso: 2017/2018
// Archivo: DeleteScript.cs
////////////////////////////////////////////////
using UnityEngine;
using UnityEngine.UI;

public class DeleteScript : MonoBehaviour
{
    public Text ipAddress;

    public void Click()
    {
        string text = ipAddress.GetComponent<Text>().text;
        if (text.Length > 0)
        {
            ipAddress.GetComponent<Text>().text = text.Substring(0, text.Length - 1);
        }
        
    }
}