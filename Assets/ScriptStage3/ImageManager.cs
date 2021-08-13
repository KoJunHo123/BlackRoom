using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    [SerializeField] public Image Left;
    [SerializeField] public Image Right;
    HatColor GetColor;
    public bool getStageSet = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetColor = FindObjectOfType<HatColor>();
        if (getStageSet)
            getColor();
    }

    public void getColor()
    {
        GetColor = FindObjectOfType<HatColor>();
        int i = (Random.Range(0, 100) % 2) + 1;
        Left.color = GetColor.HatPrepab[i].material.color;
        Right.color = GetColor.HatPrepab[3 - i].material.color;
        getStageSet = false;
    }
}
