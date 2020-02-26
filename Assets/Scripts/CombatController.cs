using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    [SerializeField] private Animator playerAnim;

    public Camera cam;
    private Utility util;

    private PlayerState state;

    /*enum PlayerState { 
        IDLE_UP,
        IDLE_DOWN,
        IDLE_LEFT,
        IDLE_RIGHT,       
        ATTACK_UP, 
        ATTACK_DOWN, 
        ATTACK_LEFT, 
        ATTACK_RIGHT,
        DEFENSE_UP,
        DEFENSE_DOWN,
        DEFENSE_LEFT,
        DEFENSE_RIGHT,
        STUN_UP,
        STUN_DOWN,
        STUN_LEFT,
        STUN_RIGHT,
        MINING_UP,
        MINING_DOWN,
        MINING_LEFT,
        MINING_RIGHT,
        PLANT_UP,
        PLANT_DOWN,
        PLANT_LEFT,
        PLANT_RIGHT,
        TEND_UP,
        TEND_DOWN,
        TEND_LEFT,
        TEND_RIGHT,
        HARVEST_UP,
        HARVEST_DOWN,
        HARVEST_LEFT,
        HARVEST_RIGHT 
    }*/

    // Start is called before the first frame update
    void Start()
    {
        util = new Utility();
    }

    // Update is called once per frame
    void Update()
    {
        switch(util.GetInputDirection())
        {
            case Utility.Direction.UP:
                state = new SAttackUp();
                break;
            case Utility.Direction.DOWN:
                state = new SAttackDown();
                break;
            case Utility.Direction.LEFT:
                state = new SAttackLeft();
                break;
            case Utility.Direction.RIGHT:
                state = new SAttackRight();
                break;
        }
        if(state != null)
        {
            state.ProcessState();
            state = null;
        }
    }
}
