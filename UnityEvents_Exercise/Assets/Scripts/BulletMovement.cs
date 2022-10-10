using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Transform _transform;
    private Rigidbody2D _rb2dBullet;
    [SerializeField] private float _bulletSpeed = 1500f;

    private void Awake()
    {
        _rb2dBullet = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();

        Destroy(gameObject, 5f);

    }

    private void FixedUpdate()
    {
        // calculate bullet movement
        Vector2 bulletPos = (_transform.forward * _bulletSpeed * Time.fixedDeltaTime) + _transform.position;
        _rb2dBullet.velocity = bulletPos;
        
    }

    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }
}
