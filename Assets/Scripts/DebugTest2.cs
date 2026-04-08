using Mono.Cecil.Cil;
using UnityEngine;

public class DebugTest2 : MonoBehaviour
{
    public DataClass dataClass = new(150, false);

    public DataStruct dataStruct = new();
    
    
  public TypeText _typeText;



    /*
    public void Start()
    {

        dataStruct.SetHealth(100);

        Debug.Log(dataStruct.IsActive);
        

        Debug.Log(dataStruct.SetBoolVariable(true, "Todo en uno"));

      



        Debug.Log(dataClass.health);
        Debug.Log(dataClass.IsActive);
        Debug.Log(dataClass.speed);
    }

    [ContextMenu("Hacer daño")]
   public void TakeDamageFunc()
    {
        dataClass.TakeDamage(5);
    }

    */



    public void Start()
    {
        switch (_typeText)
        {
            case TypeText.Hi:
                Debug.Log("Hi");
                Debug.Log("Good Morning");
                break;

            case TypeText.Bye:
                Debug.Log("Bye");
                Debug.Log("Hi");
                break;
            case TypeText.Fuck_u:
                Debug.Log("Good Morning");
                Debug.Log("Bye");
                break;
        }
    }
}
