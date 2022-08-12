using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private float playerSpeed = 5.0f; // 이동 속도

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽 화살표 눌렀을 때
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // 왼쪽 화살표 눌렀을 때
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow)) // 위쪽 화살표 눌렀을 때
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipY = false;
            transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
        }

    }
}
