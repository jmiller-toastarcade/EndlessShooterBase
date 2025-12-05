using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   private Vector2 _screenBounds;
   public float MoveSpeed = 5.0f; // stores the movement speed value
   
   private Rigidbody2D _rb;
   private PlayerInputHandler _inputs;

   private void Start()
   {
      _rb = GetComponent<Rigidbody2D>();
      _screenBounds = GetScreenBounds(Camera.main);
      _inputs = GetComponent<PlayerInputHandler>();
   }

   private void Update()
   {
      ClampToScreen();
   }

   private void FixedUpdate()
   {
      HandlePhysicsMovement();
   }
   private void HandlePhysicsMovement()
   {
      _rb.linearVelocity = _inputs.MoveInput * MoveSpeed;
   }

   private Vector2 GetScreenBounds(Camera cam)
   {
      Vector3 screenTopRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
      return new Vector2(screenTopRight.x, screenTopRight.y);
   }

   private void ClampToScreen()
   {
      Vector2 position = transform.position;
      float halfShipWidth = transform.localScale.x / 2.0f;
      float halfShipHeight = transform.localScale.y / 2.0f;
      
      position.x = Mathf.Clamp(position.x, -_screenBounds.x + halfShipWidth, _screenBounds.x - halfShipWidth);
      position.y = Mathf.Clamp(position.y, -_screenBounds.y + halfShipHeight, _screenBounds.y - halfShipHeight);
      
      transform.position = position;
   }
}
