using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Base 
{
    // int slot : using int to determine item slot(0 = weapon , 1 = trinket)
    // string code : item internal name
    // int rarity : using int to determine droprate by assigning amount of base tickets to rarity
    // int grade : using int to determine item bonus stats (1-6)
    // float[] stat_modifiers : an array that contain all the stats changes to player
    // item_image / item_model : asset for item 
    private string _name = "noname";
    private int _slot = 0;
    private string _description = "insert desc";
    private string _code = "aaaa123";
    private int _rarity = 1; // for item generation
    private int _base_cost = 0;
    private int _grade = 1; // for item generation
    private Stat _stat_modifier; // for item generation
    private string _item_img = "aaa";
    private string _item_model = "aaa";


    //Contructor
    public Equipment_Base(string name, int slot, string description, string code, int rarity, int base_cost, int grade, Stat stat_modifier, string item_img, string item_model)
    {
        _name = name;
        _slot = slot;
        _description = description;
        _code = code;
        _rarity = rarity;
        _base_cost = base_cost;
        _grade = grade;
        _stat_modifier = stat_modifier;
        _item_img = item_img;
        _item_model = item_model;
        
    }



    //GetSet
    public string Name { get => _name; set => _name = value; }
    public int Slot { get => _slot; set => _slot = value; }
    public string Description { get => _description; set => _description = value; }
    public string Code { get => _code; set => _code = value; }
    public int Rarity { get => _rarity; set => _rarity = value; }
    public int Base_cost { get => _base_cost; set => _base_cost = value; }
    public int Grade { get => _grade; set => _grade = value; }
    public Stat Stat_modifier { get => _stat_modifier; set => _stat_modifier = value; }
    public string Item_img { get => _item_img; set => _item_img = value; }
    public string Item_model { get => _item_model; set => _item_model = value; }
    



    //Method
    void alwaysActive()
    {

    }

    void onMove()
    {

    } 
    void onIdle()
    {

    }
    void onShoot()
    {

    }
    
    
    



}
