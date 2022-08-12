using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    private float playerSpeed = 5.0f; // �̵� �ӵ�

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow)) // ������ ȭ��ǥ ������ ��
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // ���� ȭ��ǥ ������ ��
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            transform.Translate(new Vector3(-playerSpeed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow)) // ���� ȭ��ǥ ������ ��
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipY = false;
            transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
        }

    }
}
