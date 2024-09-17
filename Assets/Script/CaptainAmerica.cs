using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHP, string newSuitcolor)
        : base(newName, newHP, newSuitcolor)
    {
    }

    public void LeapAndJump()
    {
        Debug.Log($"--------{name} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={name} is Trowing Shield!!!");

    }
    
}
