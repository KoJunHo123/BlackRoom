using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMoveEnd : MonoBehaviour
{
    [SerializeField] Transform HandPosition;
    [SerializeField] GameObject player;
    public float speed;
    public bool CheckEnd;
    bool MoveEnd;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckEnd)
        {
            if (!MoveEnd)
            {
                transform.position = Vector3.MoveTowards(transform.position, HandPosition.position, speed * Time.deltaTime);
            }
            if(transform.position == HandPosition.position)
            {
                MoveEnd = true;
                player.GetComponent<SetParent>().getParent = true;
                gameObject.GetComponent<HandAnimation>().Grabplayer = true;
            }
            if (gameObject.GetComponent<HandAnimation>().GrabEnd)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * speed);
            }

        }

    }
}
