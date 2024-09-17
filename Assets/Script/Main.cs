using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    IronMan ironMan = new IronMan("Tony", 100, "Red");
    CaptainAmerica captainAmerica = new CaptainAmerica("Steve", 100, "Blue");

    void Start()
    {
      
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Color: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Suit Color: {captainAmerica.SuitColor}");

        ironMan.UpdateArmor(5.25f);
        captainAmerica.UpdateArmor(5.5f);
        
    }

    private void Update()
    {
        if (!ironMan.IsDead() || captainAmerica.IsDead())
        {
            return;
        }
        // Iron man turn
        ironMan.ShootLaser();
        int randomDamage = Random.Range(10, 21);
        captainAmerica.TakeDamage(randomDamage);

        // captain America turn
        captainAmerica.ThrowShield();
        randomDamage = Random.Range(10, 21);
        ironMan.TakeDamage(randomDamage);
    }
}
