using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Transform _transform;
    private Rigidbody _rigidbody;
    private float _bulletSpeed;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();

        Destroy(gameObject, 5f);

    }

    private void FixedUpdate()
    {
        // calculate bullet movement
        Vector3 bulletPos = (_transform.forward * _bulletSpeed * Time.fixedDeltaTime) + _transform.position;
        _rigidbody.MovePosition(bulletPos);
    }

    public void Shoot(float speed)
    {
        _bulletSpeed = speed;
    }
}
