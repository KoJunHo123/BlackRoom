using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToGame : MonoBehaviour
{
    public GameObject HandOnOff;

    HandMoveEnd Hand;
    public Transform Back;
    public float speed;
    public float delta;
    public bool TryAgain;
    void Start()
    {

    }

    void Update()
    {
        Hand = FindObjectOfType<HandMoveEnd>();
        if (TryAgain)
        {
            delta += Time.deltaTime;
            Hand.CheckEnd = true;
            if (delta > 5f)
                SceneManager.LoadScene(PlayerPrefs.GetInt("NowStage"));
        }
    }

    public void MoveChange()
    {
        HandOnOff.SetActive(true);
        TryAgain = true;
    }

}
