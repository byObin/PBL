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

        //���� ���۽� ����
        if (Timer == 0)
        {
            Time.timeScale = 0.0f;
        }


        //Timer �� 90���� �۰ų� ������� Timer �������

        if (Timer <= 90)
        {
            Timer++;

            // Timer�� 30���� ������� 3���ѱ�
            if (Timer < 30)
            {
                CountDown3.SetActive(true);            }

            // Timer�� 30���� Ŭ��� 3������ 2���ѱ�
            if (Timer > 30)
            {
                CountDown3.SetActive(false);
                CountDown2.SetActive(true);
            }

            // Timer�� 60���� ������� 2������ 1���ѱ�
            if (Timer > 60)
            {
                CountDown2.SetActive(false);
                CountDown1.SetActive(true);
            }

            //Timer �� 90���� ũ�ų� ������� 1������ GO �ѱ� LoadingEnd () �ڷ�ƾȣ��
            if (Timer >= 90)
            {
                CountDown1.SetActive(false);
                CountDown0.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f; //���ӽ���
            }
        }

    }



    IEnumerator LoadingEnd()
    {


        yield return new WaitForSeconds(1.0f);
        CountDown0.SetActive(false);
    }
}
