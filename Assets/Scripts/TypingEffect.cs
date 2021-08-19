using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class TypingEffect : MonoBehaviour
{
    [SerializeField] AudioSource TypingSound;
    public Text text;
    private string m_text = "You Failed." + "\n"+
        "DIE";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(1.0f);
        for (int i = 0; i <= m_text.Length; i++)
        {
            text.text = m_text.Substring(0, i);
            TypingSound.Play();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
