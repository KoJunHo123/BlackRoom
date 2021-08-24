using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver3Manage : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] GameObject FadeOut;
    float timer;
    public float UsingTime;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 8.0f)
        {
            FadeOut.SetActive(true);

            if (timer > UsingTime)
                SceneManager.LoadScene("GameEnd");
        }
    }
}
