using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.AddListener(EventDefine.test1, Test1CallBack);
        EventCenter.AddListener(EventDefine.test2, Test2CallBack);
    }

    // Update is called once per frame
    void Update()
    {
      if( Input.GetKeyDown(KeyCode.P)){
            EventCenter.Broadcast(EventDefine.test1);
       }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            EventCenter.Broadcast(EventDefine.test2);
        }
    }

    public void Test1CallBack() {
        Debug.Log("test1 event triggered");
    }

    public void Test2CallBack()
    {
        Debug.Log("test2 event triggered");
    }
}
