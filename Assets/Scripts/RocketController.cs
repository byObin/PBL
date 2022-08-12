using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    private float moveSpeed = 5.0f; // 이동 속도
    private Vector3 moveDirection = Vector3.zero; // 이동방향

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //좌우 이동
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, y, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
      
    }
}
