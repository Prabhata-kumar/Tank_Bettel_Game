using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolState : EnemyBaseState
{
    public override void EntryState(EnemyStateMAnager enemyTankStateManager)
    {
        EnemyPatrol(enemyTankStateManager);
    }

    public override void updateStage(EnemyStateMAnager enemyStateManager)
    {
        if (enemyStateManager.agent.remainingDistance <= enemyStateManager.agent.stoppingDistance)
        {
            enemyStateManager.agent.SetDestination(enemyStateManager.wayPointes[UnityEngine.Random.Range(0, enemyStateManager.wayPointes.Count)].position);
        }
        if (enemyStateManager.distanceToPlayer < enemyStateManager.chaseRange)
        {
            enemyStateManager.SwitchState(enemyStateManager.cheasState);
        }
    }

    public void EnemyPatrol(EnemyStateMAnager enemyStateMAnager)
    {
        Transform wayPointObject = GameObject.FindGameObjectWithTag("WayPoint").transform;
        foreach (Transform wp in wayPointObject)
        {
            enemyStateMAnager.wayPointes.Add(wp);
        }
    }
}


