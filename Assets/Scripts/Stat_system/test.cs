using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aaaaaaaa");
        CharacterStat atk = new CharacterStat(10f);
        CharacterStat def = new CharacterStat(10f);
        StatModifier weaken = new StatModifier(-10f, StatModType.Flat);
        atk.AddModifier(new StatModifier(10f, StatModType.Flat));
        def.AddModifier(new StatModifier(2f, StatModType.PercentMult));
        Debug.Log(atk.Value);
        Debug.Log(def.Value);
        Debug.Log("aaaaaaaa");
        atk.AddModifier(new StatModifier(10f, StatModType.Flat));
        atk.AddModifier(new StatModifier(0.1f, StatModType.PercentAdd));
        atk.AddModifier(new StatModifier(0.1f, StatModType.PercentAdd));
        atk.AddModifier(weaken);
        Debug.Log(atk.Value);
        Debug.Log("aaaaaaaa");
        atk.RemoveModifier(weaken);
        Debug.Log(atk.Value);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
