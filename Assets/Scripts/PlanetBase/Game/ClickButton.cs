using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    
    public GameObject button;

    public void backToPlanet()
    {
        SceneManager.LoadScene("Planet1");

    }
}
