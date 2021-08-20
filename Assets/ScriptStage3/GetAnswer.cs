using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetAnswer : MonoBehaviour
{
    [SerializeField] GameObject Explain;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject ClearFadeOut;
    [SerializeField] GameObject Timer;
    [SerializeField] AudioSource BGM;
    HatColor Answer;
    ImageManager Left;
    ImageManager Right;
    int countAnswer = 0;
    public bool GameOver = false;
    public bool GameClear = false;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameClear)
        {
            timer += Time.deltaTime;
            Explain.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            Clear.SetActive(true);
            Timer.SetActive(false);
            if (timer > 3.0f)
            {
                BGM.volume -= 1f * (Time.deltaTime / 5f);
                ClearFadeOut.SetActive(true);
                if (timer > 8.0f)
                    SceneManager.LoadScene(4);

            }
        }
        
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
                Answer.Lock = false;
            }
            else if(countAnswer >= 2)
            {
                GameClear = true;
            }

        }
        else
        {
            GameOver = true;
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
                Answer.Lock = false;
            }
            else if (countAnswer >= 2)
            {
                GameClear = true;
            }

        }
        else
        {
            GameOver = true; //실패시 연출 작성할것
        }
    }
}
