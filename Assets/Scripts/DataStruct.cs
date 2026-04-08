using UnityEngine;


[System.Serializable]
public class DataClass
{
    public int health;
   public bool IsActive;
    public float speed;



    public void SetHealth(int health)
    {
        this.health = health;
        Debug.Log ("Se esta guardando la vida "+ health);
    }

  
    public bool SetBoolVariable(bool _state, string menssage)
    {
        IsActive = _state;
        Debug.Log(menssage);
        return IsActive;
    }
  
    public void TakeDamage(int damageCount)
    {
        health =  health-damageCount;

    }

    private float GetSpeed()
    {
        return speed;
    }

    public DataClass()
    {
        health = 100;
        IsActive = true;
        speed = 5f;
    }

    public DataClass(int health, bool isActive, float speed)
    {
        this.health=health;
        this.IsActive = isActive;
        this.speed = speed;
    }

    public DataClass(int health, bool isActive)
    {
        this.health = health;
        this.IsActive = isActive;
    }



 //   public DataClass()


}

[System.Serializable]
public struct DataStruct
{
   public float HP;
   public float speed;
    public bool IsActive;



    public void SetHealth(float health)
    {
        {
            HP = health;
        }

    }

    public float GetHP()
    {
        return HP;
    }

}




public enum TypeText
{
    Hi,
    Bye,
    Fuck_u

}