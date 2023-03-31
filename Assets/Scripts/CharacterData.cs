using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Character", menuName = "CharacterData")]
public class CharacterData : ScriptableObject{
    public string name;
    public int health;
    public int health_reg;
    public int attack_damage;
    public float attack_speed;
    public int attack_range;
    public int armour;
    public int magic_resist;
    public int speed;
    public GameObject armourObject;

}
