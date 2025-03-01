using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private string _Horizontal = "Horizontal";
    private float _xMovement;
    private int _speed = 5;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _xMovement = Input.GetAxis(_Horizontal);
        _rb.velocity = new Vector2(_xMovement * _speed, _rb.velocity.y);
    }
}
