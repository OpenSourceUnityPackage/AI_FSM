using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[DisallowMultipleComponent]
public class StateBehaviour : MonoBehaviour
{
    protected List<StateCondition> stateConditions = new List<StateCondition>();

    public virtual void OnEnter(Object controller)
    {
        
    }

    public virtual void OnUpdate(Object controller)
    {
        
    }

    public virtual void OnExit(Object controller)
    {
        
    }

    public void RegisterStateCondition(StateCondition stateCondition)
    {
        if (!stateConditions.Contains(stateCondition))
            stateConditions.Add(stateCondition);
    }
    
    public void UnregisterStateCondition(StateCondition stateCondition)
    {
        stateConditions.Remove(stateCondition);
    }

    /// <summary>
    /// Check if condition change and process it's change. Return news node if it change
    /// </summary>
    /// <returns> Return the current stateBehaviour</returns>
    public StateBehaviour CheckConditions(Object controller)
    {
        foreach (StateCondition stateCondition in stateConditions)
        {
            if (stateCondition.checkCondition(controller))
            {
                OnExit(controller);
                stateCondition.to.OnEnter(controller);
                return stateCondition.to;
            }
        }

        return this;
    }
    
}
