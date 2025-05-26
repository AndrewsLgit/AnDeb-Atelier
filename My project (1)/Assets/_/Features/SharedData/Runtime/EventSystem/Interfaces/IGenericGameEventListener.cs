
using UnityEngine;
using UnityEngine.Events;

public interface IGenericGameEventListener<T>
{
    //protected GameEvent _event;
    //protected UnityEvent<T> _raised;

    private void Awake()
    {
        throw new System.NotImplementedException();
    }

    private void OnDisable()
    {
        throw new System.NotImplementedException();
    }

    public void RaiseEvent(T t);
}