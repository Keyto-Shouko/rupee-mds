using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 _movement;
    private Rigidbody2D _rigidbody2D;
    [Range(5f, 20f)]
    public float speed = 10f;

    private void Awake()
    {
        Debug.Log("awake");
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        _movement = new Vector2(horizontal, vertical).normalized;
        Debug.Log(_movement);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _movement * speed;

    }
}
