using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =" TankScripatableObject ",menuName = " ScripatableObject/NewTankscripatableObject" )]
public class TankScripatatableObject :ScriptableObject
{
    public TankEnum tankType;
    public Vector3 scale;
    public string tankName;
    public float speed;
    public float tankTurnSpeed;
    public float Health;
    public float damage;
    public Color color;

    public float minLaunchForce;
    public float maxLaunchForce = 30f;
    public float maxChargeTime = 0.75f;

    public float currentLaunchForce;
    public float chargeSpeed;
}
