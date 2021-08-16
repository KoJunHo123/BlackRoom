using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    public LayerMask AnswerLayer;
    public LayerMask WrongLayer;
    StageManager5 stage5;

    void Start()
    {
        // var gameObj = GameObject.FindWithTag("Score");
        // score = gameObj.GetComponent<Score>();
        stage5 = FindObjectOfType<StageManager5>();
    }


    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, AnswerLayer))
        {
            Destroy(hit.transform.gameObject);
        }
        else if(Physics.Raycast(transform.position, transform.forward, out hit, 1, WrongLayer))
        {
            Destroy(hit.transform.gameObject);
            stage5.GameOver = true;
        }
    }
}
    //private void OnTriggerEnter(Collider other)
    //{
    //    Manager = FindObjectOfType<StageManager5>();
    //    if (other.gameObject.tag == "Answer")
    //        Destroy(other);
    //    else Manager.GameOver = true;
    //}
