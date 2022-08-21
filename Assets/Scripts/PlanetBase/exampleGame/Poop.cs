using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            GameManager.Instance.Score();
            
        }

        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.GameOver();
            Debug.Log("게임오버");
        }
    }
}
