using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    //Attributes
    protected string name;

    public string Name
    {
        get 
        { 
            return name; 
        }
        set 
        {
            name = value; 
        }
    }

    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }    

    public string SuitColor { get; set; }

    private float armorStrenght;


    public SuperHero(string newName, int newHp, string newSuitColor)
    {
        name = newName;
        hp = newHp;
        SuitColor = newSuitColor;
        armorStrenght = 10;
    }

    public void UpdateArmor(float newArmor)
    {
        armorStrenght += newArmor;
        Debug.Log($"\t{name} undateed their armor to {armorStrenght}");
    }
    public void TakeDamage(int inputDamage)
    {
        hp -= inputDamage;
        Debug.Log($"\t{name} take ({inputDamage}) => {name} HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"\t{name} is DEAD.. ");
        }
    }
    public bool IsDead()
    {
        return (hp <= 0);
    }
}