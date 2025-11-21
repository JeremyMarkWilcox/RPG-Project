using UnityEngine;

public class Player_WallJumpState : EntityState
{
    public Player_WallJumpState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }
    
    override public void Enter()
    {
        player.SetVelocity(player.wallJumpForce.x * -player.facingDir, player.wallJumpForce.y);
    }
    
    override public void Update()
    {
        if(player.rb.linearVelocity.y < 0)
        {
            stateMachine.ChangeState(player.fallState);
        }
        if(player.isWallDetected)
        {
            stateMachine.ChangeState(player.wallSlideState);
        }
    }
}
