using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCount : MonoBehaviour
{
    public int stageCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReturnToStage()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("NowStage"));
    }

    //void SaveCount()
    //{
    //    PlayerPrefs.SetInt("DeathStage", stageCount);
    //}

    //void LoadCount()
    //{
    //    PlayerPrefs.GetInt("DeathStage");
    //}

    //void LoadScene()
    //{
    //    SceneManager.LoadScene(stageCount);
    //}

    //void Clear()
    //{
    //    PlayerPrefs.DeleteAll();
    //}


}
