using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    public float speed;
    public int liveTime;
    public Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    protected virtual void Start()
    {
        rb.velocity = transform.forward * speed;
    }
    protected virtual void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, liveTime);
    }
}
