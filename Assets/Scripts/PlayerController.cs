using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject target;
    public Text debugText;
    Animator anim;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        nav.destination = target.transform.position;
    }

    void Update()
    {
        // debugText.text = $"Position:{transform.position}";
        debugText.text = $"Position:{nav.desiredVelocity.magnitude / nav.speed}";
        anim.SetFloat("run", nav.desiredVelocity.magnitude / nav.speed);
    }
}
