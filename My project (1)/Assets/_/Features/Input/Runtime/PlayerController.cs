using UnityEngine;
using UnityEngine.InputSystem;

namespace Input.Runtime
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {
        #region Public Members
        
        public Vector2 MoveInput { get; }

        #endregion

        #region Private Variables

        private GameInputSystem _gameInputSystem;
        private Rigidbody _rigidbody;
        private float _speed = 10;
        private float _rotationSpeed = 1.2f;

        #endregion
        
        #region Unity API
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Awake()
        {
            _gameInputSystem = new GameInputSystem();
            _gameInputSystem.Enable();
            _gameInputSystem.Player.SetCallbacks(this);
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnDisable()
        {
            _gameInputSystem.Disable();
        }

        // Update is called once per frame
        void Update()
        {
            // _rigidbody.linearVelocity = transform.forward * _speed;
        }
        
        #endregion
        
        #region Main Methods

        // only rotate target using movement input
        public void OnMove(InputAction.CallbackContext context)
        {
            if (!context.performed) return;
            var moveInput = context.ReadValue<Vector2>();
            this.transform.Rotate(new Vector3(0, moveInput.x, 0));
        }

        public void OnLook(InputAction.CallbackContext context)
        {
        }

        public void SubToMoveEvent(Vector2 moveInput)
        {
        }

        public void UnsubFromMoveEvent()
        {
        }
        
        #endregion
    }
}
