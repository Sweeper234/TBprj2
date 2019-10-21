using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public int distance;
    public int angle;
    public GameObject target;

    void Start()
    {
    }

    void Update()
    {
        transform.position = target.transform.position - transform.forward * distance;
        transform.rotation = Quaternion.AngleAxis(angle, transform.right);
    }
}
