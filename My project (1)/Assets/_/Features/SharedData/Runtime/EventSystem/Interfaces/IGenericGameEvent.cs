using System.Collections.Generic;
using _.Database.EventSystem.Abstract;

public interface IGenericGameEvent<T>
{
    /*#region Private Variables

    protected HashSet<IGenericGameEventListener> _listeners { get; set; }
    protected int _value;
    
    #endregion*/
    
    #region Public Variables
    
    public T Value { get; }
    #endregion

    #region Main Functions

    public void SubscribeToEvent(GenericGameEventListener<T> listener);

    public void UnsubscribeFromEvent(GenericGameEventListener<T> listener);

    public void Raise(T value);
    
    #endregion
    
    #region Utils

    public void SetValue(T value);

    #endregion
}
