using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class handles the player's movement.
 * This includes input, directional movement, and jumping.
 */

public class PlayerMovement : MonoBehaviour
{
    // component variables
    PlayerAttributes playerAttributes;
    PlayerInput playerInput;
    Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerInput = GetComponent<PlayerInput>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per physics step
    void FixedUpdate()
    {
        //ProcessJump();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
        ProcessJump();
    }

    /*
     * Handle the player's directional input movement
     */
    void ProcessMovement()
    {
        //playerRigidBody.velocity = new Vector2(playerInput.xMove, 0f) * playerAttributes.moveSpeed;
        // playerRigidBody.AddForce(new Vector2(playerInput.xMove * playerAttributes.moveSpeed, 0f), ForceMode.);
        Vector2 moveVector = new Vector2(playerInput.xMove, 0f);
        transform.Translate(moveVector.normalized * playerAttributes.moveSpeed * Time.deltaTime);
    }

    /*
     * Handle the player's jump input
     */
    void ProcessJump()
    {
        // jump button input flag and jump directional vector variables
        //bool jumpPressed = Input.GetButtonDown("Jump");
        //Vector3 jumpVector = new Vector3(0f, playerAttributes.jumpHeight, 0f);

        // if the jump button is pressed and the player is on the ground...
        if(playerInput.jumpPressed && playerRigidBody.velocity.y == 0f)
        {
            playerRigidBody.AddForce(new Vector2(0f, playerAttributes.jumpForce), ForceMode2D.Impulse); // player jump
        }
    }
}
