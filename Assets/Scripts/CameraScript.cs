using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Player.transform.position.x;
        transform.position = position;
        position.y = Player.transform.position.y;
        transform.position = position;
    }
}
