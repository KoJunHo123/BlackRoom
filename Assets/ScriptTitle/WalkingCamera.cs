using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class WalkingCamera : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject FadeOutPanel;
    [SerializeField] AudioSource WalkSound;
    public float delta = 0;
    bool Lock = false;
    bool WalkSoundPlay;
    // Start is called before the first frame update
    void Start()
    {
        FadeOutPanel.GetComponent<Image>();
        WalkSound.time = 2.35f;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (canvas.activeSelf == false && delta > 2f)
        {
            GetComponent<Animator>().enabled = true;
            if (!WalkSoundPlay)
            {
                WalkSound.Play();
                WalkSoundPlay = true ;
            }
            if (delta > 3f)
                FadeOutPanel.SetActive(true);
            if (FadeOutPanel.gameObject.GetComponent<Image>().color.a > 0.99f)
            {
                if (SceneManager.GetActiveScene().name == "Title")
                {
                    Debug.Log("2");
                    SceneManager.LoadScene(1);
                }
                else if (SceneManager.GetActiveScene().name == "GameEnd")
                {
                    Application.Quit();
                    Debug.Log("µÅ");
                }
            }
        }

    }
}
