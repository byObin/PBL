using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFriendInfo : MonoBehaviour
{
    public GameObject player;
    public GameObject userInfoImage;

    bool isInfoActive;


    private float distPtoF;
    // Start is called before the first frame update
    void Start()
    {
        isInfoActive = false;
        userInfoImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distPtoF = Vector2.Distance(player.transform.position, this.transform.position);

        if (distPtoF < 3.5 && Input.GetMouseButtonDown(0))
        {
            if (isInfoActive == false)
            {
                userInfoImage.gameObject.SetActive(true);
            }
            
                print("Å¬¸¯");
        }

    }
}

