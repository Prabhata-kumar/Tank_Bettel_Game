using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : GenericSingleton<PlayerSingleton>
{
    public int p_PlayerNumber = 1;
    public float p_Speed = 12f;
    public float p_TurnSpeed = 180f;
    public float p_PitchRange = 0.2f;
    public AudioSource p_MovementAudio;
    public AudioClip p_EngineIdling;
    public AudioClip p_EngineDriving;


    private string p_MovementAxisName;
    private string p_TurnAxisName;
    private Rigidbody p_Rigidbody;
    private float p_MovementInputValue;
    private float p_TurnInputValue;
    private float p_OriginalPitch;
    protected new void Awake()
    {
        base.Awake();
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        p_Rigidbody.isKinematic = false;
        p_MovementInputValue = 0f;
        p_TurnInputValue = 0f;
    }

    private void OnDisable()
    {
        p_Rigidbody.isKinematic = true;
    }

    private void Start()
    {
        p_Rigidbody = GetComponent<Rigidbody>();
        p_MovementAxisName = "Horizontal" + p_PlayerNumber;
        p_MovementAxisName = "Vertical" + p_PlayerNumber;
        //p_OriginalPitch = p_MovementAudio.pitch;
    }

    void Update()
    {
        p_MovementInputValue = Input.GetAxisRaw("Vertical");
        p_TurnInputValue = Input.GetAxisRaw("Horizontal");

        EngineAudio();
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    private void EngineAudio()
    {
        if (Mathf.Abs(p_MovementInputValue) < 0.1f && Mathf.Abs(p_TurnInputValue) < 0.1f)
        {
            if (p_MovementAudio.clip == p_EngineDriving)
            {
                p_MovementAudio.clip = p_EngineDriving;
                p_MovementAudio.pitch = Random.Range(p_OriginalPitch - p_PitchRange, p_OriginalPitch + p_OriginalPitch);

                p_MovementAudio.Play();
            }
        }
        else
        {
            if (p_MovementAudio.clip == p_EngineDriving)
            {
                p_MovementAudio.clip = p_EngineDriving;
                p_MovementAudio.pitch = Random.Range(p_OriginalPitch - p_PitchRange, p_OriginalPitch + p_OriginalPitch);

                p_MovementAudio.Play();
            }

        }

    }
    void Move()
    {
        //Arject the positionof tank based on player input
        Vector3 movement = transform.forward * p_MovementInputValue * p_Speed * Time.deltaTime;

        p_Rigidbody.MovePosition(p_Rigidbody.position + movement);
    }
    void Turn()
    {
        float turn = p_TurnInputValue * p_TurnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        p_Rigidbody.MoveRotation(p_Rigidbody.rotation * turnRotation);
    }
}
