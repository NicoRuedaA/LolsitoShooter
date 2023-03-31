using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour{
    
    private static PlayerManager _instance;

    public static PlayerManager instance{
        get{
            if (_instance == null){
                Debug.Log("Player Manager is Null!!!");
            }

            return _instance;
        }
    }


    public CharacterData m_data;
    private string m_name;
    private int m_health;
    private int m_health_reg;
    private int m_attack_damage;
    private float m_attack_speed;
    private int m_attack_range;
    private int m_armour;
    private int m_magic_resist;
    private int m_speed;
    private GameObject m_armourObject;


    private void Awake(){
        _instance = this;
    }

    private void Start(){
        m_name = m_data.name;
        m_health = m_data.health;
        m_health_reg = m_data.health_reg;
        m_attack_damage = m_data.attack_damage;
        m_attack_speed = m_data.attack_speed;
        m_attack_range = m_data.attack_range;
        m_armour = m_data.armour;
        m_magic_resist = m_data.magic_resist;
        m_speed = m_data.speed;
        m_armourObject = m_data.armourObject;
    }

    public int getSpeed(){
        return m_speed;
    }
    
    public float get_attack_range(){
        return m_attack_range;
    }
    
    
}
