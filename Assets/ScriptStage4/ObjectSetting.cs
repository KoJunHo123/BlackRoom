using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSetting : MonoBehaviour
{
    public bool SameOrDiff; //true:같은물체 false:다른물체
    StageManager4 StageManager;

    public AudioSource GhostAudioPlayer;
    public AudioClip screamClip;

    [SerializeField] ParticleSystem hitParticlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StageManager = FindObjectOfType<StageManager4>();
        if (other.gameObject.tag == "Bullet")
        {
            if (SameOrDiff == false)
            {
                StageManager.count--;
                Destroy(other);
                Destroy(gameObject);
                Instantiate(hitParticlePrefab, transform.position, transform.rotation);
                GhostAudioPlayer.clip = screamClip;
                GhostAudioPlayer.Play();
            }
            else StageManager.GameOver = true;
        }
    }
}
