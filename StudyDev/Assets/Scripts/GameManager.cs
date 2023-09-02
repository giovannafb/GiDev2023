using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    private SnakeMoves _snakeMoves;
    public float _eat;

    void Awake()
    {
        _snakeMoves = new SnakeMoves();
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void OnEnable()
    {
        _snakeMoves.Enable();
        _snakeMoves.Player.Eat.performed += Eat;
        _snakeMoves.Player.Eat.canceled += Eat;
    }

    void OnDisable()
    {
        _snakeMoves.Disable();
        _snakeMoves.Player.Eat.performed -= Eat;
        _snakeMoves.Player.Eat.canceled -= Eat;
    }

    public void Eat(InputAction.CallbackContext ctx)
    {
        _eat = ctx.ReadValue<float>();
        Debug.Log(_eat);
    }
}
