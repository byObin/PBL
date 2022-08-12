using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnterThePlanet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "planet1")
        {
            SceneManager.LoadScene("Planet1");
        }
        if (collision.gameObject.name == "planet2")
        {
            SceneManager.LoadScene("Planet2");
        }
        if (collision.gameObject.name == "planet3")
        {
            SceneManager.LoadScene("Planet3");
        }
        if (collision.gameObject.name == "planet4")
        {
            SceneManager.LoadScene("Planet4");
        }
        if (collision.gameObject.name == "planet5")
        {
            SceneManager.LoadScene("Planet5");
        }


    }
}
