using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : BaseState
{
    private MovementSM _sm;
    private Vector2 moveInput;

    public Moving(MovementSM stateMachine) : base("Moving" , stateMachine)
    {
        _sm = (MovementSM)stateMachine;
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
        //transition to "Idle" state if input = 0
        if (Mathf.Abs(moveInput.x) < Mathf.Epsilon && Mathf.Abs(moveInput.y) < Mathf.Epsilon)
        {
            stateMachine.ChangeState(_sm.idleState);
        }
    }
    public override void UpdatePhysic()
    {
        base.UpdatePhysic(); 
        StatesScript.MoveScript(moveInput,_sm.rigidbody,_sm.speed);
    }
}
