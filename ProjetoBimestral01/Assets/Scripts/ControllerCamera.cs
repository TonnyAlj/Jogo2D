using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    public Transform player;
    [SerializeField]private float maxXCam;
    [SerializeField]private float minXCam;

    [SerializeField]private float maxYCam;
    [SerializeField]private float minYCam;

    void FixedUpdate()
    {
        if(player.position.x >= minXCam && player.position.x <= maxXCam)
        {
           transform.position = new Vector2(player.position.x, transform.position.y);
        }

        if(player.position.y >= minYCam && player.position.y <= maxYCam)
        {
           transform.position = new Vector2(transform.position.x, player.position.y);
        }
    }
}
