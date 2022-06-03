using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Pacomon", menuName ="Pacomon/Nuevo Pacomon")]
public class PacomonBase : ScriptableObject
{
    [SerializeField]
    private string name;
    public string Name => name;

    [SerializeField]
    private int ID;

    [SerializeField][TextArea]
    private string description;
    public string Descripcion => description;

    [SerializeField]
    private Sprite frontSprite;

    [SerializeField]
    private Sprite backSprite;

    [SerializeField]
    private PacomonType type1;
    public PacomonType Type1 => type1;

    [SerializeField]
    private PacomonType type2;
    public PacomonType Type2 => type2;

    //Stats
    [SerializeField] private int maxHp; 
    [SerializeField] private int attack; 
    [SerializeField] private int defense;
    [SerializeField] private int spAttack;
    [SerializeField] private int spDefense;
    [SerializeField] private int speed;

    public int MaxHp => maxHp;
    public int Attack => attack;
    public int SpAttack => spAttack;
    public int SpDefense => spDefense;
    public int Defense => defense; 
    public int Speed  => speed;

    [SerializeField] private List<LearnableMove> learnableMoves;
    public List<LearnableMove> LearnableMoves => learnableMoves;
    public enum PacomonType
    {
        None,
        Normal,
        Fire,
        Water,
        Electric,
        Ice,
        Grass,
        Rock,
        Poison,
        Fly,
        Bug,
        Ghost,
        Dragon
    }

    [Serializable] public class LearnableMove
    {
        [SerializeField] private MoveBase _move;
        [SerializeField] private int level;

        public MoveBase Move => _move;
        public int Level => level;

    }
}
