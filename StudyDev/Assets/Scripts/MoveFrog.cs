using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEditor;


//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveFrog : MonoBehaviour
{
    private FrogMovement _frogMovement;
    private Rigidbody2D _rb;
    [SerializeField] private float speed = 10f;

    void Awake()
    {
        _frogMovement = new FrogMovement();
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        _frogMovement.Player.Enable();
        _frogMovement.Player.Move.performed += Move;
        _frogMovement.Player.Move.canceled += Move;
    }

    void OnDisable()
    {
        _frogMovement.Player.Disable();
        _frogMovement.Player.Move.performed -= Move;
        _frogMovement.Player.Move.canceled -= Move;
    }

    void Move(InputAction.CallbackContext ctx)
    {   
        _rb.velocity = new Vector3(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y) * speed;
    }
}
