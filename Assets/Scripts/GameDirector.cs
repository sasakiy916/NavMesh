using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    float clearCount = 10;
    public Text clearCountText;
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
        clearCountText.text = $"クリアまで:{clearCount}";
    }

    public void DecreaseClearCount()
    {
        clearCount--;
    }
}
