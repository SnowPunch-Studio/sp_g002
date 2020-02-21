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

            if(cursorPosition.x < transform.position.x && cursorPosition.y < transform.position.y)
            {
                if(Mathf.Abs(cursorPosition.x) > Mathf.Abs(cursorPosition.y))
                {
                    Debug.Log("Attack left");
                }
                else
                {
                    Debug.Log("Attack down");
                }

            }
            else if(cursorPosition.x < transform.position.x && cursorPosition.y > transform.position.y)
            {
                if (Mathf.Abs(cursorPosition.x) > Mathf.Abs(cursorPosition.y))
                {
                    Debug.Log("Attack left");
                }
                else
                {
                    Debug.Log("Attack up");
                }
            }
            else if(cursorPosition.x > transform.position.x && cursorPosition.y > transform.position.y)
            {
                if (Mathf.Abs(cursorPosition.x) > Mathf.Abs(cursorPosition.y))
                {
                    //Debug.Log("Attack left");
                }
                else
                {
                    //Debug.Log("Attack up");
                }
            }


            /*if (cursorPosition.x > transform.position.x)
            {
                Debug.Log("Attack right");
            }

            if(cursorPosition.y < transform.position.y)
            {
                Debug.Log("Attack down");
            }

            if(cursorPosition.y > transform.position.y)
            {
                Debug.Log("Attack up");
            }*/
        }
    }
}
