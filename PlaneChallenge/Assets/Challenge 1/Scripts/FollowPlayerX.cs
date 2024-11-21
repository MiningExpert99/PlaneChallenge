using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    private const int V = 0;
    public GameObject plane;
    private Vector3 offset = new Vector3(50, 0, 10);

    // Update is called once per frame

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
