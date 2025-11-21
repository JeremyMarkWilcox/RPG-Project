using UnityEngine;

public class Player_FallState : Player_AirState
{
    public Player_FallState(Player player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
        
    }
    
    override public void Update()
    {
        base.Update();

        if (player.isGroundDetected)
        {
            stateMachine.ChangeState(player.idleState);
        }
        
        if(player.isWallDetected)
        {
            stateMachine.ChangeState(player.wallSlideState);
        }
    }
}
