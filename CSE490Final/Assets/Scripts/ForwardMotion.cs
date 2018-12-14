using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMotion : MonoBehaviour
{

    public float speed = 1;
    private Vector3 origin;
    public float distanceReset;
    public Vector3 direction;

    private void Start()
    {
        origin = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(direction * speed * 0.01f);
        if (Vector3.Distance(origin, transform.position) > distanceReset) {
           transform.position = origin;
        }
    }
}
