using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    private Vector3 startPos;
    private Quaternion startRot;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = true;
            transform.position = startPos;
            transform.rotation = startRot;
            rb.isKinematic = false;
        }
    }
}
