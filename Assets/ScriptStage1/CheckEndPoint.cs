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
    bool WolfinPoint;
    bool SheepinPoint;
    bool GlassinPoint;
    bool PlayerinPoint;
    bool GameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerinPoint)
            GameOver = CheckGameOver();

        if (WolfinPoint && SheepinPoint && GlassinPoint && PlayerinPoint) SceneManager.LoadScene(2) ;
            //게임 클리어 

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == Wolf.name)
            WolfinPoint = false;
        if (other.gameObject.name == Sheep.name)
            SheepinPoint = false;
        if (other.gameObject.name == Glass.name)
            GlassinPoint = false;
        if (other.gameObject.name == Player.name)
            PlayerinPoint = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == Wolf.name)
            WolfinPoint = true;
        if (other.gameObject.name == Sheep.name)
            SheepinPoint = true;
        if (other.gameObject.name == Glass.name)
            GlassinPoint = true;
        if (other.gameObject.name == Player.name)
            PlayerinPoint = true;

    }

    bool CheckGameOver()
    {
        if (WolfinPoint && SheepinPoint)
            return true;
        else if (SheepinPoint && GlassinPoint)
            return true;
        else return false;
    }
}
