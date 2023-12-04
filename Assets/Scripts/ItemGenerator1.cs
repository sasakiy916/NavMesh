using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator1 : MonoBehaviour
{
    public GameObject itemPrefab;
    void Start()
    {
        float radius = itemPrefab.GetComponent<SphereCollider>().radius * itemPrefab.transform.localScale.y;
        Debug.Log(radius);
        for (int x = -9; x <= 9; x++)
        {
            for (int z = -12; z <= 12; z++)
            {
                if (!Physics.CheckSphere(new Vector3(x, radius + 1.0f, z), 0.5f))
                {
                    Instantiate(
                        itemPrefab,
                        new Vector3(x, radius, z),
                        Quaternion.identity,
                        transform.parent
                    );
                }
            }
        }
    }

    void Update()
    {
    }
}
