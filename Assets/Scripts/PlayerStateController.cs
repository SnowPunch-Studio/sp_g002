using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour
{
    [SerializeField] private PlayerInfo playerInfo;

    void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
    }

    void Update()
    {
        switch(playerInfo.GetCurrentEquippedItemType())
        {
            case PlayerInfo.ItemType.WEAPON:
                playerInfo.combatController.SetState(playerInfo);
                break;
        }

        if(playerInfo.State != null)
        {
            playerInfo.State.ProcessState();
        }
    }
}
