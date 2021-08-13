using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManagement : MonoBehaviour
{
    ClickNo getEffect = null;
    float delta=0;
    [SerializeField] GameObject Door;
    [SerializeField]  GameObject Player;
    //[SerializeField]  GameObject[] Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        getEffect = FindObjectOfType<ClickNo>();
        if(getEffect.Effect == true)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + Time.deltaTime * 3);
            Door.transform.localScale = new Vector3(Door.transform.localScale.x + Time.deltaTime , Door.transform.localScale.y + Time.deltaTime , Door.transform.localScale.z);

        }
        
    }
}
