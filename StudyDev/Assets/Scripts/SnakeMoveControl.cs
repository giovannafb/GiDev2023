using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class SnakeMoveControl : MonoBehaviour
{
    
    public SnakeMoves _snakeMoves;
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 10f;

   void Awake()
    {
        _snakeMoves = new SnakeMoves();
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        _snakeMoves.Player.Enable();
        _snakeMoves.Player.Move.performed += Move;
        _snakeMoves.Player.Move.canceled += Move;

        
    }

    void OnDisable()
    {
        _snakeMoves.Player.Move.Disable();
        _snakeMoves.Player.Move.performed -= Move;
        _snakeMoves.Player.Move.canceled -= Move;
 
    }

    void Move(InputAction.CallbackContext ctx)
    {
        _rb.velocity = new Vector3(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y) * _speed;
    }

}
