using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndText : MonoBehaviour
{
    [SerializeField] GameObject TextEnd;
    [SerializeField] GameObject TextTryAgain;

    [SerializeField] GameObject YesTryAgain;
    [SerializeField] GameObject NoTryAgain;

    [SerializeField] GameObject YesEnd;
    [SerializeField] GameObject NoEnd;


    private void Awake()
    {
        if (PlayerPrefs.GetInt("GameClear") == 1)
        {
            TextEnd.SetActive(true);
            YesEnd.SetActive(true);
            NoEnd.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("GameClear") != 1)
        {
            TextTryAgain.SetActive(true);
            YesTryAgain.SetActive(true);
            NoTryAgain.SetActive(true);
        }
        /* PlayerPrefs.SetInt("NewStage", 1); 

         if(PlayerPrefs.GetInt("NewStage") == 0) // 항상 false
         {
             TextEnd.SetActive(true);
     0        YesEnd.SetActive(true);
             NoEnd.SetActive(true);
         }
         else
         {
             TextTryAgain.SetActive(true);
             YesTryAgain.SetActive(true);
             NoTryAgain.SetActive(true);
         }*/
    }
    void Start()
    {
        //if (TestGameClearGETSET)
        //    PlayerPrefs.SetInt("GameClear", 1);
        //else PlayerPrefs.SetInt("GameClear", 0); //테스트 끝날시 지울것



    }

    // Update is called once per frame
    void Update()
    {

    }
}
