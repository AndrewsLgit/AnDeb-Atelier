using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEvent _event;
    [SerializeField] private UnityEvent _raised;

    private void Awake()
    {
        _event.SubscribeToEvent(this);
    }

    private void OnDisable()
    {
        _event.UnsubscribeFromEvent(this);
    }

    public void RaiseEvent()
    {
        _raised?.Invoke();
    }
}