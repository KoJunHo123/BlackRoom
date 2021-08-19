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
        if (CheckEnd.PlayerinPoint && !CheckEnd.GameOver)
        {
            CheckEnd.GameOver = CheckGameOver();
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
        }


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
}
