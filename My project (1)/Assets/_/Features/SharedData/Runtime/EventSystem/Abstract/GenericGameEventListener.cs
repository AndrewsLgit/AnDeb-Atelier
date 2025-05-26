using UnityEngine;
using UnityEngine.Events;

namespace _.Database.EventSystem.Abstract
{
    public class GenericGameEventListener<T> : MonoBehaviour , IGenericGameEventListener<T>
    {
        #region Private Variables
        
        [SerializeField] private GenericGameEvent<T> _event;
        [SerializeField] private UnityEvent<T> _raised;
        #endregion
        
        #region Main Methods

        private void Awake()
        {
            _event.SubscribeToEvent(this);
        }
        private void OnDisable()
        {
            _event.UnsubscribeFromEvent(this);
        }
        
        public void RaiseEvent(T value)
        {
            _raised?.Invoke(value);
        }
        
        #endregion
    }
}