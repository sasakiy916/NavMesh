using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject target;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        // 目的地設定
        nav.destination = target.transform.position;
    }

    void Update()
    {
    }
}
