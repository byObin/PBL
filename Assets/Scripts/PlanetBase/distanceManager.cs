using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceManager : MonoBehaviour
{
    public GameObject player;
    public GameObject friend;
    public GameObject chattingPoint;
    public GameObject chattingPanel;

    private float distPtoF;
    private float distPtoCP;
    bool isActive;

    private void Start()
    {
        chattingPanel.gameObject.SetActive(false);
    }

    private void Update()
    {
       distPtoF = Vector2.Distance(player.transform.position, friend.transform.position);
       distPtoCP= Vector2.Distance(player.transform.position, chattingPoint.transform.position);
    }

    private void LateUpdate()
    {
        print("플레이어와 친구의 거리 : " + distPtoF);
        
        if (distPtoCP < 1.5 && isActive == false)
        {
            setActive();
        }
        else if (distPtoCP >= 2 && isActive == true)
        {
            setUnactive();
        }
    }

    private void setActive()
    {
        chattingPanel.gameObject.SetActive(true);
        isActive = true;
    }

    private void setUnactive()
    {
        chattingPanel.gameObject.SetActive(false);
        isActive = false;
    }

    
}
