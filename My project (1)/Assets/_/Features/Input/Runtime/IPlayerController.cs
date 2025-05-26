using UnityEngine;

namespace Input.Runtime
{
    public interface IPlayerController : GameInputSystem.IPlayerActions
    {
        public Vector2 MoveInput { get; }
        
        public void SubToMoveEvent(Vector2 moveInput);
        public void UnsubFromMoveEvent();
    }
}