using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float walkSpeed = 2;

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {

        //w górę
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Translate(Vector2.up * walkSpeed * Time.deltaTime);
        }


        //w dol
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Translate(Vector2.down * walkSpeed * Time.deltaTime);
        }

        //w lewo
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {

            transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);

            if (transform.localScale.x > 0)
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        //w prawo
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {

            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);

            if (transform.localScale.x < 0)
                transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        }
    }
}
