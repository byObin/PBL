using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("setUnactive", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setUnactive()
    {
        this.gameObject.SetActive(false);
    }
}
