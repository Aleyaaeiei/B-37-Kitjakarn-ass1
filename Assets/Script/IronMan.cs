using UnityEngine;

public class IronMan : SuperHero
{
  public IronMan (string newName, int newHP, string newSuitcolor)
        : base(newName, newHP, newSuitcolor)
    { 
    }

    public void Fly()
    {
        //
        Debug.Log($"--------{name} is Flying!");
    }
    public void ShootLaser()
    {
        //
        Debug.Log($"========{name} is Shooting Laser!");
    }
  
}
