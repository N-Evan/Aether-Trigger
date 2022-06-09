using System;
using UnityEngine;

[CreateAssetMenu( fileName = "Entity", menuName = "Entity/New Entity")]
public class Entity : ScriptableObject
{
    public string Name { get; private set; }
    [SerializeField] private int MaxHp; /*{ get; private set; }*/
    public int AttackPower { get; private set; }
    public int Level { get; private set; }
    public float MoveSpeed { get; private set; }

    //public Entity(string name, int maxHp, int atkPokwer, int lvl, float moveSpeed)
    //{
    //    Name = name;
    //    MaxHp = maxHp;
    //    AttackPower = atkPokwer;
    //    Level = lvl;
    //    MoveSpeed = moveSpeed;
    //}
}
