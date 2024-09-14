using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica
{
    public string CaptainName;
    public int CaptainHp;
    public string CaptainSuitColor;
    private float captainArmorStrength = 10;

    public CaptainAmerica(string newName,int newHp,string newSuitColor) 
    {
        //ใส่ชื่อhpและสีของกัปตัน
        CaptainName = newName;
        CaptainHp = newHp;
        CaptainSuitColor = newSuitColor;
    }
    public void LeapAndJump()
    {
        Debug.Log($"--------{CaptainName} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={CaptainName} is Trowing Shield!!!");

    }
    public void UpdateStrength(float strength)
    {
        captainArmorStrength += strength;
        Debug.Log($"{CaptainName} undateed their armor to {captainArmorStrength}");
    }
    public void TakeDamage(int damage)
    {
        CaptainHp -= damage;
        Debug.Log($"{CaptainName} take {damage} damage hp: {CaptainHp}");
    }
}
