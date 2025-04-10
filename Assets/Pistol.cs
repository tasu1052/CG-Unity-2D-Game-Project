using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Guns
{
    public override void Fire()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}