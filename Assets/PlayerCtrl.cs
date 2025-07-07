using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        Debug.Log(Time.deltaTime);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float faceDirection = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (moveHorizontal != 0)
        {
            Debug.Log(speed * Time.deltaTime);
            rb.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime , rb.velocity.y);
        }
        if (faceDirection != 0)
        {
            transform.localScale = new Vector3(faceDirection, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * Time.deltaTime);
        }
    }
}
