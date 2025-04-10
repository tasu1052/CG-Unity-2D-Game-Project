using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG : Guns
{
    public override void Fire()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void Start()
    {
        fireRate = 10f;
    }
}