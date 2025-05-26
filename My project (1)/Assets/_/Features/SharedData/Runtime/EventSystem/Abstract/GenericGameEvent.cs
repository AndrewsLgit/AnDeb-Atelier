using System.Collections.Generic;
using UnityEngine;

namespace _.Database.EventSystem.Abstract
{
    //[CreateAssetMenu(fileName = "New GameEvent", menuName = "Event System/intGameEvent")]
    public abstract class GenericGameEvent<T> : ScriptableObject, IGenericGameEvent<T>
    {
        #region Private Variables

        private HashSet<GenericGameEventListener<T>> _listeners = new HashSet<GenericGameEventListener<T>>();
        private T _value;

        #endregion
        
        #region Main Methods
        
        public void SubscribeToEvent(GenericGameEventListener<T> listener) => _listeners.Add(listener);

        public void UnsubscribeFromEvent(GenericGameEventListener<T> listener) => _listeners.Remove(listener);

        public void Raise(T value)
        {
            foreach (var gameEventListener in _listeners)
            {
            
                gameEventListener.RaiseEvent(value);
            }
        }
        
        #endregion

        #region Utils // remove later (useless)
        
        public T Value => _value;
        
        public void SetValue(T value)
        {
            _value = value;
        }
        
        #endregion
    }
}