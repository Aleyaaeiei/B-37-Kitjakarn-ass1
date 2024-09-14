using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Debug.Log("*** Superheros fight!!!!");
        //ใส่ชื่อhpและสีของกัปตัน
        CaptainAmerica captainAmerica = new CaptainAmerica("Steve", 100, "Yellow");
        //ใส่ชื่อhpและสีของไอรอนแมน
        IronMan ironMan = new IronMan("Tony", 100 ,"Red");
        Debug.Log($"IronMan name: {ironMan.IronName}, Hp: {ironMan.IronHp}, Suit Color: {ironMan.IronSuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.CaptainName}, Hp: {captainAmerica.CaptainHp}, Suit Color: {captainAmerica.CaptainSuitColor}");
        ironMan.UpdateStrength(5.25f);
        captainAmerica.UpdateStrength(5.25f);
        //เริ่มต่อสู้
        for ( int i = 0; i<5; i++)
        {
            ironMan.ShootLaser();
            //สุ่มdamageของไอรอนแมน
            int random = Random.Range(10, 21);
            captainAmerica.TakeDamage(random);
            captainAmerica.ThrowShield();
            //สุ่มdamageของกัปตัน
            random = Random.Range(10, 21);
            ironMan.TakeDamage(random);
        }
        
    }    
}
