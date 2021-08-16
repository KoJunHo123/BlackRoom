using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager2 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] GameObject Scale;
    [SerializeField] Text RemainClear;
    [SerializeField] Text RemainUse;
    [SerializeField] GameObject Explain;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject Over;
    [SerializeField] AudioSource Answer;
    [SerializeField] AudioSource Wrong;
    MakeWeight MakeWeight;
    int UsingScale = 2;
    int ClearCount = 3;
    AnswerPlate GetClear;
    public bool GameClear;
    public bool GameOver;
    public bool Lock;
    public bool DestroyWeight;
    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        MakeWeight = FindObjectOfType<MakeWeight>();
        FadeIn.SetActive(true);
        MakeWeight.SetStage();
        
        RemainUse.text = "Remain use: " + UsingScale;
        RemainClear.text = "Remain Clear: " + ClearCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameClear)
        {
            Explain.SetActive(false);
            float timer = 0;
            timer += Time.deltaTime;
            Clear.SetActive(true);
            if (timer > 5.0f)
                SceneManager.LoadScene(3);
        }
        if(GameOver)
        {
            Explain.SetActive(false);
            Over.SetActive(true);
            RemainClear.gameObject.SetActive(false);
            RemainUse.gameObject.SetActive(false);
        }
        
    }

    public void ShowState()
    {
        if (!Lock && UsingScale > 0)
        {
            Lock = true;
            if (UsingScale > 0)
            {
                RightCheckMass Right = FindObjectOfType<RightCheckMass>();
                LeftCheckMass Left = FindObjectOfType<LeftCheckMass>();
                ScaleRotate ScaleControll = FindObjectOfType<ScaleRotate>();
                ScaleControll.speed = 20f;
                if (Left.Mass > Right.Mass)
                {
                    ScaleControll.isLeftHeavy = true;
                }
                if (Left.Mass < Right.Mass)
                {
                    ScaleControll.isRightHeavy = true;
                }
                UsingScale--;
                RemainUse.text = "Remain use: " + UsingScale;

            }
        }
    }

    public void CheckClear()
    {
        MakeWeight makeWeight = FindObjectOfType<MakeWeight>();
        GetClear = FindObjectOfType<AnswerPlate>();
        if (GetClear.isAnswer == true)
        {
            ClearCount--;
            RemainClear.text = "Remain Clear: " + ClearCount;
            Answer.GetComponent<AudioSource>().Play();

            if (ClearCount > 0)
            {
                DestroyWeight = true;
                Invoke("StageSet", 3.0f);
                GetClear.isAnswer = false;
            }
            else
            {
                GameClear = true;
            }
        }
        else
        {
            Wrong.GetComponent<AudioSource>().Play();
            GameOver = true;
        }
    }
    void StageSet()
    {
        MakeWeight = FindObjectOfType<MakeWeight>();
        MakeWeight.SetStage();
    }
}
