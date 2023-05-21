using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =" TankScripatableObject ",menuName = " ScripatableObject/NewTankscripatableObject" )]
public class TankScripatatableObject :ScriptableObject
{
    public TankEnum tankType;
    public string tankName;
    public int tankSpeed;
    public float tankHealth;
}
