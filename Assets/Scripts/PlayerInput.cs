using UnityEngine;

/*
 * This class handles player input
 * Update input values to be used by other scripts
 */
public class PlayerInput : MonoBehaviour
{
    // directional inputs
    [HideInInspector] public float xMove;
    [HideInInspector] public float yMove;

    // jump input
    [HideInInspector] public bool jumpPressed;

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    /*
     * Read the player inputs and update the values
     */
    void ProcessMovement()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
        jumpPressed = Input.GetButtonDown("Jump");
    }
}
