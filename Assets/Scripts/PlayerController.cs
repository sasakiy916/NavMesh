using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject target;
    Animator anim;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        // 目的地設定
        nav.destination = target.transform.position;
    }

    void Update()
    {
        anim.SetFloat("run", nav.desiredVelocity.magnitude / nav.speed);
    }
}
