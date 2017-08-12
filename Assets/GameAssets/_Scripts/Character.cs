using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Character properties")]
    [SerializeField]
    private float _speed = 1;
    [SerializeField]
    private LayerMask _layerMask;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _rigidbody.IsTouchingLayers(_layerMask))
        {
            _rigidbody.gravityScale *= -1;
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(Vector2.right * Time.deltaTime * _speed, ForceMode2D.Force);
    }

    public float GetSpeed()
    {
        return _speed;
    }
    
    public void SetSpeed(float newSpeed)
    {
        _speed = newSpeed;
    }
}
