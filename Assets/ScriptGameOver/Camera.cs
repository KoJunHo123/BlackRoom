using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerCamera.transform.position;// new Vector3(PlayerCamera.transform.position.x, PlayerCamera.transform.position.y, PlayerCamera.transform.position.z);
    }
}
