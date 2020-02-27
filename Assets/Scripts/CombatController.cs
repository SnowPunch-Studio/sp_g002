using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController
{
    public Camera cam;
    private Utility util;

    public CombatController()
    {
        util = new Utility();
    }

    public void SetState(PlayerInfo playerInfo)
    {
        switch(util.GetInputDirection())
        {
            case Utility.Direction.UP:
                playerInfo.State = new SAttackUp();
                break;
            case Utility.Direction.DOWN:
                playerInfo.State = new SAttackDown();
                break;
            case Utility.Direction.LEFT:
                playerInfo.State = new SAttackLeft();
                break;
            case Utility.Direction.RIGHT:
                playerInfo.State = new SAttackRight();
                break;
        }
    }
}
