using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinX : MonoBehaviour
{
    public float RotateSpeed;
    void Update()
    {
        transform.Rotate(RotateSpeed, 0f,0f, Space.Self);
    }
}
