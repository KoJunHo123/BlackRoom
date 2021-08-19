using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public GameObject TextEnd;
    public GameObject TextTryAgain;

    private void Awake()
    {
        if(PlayerPrefs.GetInt("NewStage") == 0)
        {
            TextEnd.SetActive(true);
        }
        else
        {
            TextTryAgain.SetActive(true);
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
