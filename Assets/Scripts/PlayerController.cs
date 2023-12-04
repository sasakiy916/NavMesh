using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody rd;
    Animator anim;
    float moveHorizontal;
    float moveVertical;
    void Start()
    {
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        transform.rotation = Quaternion.LookRotation(rd.velocity.normalized);
        anim.SetFloat("run", rd.velocity.magnitude);
    }

    void FixedUpdate()
    {
        rd.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed;
    }

    void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "item":
                GameDirector.instance.DecreaseClearCount();
                Destroy(other.gameObject);
                break;
        }
    }
}
