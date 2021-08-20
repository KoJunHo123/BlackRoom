using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageManager5 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] AudioSource[] Number = new AudioSource[10];
    [SerializeField] GameObject FadeOut_GameClear;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject GameClearText;
    [SerializeField] GameObject LostOX;
    [SerializeField] GameObject Spawn;
    [SerializeField] AudioSource BGM;

    Spawn spawn;
    QuizInfo data;
    float timer=0;
    float timer2 = 0;
    public float quizTerm = 1.0f;
    public int i=0;
    public bool GameOver;
    public bool GameClear;
    public bool GameStart;
    int Index;
    // Start is called before the first frame update
    void Start()
    {
       FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStart && !GameOver)
        {
            timer += Time.deltaTime;
            if (timer > quizTerm)
            {
                Number[Index].pitch = 1f;
                PlayerQuiz();
            }
        }
        if (GameOver)
            gameObject.GetComponent<GetGameOver>().enabled = true;
        if (GameClear)
            Gameclear();
    }

    public void PlayerQuiz()
    {
        data = FindObjectOfType<QuizInfo>();
        spawn = FindObjectOfType<Spawn>();
        if ( i <  12)
        {
            Index = Random.Range(0, 10);
            if (Random.Range(0, 100) > 66 && i >= 2)
            {
                Index = data.Question[i - 2];
            }
            if(Random.Range(0,100) > 80)
            Number[Index].pitch = Random.Range(0.7f,2.5f);
            Number[Index].Play();
            Debug.Log(Index);
            data.Question[i] = Index;
            spawn.SpawnGhost();
            timer = 0;
            i++;
        }
        
    }

    public void Gameclear()
    {
        PlayerPrefs.SetInt("NowStage", 0);
        PlayerPrefs.SetInt("GameClear", 1);
        timer2 += Time.deltaTime;
        GameClearText.SetActive(true);
        if (timer2 > 3.0f)
        {
            FadeOut_GameClear.SetActive(true);
            Player.AddComponent<Rigidbody>();
            BGM.volume -= 1f * (Time.deltaTime / 5f);
            if (timer > 8.0f)
                SceneManager.LoadScene("GameEnd");
        }
    }
}
