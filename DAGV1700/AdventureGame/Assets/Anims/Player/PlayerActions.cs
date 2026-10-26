using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerActions : MonoBehaviour
{
    [SerializeField] private PlayerOnGround isGrounded;
    [SerializeField] private Animator mAnimator;
    [SerializeField] private AudioSource Audio1;
    [SerializeField] private AudioSource Audio2;

    private void Awake()
    {
        if (mAnimator == null)
        {
            mAnimator = GetComponent<Animator>();
        }
    }
    bool isJumping;
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            mAnimator.SetBool("WalkingRight", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mAnimator.SetBool("WalkingLeft", true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mAnimator.SetBool("WalkingRight", true);
        }
        
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            mAnimator.SetBool("WalkingLeft", false);
        }

        // Simplified ground check
        if (isGrounded.isGrounded==true&&isJumping==true)
        {
             Audio2.Play();
            mAnimator.SetBool("OnGround", true);
        }


        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mAnimator.SetTrigger("Jump");  
            Audio1.Play();
            isJumping=true;
            mAnimator.SetBool("OnGround", false);

        }



    }
}
