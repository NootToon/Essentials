
using UnityEngine;

public class PlayerOnGround : MonoBehaviour
{
    public bool isGrounded;
    void OnCollisionStay(Collision Collision)
    {
        
        isGrounded=true;
    }
    void OnCollisionExit(Collision Collision)
    {
        
        isGrounded=false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGrounded=false;
        }
    }

}

