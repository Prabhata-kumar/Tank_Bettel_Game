using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript 
{
   
    private ModenScript tankMode;
    private ViewScript tankView;
    private Rigidbody rb;
    public ControllerScript(ModenScript _tankModen,ViewScript _tankView)
    {
        tankMode = _tankModen;
        //tankView = _tankView;                             1   
        tankView = GameObject.Instantiate<ViewScript>(_tankView); 
        rb = tankView.GetComponent<Rigidbody>();
        tankMode.SetTankController(this);
        tankView.SetTankController(this);

        //GameObject.Instantiate(tankView.gameObject);      1
        Debug.Log("ControllerScript");
    }

    public void Move(float movement,float movementspeed)
    {
        rb.velocity = tankView.transform.forward * movement * movementspeed;
    }

    public void Rotation(float roitate, float rotateSpeed)
    {
        Vector3 vector =new Vector3(0,roitate*rotateSpeed,0);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
                                        