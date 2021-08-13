using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickNo : MonoBehaviour
{
    public bool trigger = false;
    public float delta = 0;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject FadeOutPanel;
    [SerializeField] GameObject Title;
    public bool Effect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == true)
        {
            delta += Time.deltaTime;
            if (delta > 0.5f)
            {
                text1.SetActive(true);
            }
            if (delta > 1.0f)
            {
                text2.SetActive(true);
            }
            if (delta > 1.5f)
            {
                text3.SetActive(true);

            }

            if (delta > 3.0f)
            {
                Effect = true;
                FadeOutPanel.SetActive(true);
                Title.SetActive(false);
            }
            if (delta > 5.5f)
            {
                Destroy(text1);
                Destroy(text2);
                Destroy(text3);
            }
        }

        if (FadeOutPanel.gameObject.GetComponent<Image>().color.a > 0.99f)
            SceneManager.LoadScene(1);
    }
}
