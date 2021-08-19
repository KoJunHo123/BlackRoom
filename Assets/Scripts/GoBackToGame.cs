using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToGame : MonoBehaviour
{
    public Transform Back;
    public float speed;
    public float delta;
    public bool TryAgain;
    void Start()
    {

        Debug.Log(PlayerPrefs.GetInt("NowStage"));
    }

    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("NowStage"));
        if (TryAgain)
        {
            delta += Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Back.position, speed * Time.deltaTime);
            if (delta > 3f)
                SceneManager.LoadScene(PlayerPrefs.GetInt("NowStage"));
        }
    }

    public void MoveChange()
    {
        TryAgain = true;
    }

}
