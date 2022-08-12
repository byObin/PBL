using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCountDown : MonoBehaviour
{
    private int Timer = 0;
    public GameObject CountDown3;
    public GameObject CountDown2;
    public GameObject CountDown1;
    public GameObject CountDown0;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        CountDown3.SetActive(false);
        CountDown2.SetActive(false);
        CountDown1.SetActive(false);
        CountDown0.SetActive(false);

    }

    // Update is called once per frame

    void Update()
    {

        //게임 시작시 정지
        if (Timer == 0)
        {
            Time.timeScale = 0.0f;
        }


        //Timer 가 90보다 작거나 같을경우 Timer 계속증가

        if (Timer <= 90)
        {
            Timer++;

            // Timer가 30보다 작을경우 3번켜기
            if (Timer < 30)
            {
                CountDown3.SetActive(true);            }

            // Timer가 30보다 클경우 3번끄고 2번켜기
            if (Timer > 30)
            {
                CountDown3.SetActive(false);
                CountDown2.SetActive(true);
            }

            // Timer가 60보다 작을경우 2번끄고 1번켜기
            if (Timer > 60)
            {
                CountDown2.SetActive(false);
                CountDown1.SetActive(true);
            }

            //Timer 가 90보다 크거나 같을경우 1번끄고 GO 켜기 LoadingEnd () 코루틴호출
            if (Timer >= 90)
            {
                CountDown1.SetActive(false);
                CountDown0.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f; //게임시작
            }
        }

    }



    IEnumerator LoadingEnd()
    {


        yield return new WaitForSeconds(1.0f);
        CountDown0.SetActive(false);
    }
}
