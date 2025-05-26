using _.Database.EventSystem.Abstract;
using UnityEngine;

namespace _.Database.EventSystem
{
    [CreateAssetMenu(fileName = "New bool GameEvent", menuName = "Event System/bool GameEvent")]
    public class BoolGameEvent : GenericGameEvent<bool>
    {
        
    }
}