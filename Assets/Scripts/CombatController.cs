using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 cursorPosition = cam.ScreenToWorldPoint(Input.mousePosition);

            float adjustedX = cursorPosition.x - transform.position.x;
            float adjustedY = cursorPosition.y - transform.position.y;

            if (Mathf.Abs(adjustedX) > Mathf.Abs(adjustedY))
            {
                if (adjustedX > 0)
                {
                    Debug.Log("Right");
                }
                else
                {
                    Debug.Log("Left");
                }
            }
            else
            {
                if (adjustedY > 0)
                {
                    Debug.Log("Up");
                }
                else
                {
                    Debug.Log("down");
                }
            }
        }
    }
}
