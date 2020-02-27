using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public PlayerState State { get; set; }

    public CombatController combatController;
    public MiningController miningController;
    public FarmingController farmingController;

    public Animator animator;

    public enum ItemType { WEAPON, MINING, FARMING };

    private void Start()
    {
        combatController = new CombatController();
        miningController = new MiningController();
        farmingController = new FarmingController();
        animator = GetComponent<Animator>();
    }

    public ItemType GetCurrentEquippedItemType()
    {
        return ItemType.WEAPON;
    }



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
}
