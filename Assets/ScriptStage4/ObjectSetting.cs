using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSetting : MonoBehaviour
{
    public bool SameOrDiff; //true:������ü false:�ٸ���ü
    StageManager4 StageManager;

    [SerializeField] GameObject GhostAudioPlayer;

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
                Instantiate(hitParticlePrefab, transform.position, transform.rotation);
                Instantiate(GhostAudioPlayer);
                Destroy(other);
                Destroy(gameObject);
            }
            else StageManager.GameOver = true;
        }
    }
}
