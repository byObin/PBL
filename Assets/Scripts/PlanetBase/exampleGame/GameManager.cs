using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {

        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }
    [SerializeField]
    private GameObject poop;

    private int score;

    [SerializeField]
    private Text scoreTxt;

    [SerializeField]
    private Transform objbox;

    [SerializeField]
    private Text bestScore2;

    [SerializeField]
    private GameObject panel;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private bool stopTrigger = false;

    public void GameOver()
    {
        stopTrigger = false;

        StopCoroutine(CreatepoopRoutine());

        if (score >= PlayerPrefs.GetInt("BestScore", 0))
        PlayerPrefs.SetInt("BestScore", score);

        bestScore2.text = PlayerPrefs.GetInt("BestScore", 0).ToString();

        panel.SetActive(true);
    }

    public void GameStart()
    {
        score = 0;
        scoreTxt.text = "Score : " + score;
        stopTrigger = true;
        StartCoroutine(CreatepoopRoutine());
        panel.SetActive(false);
    }

    public void Score()
    {
        if(stopTrigger)
        score++;
        Debug.Log("score : " + score);
        scoreTxt.text = "Score: " + score;
    }

    IEnumerator CreatepoopRoutine()
    {
        while (stopTrigger)
        {
            CreatePoop();
            yield return new WaitForSeconds(0.3f);
           
        }
    }

    private void CreatePoop()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(poop, pos, Quaternion.identity);
        //obj.transform.parent = objbox.transform;
    }

}
