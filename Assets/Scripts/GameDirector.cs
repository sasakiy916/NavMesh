using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    [HideInInspector]
    public float clearCount;
    public Text clearCountText;
    public ItemGenerator itemGenerator;
    public static GameDirector instance;

    void Start()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Update()
    {
        clearCountText.text = $"クリアまで:{clearCount:000}/{itemGenerator.itemCount}";
    }

    public void DecreaseClearCount()
    {
        clearCount--;
    }
}
