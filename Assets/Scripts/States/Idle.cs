using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : BaseState
{
    private Vector2 moveInput;

    public Idle(MovementSM stateMachine) : base("Idle" , stateMachine)
    {

    }
    public override void Enter()
    {
        base.Enter();
        moveInput.x = 0f;
        moveInput.y = 0f;
    }
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        //transition to "moving" state if input != 0
        if (Mathf.Abs(moveInput.x) > Mathf.Epsilon || Mathf.Abs(moveInput.y) > Mathf.Epsilon)
        {
            stateMachine.ChangeState(((MovementSM)stateMachine).movingState);
        }
    }
}
