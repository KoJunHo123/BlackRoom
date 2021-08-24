using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckEndPoint : MonoBehaviour
{
    [SerializeField] GameObject Wolf;
    [SerializeField] GameObject Sheep;
    [SerializeField] GameObject Glass;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject XRrig;
    [SerializeField] GameObject floor;
    [SerializeField] AudioSource BGM;
    [SerializeField] GameObject Explain;
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject FadeOut;
    [SerializeField] GameObject GameOverText;
    CheckStartPoint CheckStart;
    StageManager1 Manager;
    public bool WolfinPoint = false;
    public bool SheepinPoint = false;
    public bool GlassinPoint = false;
    public bool PlayerinPoint = false;
    public bool GameOver;
    public bool GameClear;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckStart = FindObjectOfType<CheckStartPoint>();
        if (CheckStart.PlayerinPoint && !GameOver)
        {
            GameOver = CheckGameOver();
        }

        if (WolfinPoint && SheepinPoint && GlassinPoint && PlayerinPoint)
            GameClear = true;

        if(GameClear)
        {
            timer += Time.deltaTime;
            Explain.SetActive(false);
            Clear.SetActive(true);
            if (timer > 3.0f)
            {
                FadeOut.SetActive(true);
                BGM.volume -= 1f * (Time.deltaTime / 5f);
                if (timer > 8.0f)
                SceneManager.LoadScene(2);
            }
        }
        //게임 클리어 

        if (GameOver)
        {
            SetGameOver();
            PlayerPrefs.SetInt("NowStage", 1);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Tiger")
            WolfinPoint = false;
        if (other.gameObject.tag == "Sheep")
            SheepinPoint = false;
        if (other.gameObject.tag == "Glass")
            GlassinPoint = false;
        if (other.gameObject.tag == "Player")
            PlayerinPoint = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tiger")
            WolfinPoint = true;
        if (other.gameObject.tag == "Sheep")
            SheepinPoint = true;
        if (other.gameObject.tag == "Glass")
            GlassinPoint = true;
        if (other.gameObject.tag == "Player")
            PlayerinPoint = true;

    }

    bool CheckGameOver()
    {
        if (WolfinPoint && SheepinPoint)
        {
            return true;
        }
        else if (SheepinPoint && GlassinPoint)
        {
            return true;
        }
        else return false;
    }

    void SetGameOver()
    {
        Manager = FindObjectOfType<StageManager1>();
        timer += Time.deltaTime;
        GameOverText.SetActive(true);
        Explain.SetActive(false);
        if (timer > 3.0f)
        {
            Manager.GameOver = true;
            floor.GetComponent<BoxCollider>().isTrigger = true;
            XRrig.GetComponent<Rigidbody>().isKinematic = false;
            XRrig.GetComponent<Rigidbody>().useGravity = true;
            BGM.pitch -= 1f * (Time.deltaTime / 5f);
        }
        if (timer > 8f)
            SceneManager.LoadScene("GameOver");
    }

}
