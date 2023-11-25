using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    enum State{
        FRONT,
        BACK,
        LEFT,
        RIGHT
    }
    [SerializeField]Vector3 startPos;
    [SerializeField] GameObject itemPrefab;
    List<GameObject> itemList;
    void Start()
    {
        GenerateItems(5,State.FRONT);
        GenerateItems(6,State.LEFT);
        GenerateItems(3,State.FRONT);
        GenerateItems(4,State.RIGHT);
    }
    void GenerateItems(int num,State state){
        Vector3 dir = Vector3.zero;
        switch(state){
            case State.FRONT:
            dir += new Vector3(0,0,1);
            break;
            case State.BACK:
            dir += new Vector3(0,0,-1);
            break;
            case State.LEFT:
            dir += new Vector3(1,0,0);
            break;
            case State.RIGHT:
            dir += new Vector3(-1,0,0);
            break;
        }

        for(int i=1;i<=num;i++){
            Instantiate(
                itemPrefab,
                startPos,
                Quaternion.identity,
                transform
            );
            startPos += dir;
        }
    }

}
