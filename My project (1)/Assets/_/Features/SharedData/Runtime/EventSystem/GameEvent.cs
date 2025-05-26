using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//[CreateAssetMenu(fileName = "New GameEvent", menuName = "Event System/GameEvent", order = 0)]
public class GameEvent : ScriptableObject
{
    private HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

    public void SubscribeToEvent(GameEventListener listener) => _listeners.Add(listener);

    public void UnsubscribeFromEvent(GameEventListener listener) => _listeners.Remove(listener);

    public void Raise()
    {
        foreach (var gameEventListener in _listeners)
        {
            gameEventListener.RaiseEvent();
        }
    }
}




// //[CreateAssetMenu(fileName = "New GameEvent", menuName = "Event System/intGameEvent", order = 0)]
// public class IntGameEvent : ScriptableObject
// {
//     #region Private Variables
//     
//     private HashSet<IntGameEventListener> _listeners = new HashSet<IntGameEventListener>();
//     private int _value;
//     
//     #endregion
//     
//     #region Public Variables
//     
//     public int Value => _value;
//     #endregion
//
//     #region Main Functions
//     public void SubscribeToEvent(IntGameEventListener listener) => _listeners.Add(listener);
//
//     public void UnsubscribeFromEvent(IntGameEventListener listener) => _listeners.Remove(listener);
//
//     public void Raise(int value)
//     {
//         foreach (var gameEventListener in _listeners)
//         {
//             
//             gameEventListener.RaiseEvent(value);
//         }
//     }
//     
//     #endregion
//     
//     #region Utils
//
//     public void SetValue(int value)
//     {
//         _value = value;
//     }
//     #endregion
// }
//
// public class IntGameEventListener : MonoBehaviour
// {
//     [SerializeField] private IntGameEvent _event;
//     [SerializeField] private UnityEvent<int> _raised;
//
//     private void Awake()
//     {
//         _event.SubscribeToEvent(this);
//     }
//
//     private void OnDisable()
//     {
//         _event.UnsubscribeFromEvent(this);
//     }
//
//     public void RaiseEvent(int value)
//     {
//         _raised?.Invoke(value);
//     }
// }
