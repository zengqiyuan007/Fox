using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float faceDirection = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (moveHorizontal != 0)
        {
            rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
        }
        if (faceDirection != 0)
        {
            transform.localScale = new Vector3(faceDirection, 1, 1);
        }
        if (moveVertical != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveVertical * speed);
        }
    }
}
