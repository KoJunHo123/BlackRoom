using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public GameObject TextEnd;
    public GameObject TextTryAgain;

    public GameObject YesTryAgain;
    public GameObject NoTryAgain;
    
    public GameObject YesEnd;
    public GameObject NoEnd;

    private void Awake()
    {
        PlayerPrefs.SetInt("NewStage", 1);

        if(PlayerPrefs.GetInt("NewStage") == 0)
        {
            TextEnd.SetActive(true);
            YesEnd.SetActive(true);
            NoEnd.SetActive(true);
        }
        else
        {
            TextTryAgain.SetActive(true);
            YesTryAgain.SetActive(true);
            NoTryAgain.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
