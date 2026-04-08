using UnityEngine; //Header



public class DebugText : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake"); // Primero en ejecutar 

    }
    private void OnEnable()
    {
        Debug.Log("OnEnable"); // Segundo a ejecutar
    }   

    //Inicia El Juego  
    void Start()
    {
        Debug.Log("Hello World"); // Tercero a ejecutar

    }


    void Update() // Se ejecuta cada frame
    {
        Debug.Log("Update"); // Se ejecuta cada frame
    }


    void OnDisable()
    {
        Debug.Log("OnDisable"); // Se ejecuta al desactivar el objeto
    }
     void OnDestroy()
    {
        Debug.Log("OnDestroy"); // Se ejecuta al destruir el objeto
    }


    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit"); // Se ejecuta al cerrar la aplicación

    }


    //Callbacks
}
