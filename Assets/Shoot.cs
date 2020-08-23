using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject RiflePrefab;
    public GameObject ShotGunPrefab;
    public GameObject LaserPrefab;
    public float ShotGunbulletForce = 50f;
    public float RiflebulletForce = 30f;
    public string guntype = "w";
    private float fireRate = 0.2f;
    private float nextFire = 0f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >nextFire)
        {
            nextFire = Time.time + fireRate;
            if (guntype == "w")
            {
                ShootsRifle();
            }
            if (guntype == "q")
            {
                ShootsShotGun();
            }
            if (guntype == "e")
            {
                ShootsLaserGun();
            }
        }

        ChangeGun();
    }

    void ShootsRifle()
    {
        
        GameObject bullet = Instantiate(RiflePrefab, firePoint.position, firePoint.rotation);


        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * RiflebulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 2f);
    }
    void ShootsShotGun()
    {
        int bulletCount = 4;
        for (int i = 0; i < bulletCount; i++) {

            firePoint.Rotate(0, 0, Random.Range(-20, 20));
            GameObject bullet = Instantiate(ShotGunPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * ShotGunbulletForce, ForceMode2D.Impulse);
            Destroy(bullet, 2f);

        }
        

    }

    void ShootsLaserGun()
    {
        Vector3 newposition = transform.position;
        newposition.y += 4;
        
        GameObject bullet = Instantiate(LaserPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * 0, ForceMode2D.Impulse);
        Destroy(bullet, 1f);




    }
    void ChangeGun()
    {   // change gun and firerate
        if (Input.GetKeyDown("w"))
        {
            guntype = "w";
            fireRate = 0.2f;
}
        if (Input.GetKeyDown("q"))
        {
            guntype = "q";
            fireRate = 0.6f;

        }
        if (Input.GetKeyDown("e"))
        {
            guntype = "e";
            fireRate = 3f;

        }


    }
}
