using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elemental_Base 
{
    private int _elemental_id;
    private string _name;

    public Elemental_Base(int elemental_id, string name)
    {
        _elemental_id = elemental_id;
        _name = name;
    }

    public int Elemental_id { get => _elemental_id; set => _elemental_id = value; }
    public string Name { get => _name; set => _name = value; }
}
