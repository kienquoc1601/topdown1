using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manufacturer 
{   //STAT CHANGE
    //all variables use float as a multiplier(%) to base weapon stat .
    //_firing_mode , _armor_pen override the default base weapon value
    private int _firing_mode = 1;
    private int _armor_pen = 0;
    private float _damage = 1.0f;
    private float _elemental_multiplier;
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

    //list contain all the stat modifier for player (flat stat)
    private Stat _stat_modifiers ;

    //list contain action for each condition , but draw from difference masterclass only for manufacturor
    private string[] _onShoot = { };
    private string[] _onReload = { };
    private string[] _onHit = { };
    private string[] _onCrit = { };

    //force elemental or not (will update elemental id later)
    private int _elemental_id = 0;
}
