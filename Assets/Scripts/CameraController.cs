using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    Vector3 startPos;
    void Start()
    {
        startPos = target.position - transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            target.position.z - startPos.z
        );
    }
}
