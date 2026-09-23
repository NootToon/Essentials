using UnityEngine;

public class PlayerOnGround : MonoBehaviour
{
    public bool isGrounded = false;

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }
}

