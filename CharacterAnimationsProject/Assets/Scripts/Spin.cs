using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationSpeed = 0;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed));
    }
}
