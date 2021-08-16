using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMove : MonoBehaviour
{
    [SerializeField] GameObject SoundPosition;
    [SerializeField] Transform Left;
    [SerializeField] Transform Right;
    public bool isLeftPlay;
    public bool isRightPlay;
    public bool isMoveLtoRPlay;
    public bool isMoveRtoLPlay;
    public bool Lock;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLeftPlay)
            isLeftPlay = LeftPlay();
        if (isRightPlay)
            isRightPlay = RightPlay();
        if (isMoveLtoRPlay)
            isMoveLtoRPlay = MoveLtoRPlay();
        if (isMoveRtoLPlay)
            isMoveRtoLPlay = MoveRtoLPlay();

    }

    public bool LeftPlay()
    {
        SoundPosition.transform.position = Left.position;
        SoundPosition.GetComponent<AudioSource>().Play();
        return false;
    }
    public bool RightPlay()
    {
        SoundPosition.transform.position = Right.position;
        SoundPosition.GetComponent<AudioSource>().Play();
        return false;
    }
    public bool MoveLtoRPlay()
    {
        if (!Lock)
        {
            SoundPosition.transform.position = Left.position;
            SoundPosition.GetComponent<AudioSource>().Play();
            Lock = true;
        }
        SoundPosition.transform.Translate(Vector3.right * Time.deltaTime*2f);
        if (SoundPosition.GetComponent<AudioSource>().isPlaying)
            return true;
        else
        {
            Lock = false;
            return false;
        }
    }
    public bool MoveRtoLPlay()
    {
        if (!Lock)
        {
            SoundPosition.transform.position = Right.position;
            SoundPosition.GetComponent<AudioSource>().Play();
            Lock = true;
        }
        SoundPosition.transform.Translate(-Vector3.right * Time.deltaTime*2f);
        if (SoundPosition.GetComponent<AudioSource>().isPlaying)
            return true;
        else
        {
            Lock = false;
            return false;
        }
    }
}
