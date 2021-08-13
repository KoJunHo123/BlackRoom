using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAnswer : MonoBehaviour
{
    HatColor Answer;
    ImageManager Left;
    ImageManager Right;
    int countAnswer = 0;
    public bool GameOver = false;
    public bool StageClear = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isAnswerLeft()
    {
        Answer = FindObjectOfType<HatColor>();
        Left = FindObjectOfType<ImageManager>();
        if(Answer.HatPrepab[2].material.color == Left.Left.color)
        {
            if (countAnswer < 2)
            { 
                countAnswer++;
                Debug.Log("아직덜깸" + countAnswer);
                Answer.testTrigger = true;
            }
            else if(countAnswer >= 2)
            {
                StageClear = true;
                Debug.Log("깸");
            }

        }
        else
        {
            GameOver = true;
            Debug.Log("왼쪽틀림"); //실패시 연출 작성할것
        }
    }
    public void isAnswerRight()
    {
        Answer = FindObjectOfType<HatColor>();
        Right = FindObjectOfType<ImageManager>();
        if (Answer.HatPrepab[2].material.color == Right.Right.color)
        {
            if (countAnswer < 2)
            {
                countAnswer++;
                Debug.Log("아직덜깸" + countAnswer);
                Answer.testTrigger = true;
            }
            else if (countAnswer >= 2)
            {
                StageClear = true;
                Debug.Log("깸");
            }

        }
        else
        {
            GameOver = true;
            Debug.Log("오른쪽틀림"); //실패시 연출 작성할것
        }
    }
}
