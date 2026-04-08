using UnityEngine;

public class Collisiones : MonoBehaviour
{
    //Callbacks
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Choco con player");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("No Choco con Player");
        }
      
    
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player dentro");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player salio");

        }
    }


}
