using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacomon 
{
    private PacomonBase _base;
    private int _level;

    public Pacomon(PacomonBase pacomonbase, int pacomonlevel)
    {
        _base = pacomonbase;
        _level = pacomonlevel;

    }

        public int MaxHp => Mathf.FloorToInt((_base.MaxHp*_level)/100.0f)+10;
        public int Attack => Mathf.FloorToInt((_base.Attack * _level) / 100.0f) + 2;
        public int Defense => Mathf.FloorToInt((_base.Defense * _level) / 100.0f) + 2;
        public int SpAttack => Mathf.FloorToInt((_base.SpAttack * _level) / 100.0f) + 2;
        public int SpDefense => Mathf.FloorToInt((_base.SpDefense * _level) / 100.0f) + 2;
        public int Speed => Mathf.FloorToInt((_base.Speed * _level) / 100.0f) + 2;

}
