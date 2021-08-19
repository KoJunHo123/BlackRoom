using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStartPoint : MonoBehaviour
{
    [SerializeField] GameObject Wolf;
    [SerializeField] GameObject Sheep;
    [SerializeField] GameObject Glass;
    [SerializeField] GameObject Player;
    CheckEndPoint CheckEnd;
    public bool WolfinPoint=true;
    public bool SheepinPoint = true;
    public bool GlassinPoint = true;
    public bool PlayerinPoint = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckEnd = FindObjectOfType<CheckEndPoint>();
        if (!PlayerinPoint && !CheckEnd.GameOver)
        {
            CheckEnd.GameOver = CheckGameOver();
            Debug.Log("Startif");
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
        {
            PlayerinPoint = false;
            Debug.Log("1");
        }
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
        {
            PlayerinPoint = true;
            Debug.Log("3");
        }


    }

    bool CheckGameOver()
    {
        Debug.Log("Start");
        if (WolfinPoint && SheepinPoint)
        {
            Debug.Log("c");
            return true;
        }
        else if (SheepinPoint && GlassinPoint)
        {
            Debug.Log("d");
            return true;
        }
        else return false;
    }
}
