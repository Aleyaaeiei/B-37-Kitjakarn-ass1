using UnityEngine;

public class IronMan : SuperHero
{

    public void Fly()
    {
        //
        Debug.Log($"--------{_name} is Flying!");
    }
    public void ShootLaser()
    {
        //
        Debug.Log($"========{_name} is Shooting Laser!");
    }
  
}
