using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    public LayerMask AnswerLayer;
    public LayerMask WrongLayer;
    StageManager5 stage5;

    [SerializeField] ParticleSystem hitAnswerParticle;
    [SerializeField] ParticleSystem hitWrongParticle;

    [SerializeField] GameObject AnswerAudioPlayer;
    [SerializeField] GameObject WrongAudioPlayer;

    void Start()
    {
        // var gameObj = GameObject.FindWithTag("Score");
        // score = gameObj.GetComponent<Score>();
        stage5 = FindObjectOfType<StageManager5>();
    }


    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, AnswerLayer))
        {
            Destroy(hit.transform.gameObject);
            Instantiate(hitAnswerParticle, hit.transform.position, Quaternion.LookRotation(hit.normal));
            Instantiate(AnswerAudioPlayer);
        }
        else if(Physics.Raycast(transform.position, transform.forward, out hit, 2, WrongLayer))
        {
            Destroy(hit.transform.gameObject);
            stage5.GameOver = true;
            Instantiate(hitWrongParticle, hit.transform.position, Quaternion.LookRotation(hit.normal));
            Instantiate(AnswerAudioPlayer);
        }
    }
}
    
