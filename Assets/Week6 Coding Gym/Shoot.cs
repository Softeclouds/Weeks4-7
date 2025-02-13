using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject tankBarrel;
    float bulletSpeed;

    public Slider bulletSlider;

    // Update is called once per frame
    void Update()
    {
        bulletSpeed = bulletSlider.value;
        if (Input.GetMouseButtonDown(0)) 
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - (Vector2)tankBarrel.transform.position).normalized;

        Quaternion bulletRotation = Quaternion.FromToRotation(Vector3.right, direction);

        GameObject bullet = Instantiate(bulletPrefab, tankBarrel.transform.position, bulletRotation);

        bullet.GetComponent<Bullet>().Initialize(direction, bulletSpeed);
    }
}
