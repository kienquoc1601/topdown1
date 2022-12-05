using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat 
{
    private int _id;
    private float _hp_max = 0;
    private float _hp_regen = 0;
    private float _shield_max = 0;
    private float _shield_regen = 0;
    private float _armor = 0;
    private float _spd = 0;
    private float _dodge = 0;
    private float _luck = 0;
    private float _damage = 0;
    private float _crit_damage = 0;
    private float _infamy = 0;

    public Stat(float hp_max, float hp_regen, float shield_max, float shield_regen, float armor, float spd, float dodge, float luck, float damage, float crit_damage, float infamy)
    {
        _hp_max = hp_max;
        _hp_regen = hp_regen;
        _shield_max = shield_max;
        _shield_regen = shield_regen;
        _armor = armor;
        _spd = spd;
        _dodge = dodge;
        _luck = luck;
        _damage = damage;
        _crit_damage = crit_damage;
        _infamy = infamy;
    }

    public float Hp_max { get => _hp_max; set => _hp_max = value; }
    public float Hp_regen { get => _hp_regen; set => _hp_regen = value; }
    public float Shield_max { get => _shield_max; set => _shield_max = value; }
    public float Shield_regen { get => _shield_regen; set => _shield_regen = value; }
    public float Armor { get => _armor; set => _armor = value; }
    public float Spd { get => _spd; set => _spd = value; }
    public float Dodge { get => _dodge; set => _dodge = value; }
    public float Luck { get => _luck; set => _luck = value; }
    public float Damage { get => _damage; set => _damage = value; }
    public float Crit_damage { get => _crit_damage; set => _crit_damage = value; }
    public float Infamy { get => _infamy; set => _infamy = value; }
}
