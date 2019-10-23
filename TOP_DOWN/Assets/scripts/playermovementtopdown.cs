using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementtopdown : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        mouseposition.z = transform.position.z;
        transform.up = mouseposition - transform.position;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movedir = x * transform.right + y * transform.up;
        movedir.Normalize();
        GetComponent<Rigidbody2D>().velocity = movedir * moveSpeed;
    }
}
