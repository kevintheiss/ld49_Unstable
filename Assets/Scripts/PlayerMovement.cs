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
    Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerAttributes = GetComponent<PlayerAttributes>();
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    /*
     * Handle the player's directional input movement
     */
    void ProcessMovement()
    {
        float xMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerAttributes.moveSpeed;

        transform.Translate(xMove, 0f, 0f);
    }
}
