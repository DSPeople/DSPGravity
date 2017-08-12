using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [Header("Camera properties")]
    [SerializeField]
    private Character _character;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(Vector2.right * Time.deltaTime * _character.GetSpeed(), ForceMode2D.Force);
    }
}
