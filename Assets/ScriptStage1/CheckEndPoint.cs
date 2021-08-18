using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckEndPoint : MonoBehaviour
{
    [SerializeField] GameObject Wolf;
    [SerializeField] GameObject Sheep;
    [SerializeField] GameObject Glass;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject XRrig;
    [SerializeField] GameObject floor;
    [SerializeField] AudioSource BGM;
    public bool WolfinPoint = false;
    public bool SheepinPoint = false;
    public bool GlassinPoint = false;
    public bool PlayerinPoint = false;
    public bool GameOver;
    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerinPoint && !GameOver)
        {
            GameOver = CheckGameOver();
            Debug.Log("Endif");
        }

        if (WolfinPoint && SheepinPoint && GlassinPoint && PlayerinPoint)
        {
            SceneManager.LoadScene(2);
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
        Debug.Log("End");
        if (WolfinPoint && SheepinPoint)
            return true;
        else if (SheepinPoint && GlassinPoint)
            return true;
        else return false;
    }

    void SetGameOver()
    {
        timer += Time.deltaTime;
        floor.GetComponent<BoxCollider>().isTrigger = true;
        XRrig.GetComponent<Rigidbody>().isKinematic= false;
        XRrig.GetComponent<Rigidbody>().useGravity = true;
        BGM.pitch -= 1f * (Time.deltaTime / 5f);
        if (timer > 5f)
            SceneManager.LoadScene("GameOver");
    }

}
