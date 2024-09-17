using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero : MonoBehaviour
{
    //Attributes
    protected string _name;

    public string Name
    {
        get 
        { 
            return _name; 
        }
        set 
        {
            _name = value; 
        }
    }

    protected int hp;
    public int Hp { get { return hp; } set { hp = value; } }    

    public string SuitColor { get; set; }

    private float armorStrenght;


    public void UpdateArmor(float newArmor)
    {
        armorStrenght += newArmor;
        Debug.Log($"\t{_name} undateed their armor to {armorStrenght}");
    }
    public void TakeDamage(int inputDamage)
    {
        hp -= inputDamage;
        Debug.Log($"\t{_name} take ({inputDamage}) => {_name} HP: {hp}");

        if (IsDead())
        {
            Debug.Log($"\t{_name} is DEAD.. ");
        }
    }
    public bool IsDead()
    {
        return (hp <= 0);
    }
}