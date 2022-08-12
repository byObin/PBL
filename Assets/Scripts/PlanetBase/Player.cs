using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5;




    // Update is called once per frame
    void Update()
    {
        float posX = Input.GetAxisRaw("Horizontal");    //keybord input
        float posY = Input.GetAxisRaw("Vertical");         //keybord input


        transform.Translate(new Vector2(posX, posY) * Time.deltaTime * speed);


    }

 

}
