using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheasState : EnemyBaseState
{
    public override void EntryState(EnemyStateMAnager enemyTankStateManager)
    {

    }

    public override void updateStage(EnemyStateMAnager enemyStateManager)
    {
        enemyStateManager.agent.SetDestination(enemyStateManager.player.position);
        CheckEnemyAttackState(enemyStateManager);
        CheckEnemyPatrollingState(enemyStateManager);
    }

    private void CheckEnemyAttackState(EnemyStateMAnager enemyStateManager)
    {
        if (enemyStateManager.distanceToPlayer <= enemyStateManager.attakeRange)
        {
            enemyStateManager.SwitchState(enemyStateManager.attackState);
        }
    }

    private void CheckEnemyPatrollingState(EnemyStateMAnager enemyStateManager)
    {
        if (enemyStateManager.distanceToPlayer <= enemyStateManager.attakeRange)
        {
            enemyStateManager.SwitchState(enemyStateManager.patrolState);
        }
    }
}
