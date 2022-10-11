using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float _bulletSpeed;
    [SerializeField] Transform _bulletGroup;

    //Setting shot intervall
    [SerializeField] float _delayBetweenShots = 0.2f;
    private float _nextShotTime;

    





    private void FireBullet()
    {
        // create Vector2 for all 4 directions
        Vector2[] _directions = new Vector2[4]
        {

            Vector2.right,
            Vector2.left,
            Vector2.up,
            Vector2.down

        };

        // create bullets in all 4 directions via for loop
        for (int i = 0; i < 4; i++)
        {   
            //create bullets via Instantiate at the transform of the game object the script is added to
            GameObject newBullet = Instantiate(_bulletPrefab, gameObject.transform.position, Quaternion.identity);
            
            //center instanciated bullet at centre of instanciater game object
            //newBullet.transform.localPosition = Vector2.zero;
            
            //give bullets velocity via Add force
            newBullet.GetComponent<Rigidbody2D>().AddForce(_directions[i] * _bulletSpeed);
            
            //add instanciated bullets to transform of parent in hierarchy
            newBullet.transform.parent = _bulletGroup;
        }
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

            var playerRenderer = GetComponent<SpriteRenderer>();
            playerRenderer.color = Color.green;

            _nextShotTime = _delayBetweenShots + Time.time;
        }

        


    }
}
