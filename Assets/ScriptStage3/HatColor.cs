using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatColor : MonoBehaviour
{
    [SerializeField] public Renderer[] HatPrepab;
    public bool Lock = false;
    ImageManager image;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Lock)
        {
            image = FindObjectOfType<ImageManager>();
            SelectHatColor(HatPrepab);
            image.getStageSet = true;
        }
    }

    void SelectHatColor(Renderer[] Hat)
    {
        int i = (Random.Range(0, 100) % 2) + 1;
        Hat[3].material.color = Hat[i].material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        if(i == 1)
        {
            Hat[2].material.color = Hat[0].material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }
        else
        {
            Hat[0].material.color = Hat[1].material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }
        Lock = true;

    }
}
