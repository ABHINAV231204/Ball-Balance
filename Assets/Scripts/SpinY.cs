using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinY : MonoBehaviour
{
    public float rotateSpeed;
    void Update()
    {
        transform.Rotate(0f,rotateSpeed,0f, Space.Self);
    }
}
