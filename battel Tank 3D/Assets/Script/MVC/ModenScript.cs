using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModenScript 
{
    private ControllerScript tankController;

    public ModenScript()
    {

    }

    public void SetTankController(ControllerScript _tankController)
    {
        tankController = _tankController;
    }
}
