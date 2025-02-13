using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 moveDirection;
    private float speed;
    public float lifeTime = 3f;

    public void Initialize(Vector2 direction, float bulletSpeed)
    {
        moveDirection = direction;
        speed = bulletSpeed;
        Destroy(gameObject, lifeTime); 
    }

    void Update()
    {
        transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
    }
}
