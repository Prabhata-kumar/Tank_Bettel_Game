using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBaseState 
{
    public abstract void EntryState(EnemyStateMAnager enemyStateManager);
    public abstract void updateStage(EnemyStateMAnager enemyStateManager);
}
