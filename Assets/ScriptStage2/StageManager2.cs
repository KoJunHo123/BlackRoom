using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager2 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] GameObject Scale;
    int UsingScale = 2;
    int ClearCount = 3;
    AnswerPlate GetClear;
    public bool GameClear;
    public bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void ShowState()
    {
        if (UsingScale > 0)
        {
            RightCheckMass Right = FindObjectOfType<RightCheckMass>();
            LeftCheckMass Left = FindObjectOfType<LeftCheckMass>();
            ScaleRotate ScaleControll = FindObjectOfType<ScaleRotate>();
            ScaleControll.speed = 100f;
            if (Left.Mass > Right.Mass)
            {
                ScaleControll.isLeftHeavy = true;
            }
            if (Left.Mass < Right.Mass)
            {
                ScaleControll.isRightHeavy = true;
            }
            UsingScale--;
        }
    }

    public void CheckClear()
    {
        GetClear = FindObjectOfType<AnswerPlate>();
        if (GetClear.isAnswer == true)
        {
            ClearCount--;
            if (ClearCount <= 0)
                GameClear = true;//2스테이지 3번 클리어할시 다음 스테이지로 넘어가는 연출
        }
        else { GameOver = true; } //정답존에 오답을 올리고 버튼이 호출되면 게임오버 연출
            
    }

}
