using UnityEngine;

/*
 * This class stores the player's global attribute values
 */

public class PlayerAttributes : MonoBehaviour
{
    // movement speed
    [Tooltip("In ms^-1")] public float moveSpeed = 5f;

    // jump force
    [Tooltip("In ms^-1")] public float jumpForce = 10f;

    // maximum jump height
    [Tooltip("In ms^-1")] public float jumpHeight = 4f;
}
