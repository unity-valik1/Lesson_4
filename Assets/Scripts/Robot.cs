using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float fireRate = 0.5f;//частота стрельбы
    private float nextFire;

    Rigidbody rb;

    public GameObject bullet;
    public GameObject[] prefab;

    [SerializeField] private GameObject startPosBullet;
    [SerializeField] private GameObject particleEffectPrefab;


    void Start()
    {
        bullet = prefab[0];
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Move();
        Fire();
    }
    private void Move()
    {
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        if (sideForce != 0.0f)
        {
            rb.angularVelocity = new Vector3(0.0f, sideForce, 0.0f);
        }

        float forwardForce = Input.GetAxis("Vertical") * movementSpeed;
        if (forwardForce != 0.0f)
        {
            rb.velocity = rb.transform.forward * forwardForce;
        }
    }
    private void Fire()
    {
        if (Input.GetButtonDown("Fire1") && nextFire <= 0)
        {
            Instantiate(bullet, startPosBullet.transform.position, startPosBullet.transform.rotation);
            Instantiate(particleEffectPrefab, startPosBullet.transform.position, startPosBullet.transform.rotation);
            nextFire = fireRate;
        }
        if (nextFire > 0)
        {
            nextFire -= Time.deltaTime;
            print(nextFire);
        }
    }
}
