using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackState : EnemyBaseState
{
    public override void EntryState(EnemyStateMAnager enemyTankStateManager)
    {
        enemyTankStateManager.agent.SetDestination(enemyTankStateManager.agent.transform.position);
    }

    public override void updateStage(EnemyStateMAnager enemyStateManager)
    {

    }

    private void AttackFunction(EnemyStateMAnager enemyStateManager)
    {
        if (!enemyStateManager.isAlradyAttaking)
        {
            enemyStateManager.isAlradyAttaking = true;
        }
    }

    private IEnumerator ResetAttack(EnemyStateMAnager enemyStateManager)
    {
        yield return new WaitForSeconds(enemyStateManager.attakDuraction);
       enemyStateManager.isAlradyAttaking = false;
    }
}
