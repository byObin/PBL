using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Managers : MonoBehaviour
{
    static Managers s_Instance; // 유일성 보장
    public static Managers Instance { get { Init();  return s_Instance; } } // 유일한 매니저를 가지고 옴

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void Init()
    {
        GameObject go = GameObject.Find("@Managers");
        if(s_Instance = null)
        {
            go = new GameObject { name = "@Managers" };
            go.AddComponent<Managers>();
        }
        DontDestroyOnLoad(go);
        s_Instance = go.GetComponent<Managers>();
    }


}
