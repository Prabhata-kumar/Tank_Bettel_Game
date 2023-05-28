using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStateMAnager : MonoBehaviour
{
    public EnemyBaseState currentState;
    public EnemyAttackState attackState;
    public EnemyPatrolState patrolState;
    public EnemyCheasState cheasState;

    internal EnemySingleton enemyTankView;

    public NavMeshAgent agent;
    public List<Transform> wayPointes;
    internal Transform player;

    public float distanceToPlayer;
    public float chaseRange;
    public float attakeRange;

    public float attakDuraction = 2f;
    public bool isAlradyAttaking;

    private void Start()
    {
        enemyTankView = GetComponent<EnemySingleton>();
        player = FindObjectOfType<Transform>().transform;
        currentState = patrolState;
        currentState.EntryState(this);
    }

    public void Update()
    {
        CurrentPlay(); 
        currentState.updateStage(this);
    }

    public void CurrentPlay()
    {
        if(player == null)
        {
            currentState = patrolState;
            return;
        }
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
    }

    public void SwitchState(EnemyBaseState enemyBaseState)
    {
        currentState = enemyBaseState;
        enemyBaseState.EntryState(this);
    }
}
