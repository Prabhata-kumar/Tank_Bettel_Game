using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewScript : MonoBehaviour
{
    public TankEnum tankType;
    private ControllerScript tankController;

    internal float playerTurnHorizontal = 0f;
    internal float playerMoveVertical = 0f;
    internal bool fire1 = false;
    internal bool fire0 = false;
    internal bool fire3 = false;

    public Slider sliderHealth;
    public Image fillImage;
    public Color fullHealthColor = Color.green;
    public Color zeroHealthColor = Color.red;

    public Rigidbody shellPrefab;
    public Transform fireTransform;
    public Slider aimSlider;

    public bool fired;
    internal bool tankDead;

    private Rigidbody rb;
    private float movement;
    private float rotation;
   

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
