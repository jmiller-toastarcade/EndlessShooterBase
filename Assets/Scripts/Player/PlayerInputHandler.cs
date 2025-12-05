using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput _playerInput; // stores the PlayerInput instance
    public Vector2 MoveInput; // stores movement input values
    public bool IsShooting; // stores whether the player is pushing the fire button

    private void OnEnable()
    {
        _playerInput.Player.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Player.Disable();
    }
    private void Awake()
    {
        _playerInput = new PlayerInput(); // create a new instance of an object

        _playerInput.Player.Move.performed += OnMovePerformed; // subscribe to the OnMovePerformed function
        _playerInput.Player.Move.canceled += OnMoveCanceled; // subscribe to the OnMoveCanceled function
        _playerInput.Player.Fire1.performed += OnFireStart; // subscribe to the OnFireStart function
        _playerInput.Player.Fire1.canceled += OnFireStop; // subscribe to the OnFirstStop function
    }

    private void OnMovePerformed(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        MoveInput = Vector2.zero;
    }

    private void OnFireStart(InputAction.CallbackContext context)
    {
        IsShooting = true;
    }

    private void OnFireStop(InputAction.CallbackContext context)
    {
        IsShooting = false;
    }
}
