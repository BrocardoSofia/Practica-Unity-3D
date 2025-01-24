using UnityEngine;

public class PatrolState : BaseState
{
    public int waypointIndex;
    public float waitTimer;
    public override void Enter()
    {

    }

    public override void Perform()
    {
        PatrolCicle();
    }

    public override void Exit()
    {

    }

    public void PatrolCicle()
    {
        if(enemy.Agent.remainingDistance < 0.2f)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer > 3)
            {
                if (waypointIndex < enemy.path.waypoints.Count - 1)
                {
                    waypointIndex++;
                }
                else
                {
                    waypointIndex = 0;
                }
                enemy.Agent.SetDestination(enemy.path.waypoints[waypointIndex].position);

                waitTimer = 0;
            }
            
        }
    }
}
