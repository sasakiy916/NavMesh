using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    NavMeshAgent nav;
    Rigidbody rd;
    Animator anim;
    float moveHorizontal;
    float moveVertical;
    void Start()
    {
        // nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody>();
        // 目的地設定
        // nav.destination = target.transform.position;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        // anim.SetFloat("run", nav.desiredVelocity.magnitude / nav.speed);
    }

    void FixedUpdate()
    {
        rd.AddForce(((Vector3.forward * moveVertical) + (Vector3.right * moveHorizontal)) * speed, ForceMode.VelocityChange);
        rd.velocity = Vector3.ClampMagnitude(rd.velocity, 2);
        Debug.Log(rd.velocity.magnitude);
    }
}
