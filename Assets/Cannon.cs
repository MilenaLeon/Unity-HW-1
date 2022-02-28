using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Cannon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float Timer = 2;

    public Vector3 _initialVelocity;
    

    private void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Fire();
            Timer = 2f;
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.AddForce(_initialVelocity, ForceMode.Impulse);
    }
   
}
