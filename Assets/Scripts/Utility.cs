using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility
{
    private Camera mainCamera;
    private GameObject player;
    public enum Direction { NULL, UP, DOWN, LEFT, RIGHT }

    public Utility()
    {
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        player = GameObject.FindWithTag("Player");
    }

    public Direction GetInputDirection()
    {


        Direction inputDirection = Direction.NULL;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 cursorPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            float adjustedX = cursorPosition.x - player.transform.position.x;
            float adjustedY = cursorPosition.y - player.transform.position.y;

            if (Mathf.Abs(adjustedX) > Mathf.Abs(adjustedY))
            {
                if (adjustedX > 0)
                {
                    //Debug.Log("Right");
                    inputDirection = Direction.RIGHT;
                }
                else
                {
                    //Debug.Log("Left");
                    inputDirection = Direction.LEFT;
                }
            }
            else
            {
                if (adjustedY > 0)
                {
                    //Debug.Log("Up");
                    inputDirection = Direction.UP;
                }
                else
                {
                    //Debug.Log("down");
                    inputDirection = Direction.DOWN;
                }
            }
        }
        return inputDirection;
    }
}
