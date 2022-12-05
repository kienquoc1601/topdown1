using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{   
    
    private string _name = "noname";
    private string _description = "insert desc";
    private int _rarity = 1; // for item generation
    private int _cost = 0;
    private int _grade = 1; // for item generation
    private Stat _stat_modifier; // for item generation

    private int _firing_mode = 1;
    private int _armor_pen = 0;
    private float _damage = 1.0f;
    private float _elemental_multiplier = 0;
    private float _range = 50f;
    private float _fire_rate = 0.5f;
    private float _burst_shot = 3.0f;
    private float _deviation = 0.1f;
    private float _recoil = 0.1f;
    private float _control = 0.1f;
    private float _crit_chance = 0.1f;
    private float _crit_damage = 0.1f;
    private float _reload_times = 2f;
    private float _mag_size = 10f;

    private string _img = "aaa";
    private string _model = "aaa";
}
