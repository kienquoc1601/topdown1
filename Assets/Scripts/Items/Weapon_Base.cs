using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Base : Equipment_Base
{
    //int firing_mode : using int to determine the firemode(0-auto, 1-semi,2-burst,3-charge)
    //int armor pen : using int to determine if the weapon is AP or not (0-no , 1 - yes)
    //float burst_shot : determine the number of shot fired in one burst if on burst mode

    
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

    //list contain action for each condition that draw from a masterclass contain all weapons action
    private string[] _onShoot = { };
    private string[] _onReload = { };
    private string[] _onHit = { };
    private string[] _onCrit = { };

    //Contructor
    public Weapon_Base(string name, int slot, string description, string code, int rarity, int base_cost, int grade, Stat stat_modifiers, string item_img, string item_model, int firing_mode, int armor_pen, float damage, float elemental_multiplier, float range, float fire_rate, float burst_shot, float deviation, float recoil, float control, float crit_chance, float crit_damage, float reload_times, float mag_size, string[] onShoot, string[] onReload, string[] onHit, string[] onCrit) : base(name, slot, description, code, rarity, base_cost, grade, stat_modifiers, item_img, item_model)
    {
        _firing_mode = firing_mode;
        _armor_pen = armor_pen;
        _damage = damage;
        _elemental_multiplier = elemental_multiplier;
        _range = range;
        _fire_rate = fire_rate;
        _burst_shot = burst_shot;
        _deviation = deviation;
        _recoil = recoil;
        _control = control;
        _crit_chance = crit_chance;
        _crit_damage = crit_damage;
        _reload_times = reload_times;
        _mag_size = mag_size;
        _onShoot = onShoot;
        _onReload = onReload;
        _onHit = onHit;
        _onCrit = onCrit;
        
    }


    //GetSet
    public int Firing_mode { get => _firing_mode; set => _firing_mode = value; }
    public int Armor_pen { get => _armor_pen; set => _armor_pen = value; }
    public float Damage { get => _damage; set => _damage = value; }
    public float Elemental_multiplier { get => _elemental_multiplier; set => _elemental_multiplier = value; }
    public float Range { get => _range; set => _range = value; }
    public float Fire_rate { get => _fire_rate; set => _fire_rate = value; }
    public float Burst_shot { get => _burst_shot; set => _burst_shot = value; }
    public float Deviation { get => _deviation; set => _deviation = value; }
    public float Recoil { get => _recoil; set => _recoil = value; }
    public float Control { get => _control; set => _control = value; }
    public float Crit_chance { get => _crit_chance; set => _crit_chance = value; }
    public float Crit_damage { get => _crit_damage; set => _crit_damage = value; }
    public float Reload_times { get => _reload_times; set => _reload_times = value; }
    public float Mag_size { get => _mag_size; set => _mag_size = value; }
    public string[] OnShoot { get => _onShoot; set => _onShoot = value; }
    public string[] OnReload { get => _onReload; set => _onReload = value; }
    public string[] OnHit { get => _onHit; set => _onHit = value; }
    public string[] OnCrit { get => _onCrit; set => _onCrit = value; }
    


    //void shoot()
    //{

    //} 
    //void onReload()
    //{

    //}
    //void onHit()
    //{

    //}
    //void onCrit()
    //{

    //}


}
