using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    ClickNo trigger = null;
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
    // Start is called before the first frame update
    void Start()
    {
        trigger = FindObjectOfType<ClickNo>();
        //PlayerPrefs.SetInt("NowStage", 0);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void SetObjectTrue(GameObject Object)
    {
        Object.SetActive(true);
    }
    public void SetObjectFalse(GameObject Object)
    {
        Object.SetActive(false);
    }
    public void SetTriggerOn()
    {
        trigger.trigger = true;
    }

}
