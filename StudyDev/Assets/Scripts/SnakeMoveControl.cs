using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

public class SnakeMoveControl : MonoBehaviour
{
    //Tentei passar o _eat como referencia mas a Unity diz que não está referenciado, tentei vários métodos
    public SnakeMoves _snakeMoves;
    private Rigidbody2D _rb;
    public float _eat;
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
        _snakeMoves.Player.Eat.performed += Eat;
        _snakeMoves.Player.Eat.canceled += Eat;
        
    }

    void OnDisable()
    {
        _snakeMoves.Player.Move.Disable();
        _snakeMoves.Player.Move.performed -= Move;
        _snakeMoves.Player.Move.canceled -= Move;
        _snakeMoves.Player.Eat.performed -= Eat;
        _snakeMoves.Player.Eat.canceled -= Eat;
    }

    void Move(InputAction.CallbackContext ctx)
    {
        _rb.velocity = new Vector3(ctx.ReadValue<Vector2>().x, ctx.ReadValue<Vector2>().y) * _speed;
    }

        void Eat(InputAction.CallbackContext ctx)
    {
        _eat = ctx.ReadValue<float>();
    }
}
