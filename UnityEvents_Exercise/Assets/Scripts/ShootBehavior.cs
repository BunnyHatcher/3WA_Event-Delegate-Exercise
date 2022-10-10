using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _cannon;
    public Transform bulletGroup;

    [SerializeField] float __bulletSpeed;

    //Setting shot intervall
    [SerializeField] float _delayBetweenShots = 0.2f;
    private float _nextShotTime;





    private void FireBullet()
    {
        GameObject newBullet = Instantiate(_bulletPrefab, _cannon.position, _cannon.rotation, bulletGroup);
        newBullet.GetComponent<BulletMovement>().Shoot(__bulletSpeed);
    }

    private void Awake()
    {
        _nextShotTime = Time.time;
    }


    
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextShotTime)
        
        {
            FireBullet();
            _nextShotTime = _delayBetweenShots + Time.time;
        }


    }
}
