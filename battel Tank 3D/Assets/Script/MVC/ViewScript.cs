using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScript : MonoBehaviour
{
    private ControllerScript tankController;

    private Rigidbody rb;
    private float movement;
    private float rotation;
    public ViewScript()
    {

    }

    public void Update()
    {
        TankMotion();
        if(movement != 0)
        {
            tankController.Move(movement, 30);
        }
        if(rotation != 0)
        {
            tankController.Rotation(rotation, 30);
        }
    }
    public void SetTankController(ControllerScript _tankController)
    {
        tankController = _tankController;
    }

    public void TankMotion()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }
}
