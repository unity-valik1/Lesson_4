using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : BaseBullet
{
    public float radius;
    public float force;

    private Vector3 vectorFly = new Vector3(0, 5, 8);

    protected override void Start()
    {
        rb.AddRelativeForce(vectorFly * speed, ForceMode.Force);
    }
    protected override void OnCollisionEnter(Collision collision)
    {
        Explode();
        base.OnCollisionEnter(collision);
    }
    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].attachedRigidbody;
            if (rb)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.white;
    }
}
