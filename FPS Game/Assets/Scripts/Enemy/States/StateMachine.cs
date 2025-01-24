using System;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
    public PatrolState patrolState;

    public void Initialise()
    {
        patrolState = new PatrolState();
        changeState(patrolState);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(activeState != null)
        {
            activeState.Perform();
        }
    }

    public void changeState(BaseState newState)
    {
        if(activeState != null)
        {
            activeState.Exit();
        }

        activeState = newState;

        if(activeState != null )
        {
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}
