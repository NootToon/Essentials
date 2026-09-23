using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Billboard : MonoBehaviour
{

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}

