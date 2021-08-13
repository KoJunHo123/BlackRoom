using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WalkingCamera : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject FadeOutPanel;
    float delta=0;
    // Start is called before the first frame update
    void Start()
    {
        FadeOutPanel.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(canvas.activeSelf == false && delta > 2f)
        {
            GetComponent<Animator>().enabled = true;
            if (delta > 3f)
                FadeOutPanel.SetActive(true);
            if (FadeOutPanel.gameObject.GetComponent<Image>().color.a > 0.9f)
                SceneManager.LoadScene(1);
        }

    }
}
