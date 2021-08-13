using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StageManager5 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] AudioSource[] Number = new AudioSource[10];
    Spawn spawn;
    QuizInfo data;
    float timer=0;
    public float quizTerm = 1.0f;
    public int i=0;
    public bool GameOver;
    public bool GameClear;
    // Start is called before the first frame update
    void Start()
    {
       // FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > quizTerm)
        PlayerQuiz();
    }

    public void PlayerQuiz()
    {
        data = FindObjectOfType<QuizInfo>();
        spawn = FindObjectOfType<Spawn>();
        if ( i <  12)
        {
            int Index = Random.Range(0, 10);
            if (Random.Range(0, 100) > 66 && i >= 2)
                Index = data.Question[i - 2];
            Number[Index].Play();
            Debug.Log(Index);
            data.Question[i] = Index;
            spawn.SpawnGhost();
            timer = 0;
            i++;
        }
        
    }

    public void Gameover()
    {

    }
}
