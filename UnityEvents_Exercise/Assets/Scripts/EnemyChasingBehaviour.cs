using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasingBehaviour : MonoBehaviour
{
    [HideInInspector]
    public GameObject _target; // the player
    public float _speed;
    public Vector2 _dir;
    private Rigidbody2D _rgbd;

    private void Awake()
    {
        _target = GameObject.Find("Player");
        _rgbd = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        //calculating direction towards _target
        _dir = _target.transform.position - transform.position;
        _dir = _dir.normalized;
        _rgbd.velocity = _dir * _speed * Time.deltaTime;
    }


}
