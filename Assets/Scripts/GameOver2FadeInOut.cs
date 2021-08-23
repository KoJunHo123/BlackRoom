using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2FadeInOut : MonoBehaviour
{

    public GameObject FadeIn;
    public GameObject FadeOut;

    public float delta;

    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > 8)
        {
            FadeOut.SetActive(true);
        }
        if(delta > 13)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
