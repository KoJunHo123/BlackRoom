using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] SpawnPostion;
    [SerializeField] GameObject AnswerGhost;
    [SerializeField] GameObject WrongGhost;
    QuizInfo data;
    StageManager5 Manager;
    public int WrongCount=0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGhost()
    {
        Manager = FindObjectOfType<StageManager5>();
        data = FindObjectOfType<QuizInfo>();
        if (Manager.i > 1)
        {
            if (data.Question[Manager.i] == data.Question[Manager.i - 2])
                Instantiate(AnswerGhost, SpawnPostion[Random.Range(0, 2)]);
            else
            {
                Instantiate(WrongGhost, SpawnPostion[Random.Range(0,2)]);
                WrongCount++;
            }
        }
    }
}
