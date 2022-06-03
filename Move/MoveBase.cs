using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PacomonBase;

[CreateAssetMenu(fileName ="Move",menuName ="Pacomon/Nuevo Movimiento")]public class MoveBase : ScriptableObject
{
    [SerializeField] private string name;   
    [SerializeField] [TextArea] private string description;  
    [SerializeField] private int accuracy;
    [SerializeField] private int power;
    [SerializeField] private PacomonType type;
    [SerializeField] private int pp;


    public string Name => name;
    public string Descripcion => description;
    public int Accuracy => accuracy;
    public int Power => power;
    public PacomonType Type =>type;
    public int PP => pp;

}
