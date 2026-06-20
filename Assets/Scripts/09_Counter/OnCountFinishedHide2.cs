using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCountFinishedHide2 : MonoBehaviour
{
    //-------------------------------------
    public CounterType2 kind = CounterType2.Keys; // [カウンターの種類]
    public int lastCount = 3; // [最終値]
    public GameObject hideObject; // [消すオブジェクト]
    //-------------------------------------

    void Update()
    {
        // カウンターが最終値になったら
        if (GameCounter2.counters[kind] == lastCount)
        {
            hideObject.SetActive(false); // 非表示にする
        }
    }
}
