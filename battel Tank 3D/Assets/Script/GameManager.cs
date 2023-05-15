using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ViewScript tankViewScript;

    private void Start()
    {
        //Instantiate(tankViewScript.gameObject,transform.position,Quaternion.identity);
        CreatTank();
    }

    private void CreatTank()
    {
        ModenScript tankModenScript = new ModenScript();
        ControllerScript tankController = new ControllerScript(tankModenScript, tankViewScript);
        Debug.Log(" Calling Creat Tank");
    }
}