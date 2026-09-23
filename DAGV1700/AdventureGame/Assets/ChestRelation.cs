using UnityEngine;

public class AppearOnSeparationTrigger : MonoBehaviour
{
    public GameObject objectToToggle;
    private bool isTouching = true;

    private void OnTriggerExit(Collider collision)
    {
        isTouching = false;
        objectToToggle.SetActive(true);
    }
}