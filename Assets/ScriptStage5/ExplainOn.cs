using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainOn : MonoBehaviour
{
    [SerializeField] GameObject[] ExplainText;
    [SerializeField] GameObject Spawn;
    [SerializeField] GameObject LostOX;
    public float term = 5f;
    float timer;
    bool ExplainEnd = false;
    int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ExplainText.Length);

    }

    // Update is called once per frame
    void Update()
    {
        if(!ExplainEnd)
        ExplainAppear();
        if(ExplainEnd)
        setStart();
    }

    void ExplainAppear()
    {
        timer += Time.deltaTime;
        if (i < ExplainText.Length)
        {
            if (timer > 3.0f && i == 0)
            {
                ExplainText[i].SetActive(true);
                i++;
            }
            else if (timer > 3.0f + (i * term))
            {
                ExplainText[i - 1].SetActive(false);
                ExplainText[i].SetActive(true);
                i++;
            }
        }
        else 
        {
            if (timer > 3.0f + (i * term))
            {
                ExplainText[i - 1].SetActive(false);
                ExplainEnd = true;
            }
        }
    }

    void setStart()
    {
        gameObject.GetComponent<StageManager5>().enabled = true;
        gameObject.GetComponent<StageManager5>().GameStart = true;
        LostOX.SetActive(true);
        Spawn.SetActive(true);
    }
}
