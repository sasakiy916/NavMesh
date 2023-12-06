using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform ground;

    [HideInInspector]
    public int itemCount;

    void Start()
    {
        // コライダーのサイズを取得
        float radius = itemPrefab.GetComponent<SphereCollider>().radius * itemPrefab.transform.localScale.y;

        // 地面のローカルスケールの半分を取得
        int scaleX = (int)ground.localScale.x / 2;
        int scaleZ = (int)ground.localScale.z / 2;

        // 地面にアイテムを敷き詰める
        for (int x = -scaleX; x <= scaleX; x++)
        {
            for (int z = -scaleZ; z <= scaleZ; z++)
            {
                // 壁のコライダーに当たらなかったらアイテム生成
                if (!Physics.CheckSphere(new Vector3(x, radius, z), 0.5f, 6 << 6))
                {
                    Instantiate(
                        itemPrefab,
                        new Vector3(x, radius, z),
                        Quaternion.identity,
                        transform
                    );
                    itemCount++;
                }
            }
        }
        GameDirector.instance.clearCount = itemCount;
    }
}
