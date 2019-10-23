using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float pixelsize = 0.03125f;
    public float multiplier = 1.0f;
    public float multipliernorm = 1.0f;
    public float multipliermax = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            multiplier = multipliermax;
        }
        else
        {
            multiplier = multipliernorm;
        }

        float x = Input.GetAxis("Horizontal");
        //Debug.Log(x);
        float y = Input.GetAxis("Vertical");
        //Debug.Log(y);
        Vector2 movedir = new Vector2(x, y);
        //movedir.Normalize();
        GetComponent<Rigidbody2D>().velocity = movedir * (moveSpeed * pixelsize * multiplier);
    }
}
