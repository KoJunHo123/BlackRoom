using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager1 : MonoBehaviour
{
    [SerializeField] GameObject FadeIn;
    TableMove Table;
    // Start is called before the first frame update
    void Start()
    {
        FadeIn.SetActive(true);
        Table = FindObjectOfType<TableMove>();
    }

    // Update is called once per frame
    void Update()
    {

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
