using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//�������� Ŭ���� ���� �� ���� �ۼ�
public class GetGameOver : MonoBehaviour
{
    [SerializeField] GameObject FadeOut_GameOver;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject GameOverText;
    [SerializeField] GameObject LostOX;
    [SerializeField] GameObject Spawn;
    [SerializeField] AudioSource BGM;
    StageManager5 Over;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Over = FindObjectOfType<StageManager5>();
        if (Over.GameOver)
        {
            timer += Time.deltaTime;
            BGM.pitch -= 1f * (Time.deltaTime / 12f);
            PlayerPrefs.SetInt("NowStage", 5);
            GameOverText.SetActive(true);
            Spawn.SetActive(false);
            LostOX.SetActive(false);
            if (timer > 3.0f)
            {
                FadeOut_GameOver.SetActive(true);
                Player.AddComponent<Rigidbody>();
            }

            if (timer > 7.0f)
                SceneManager.LoadScene("GameOver2");
        }

    }


}
