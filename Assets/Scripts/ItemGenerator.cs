using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform ground;
    void Start()
    {
        float radius = itemPrefab.GetComponent<SphereCollider>().radius * itemPrefab.transform.localScale.y;
        int scaleX = (int)ground.localScale.x / 2;
        int scaleZ = (int)ground.localScale.z / 2;
        for (int x = -scaleX; x <= scaleX; x++)
        {
            for (int z = -scaleZ; z <= scaleZ; z++)
            {
                if (!Physics.CheckSphere(new Vector3(x, radius + 1.0f, z), 0.5f))
                {
                    Instantiate(
                        itemPrefab,
                        new Vector3(x, radius, z),
                        Quaternion.identity,
                        transform
                    );
                }
            }
        }
    }
}
