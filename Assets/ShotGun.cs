using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Guns
{
    public int pelletCount = 5;
    public float spreadAngle = 15f;

    public override void Fire()
    {
        for (int i = 0; i < pelletCount; i++)
        {
            float angle = Random.Range(-spreadAngle, spreadAngle);
            Quaternion rot = firePoint.rotation * Quaternion.Euler(0, 0, angle);
            Instantiate(bulletPrefab, firePoint.position, rot);
        }
    }

    void Start()
    {
        fireRate = 1f;
    }
}