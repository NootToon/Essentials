using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Animator mAnimator;

    private void Awake()
    {
        if (mAnimator == null)
        {
            mAnimator = GetComponent<Animator>();
        }
    }
    private float timeRemaining = 0;
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            mAnimator.SetBool("WalkingRight", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mAnimator.SetBool("WalkingRight", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mAnimator.SetBool("WalkingLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            mAnimator.SetBool("WalkingLeft", false);  
        }
    }
}
