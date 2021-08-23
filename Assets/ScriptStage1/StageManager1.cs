using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager1 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    [SerializeField] Image FadeOut;
    TableMove Table;
    public bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
        Table = FindObjectOfType<TableMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            FadeOut.gameObject.SetActive(true);
        }
    }
    public void MoveTriggerChange()
    {
        if (Table.buttonPressed == true)
        {
            Table.buttonPressed = false;
            return;
        }
        if (Table.buttonPressed == false)
        {
            Table.buttonPressed = true;
        }
    }

    public void TeleportTriggerChange()
    {
        if(Table.teleportButton == true)
        {
            Table.teleportButton = false;
            return;
        }
        if(Table.teleportButton == false)
        {
            Table.teleportButton = true;
            return;
        }
    }
    

}
