using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHight;

    private float horizontal;
    private float jumpForce;

    public Rigidbody2D rigidbody;

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * moveSpeed;


        rigidbody.MovePosition(transform.position + new Vector3(horizontal, 0, 0));
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.velocity.y = transform.y * Time.fixedDeltaTime * jumpForce;
        }
    }
}
