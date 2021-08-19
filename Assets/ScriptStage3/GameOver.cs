using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//스테이지 클리어 실패 시 연출 작성
public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject FadeOut_GameOver;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject GameOverText;
    [SerializeField] AudioSource BGM;
    GetAnswer Over;
    float timer;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Over = FindObjectOfType<GetAnswer>();
        if (Over.GameOver)
        {
            PlayerPrefs.SetInt("NowStage", 3);
            timer += Time.deltaTime;
            BGM.pitch -= 1f * (Time.deltaTime / 10f);
            GameOverText.SetActive(true);
            if (timer > 3.0f)
            {
                FadeOut_GameOver.SetActive(true);
                Player.AddComponent<Rigidbody>();
            }

            if (timer > 7.0f)
                SceneManager.LoadScene("GameOver");
        }

    }


}
