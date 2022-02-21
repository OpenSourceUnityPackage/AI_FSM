using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class FSMController : MonoBehaviour
{
    public StateBehaviour startStateBehaviour;
    protected StateBehaviour currentStateBehaviour;
    public Object controller;

    private void Start()
    {
        currentStateBehaviour = startStateBehaviour;
        currentStateBehaviour.OnEnter(controller);
    }

    private void Update()
    {
        // Update current node
        currentStateBehaviour.OnUpdate(controller);
        
        // Check if condition is true to change state
        currentStateBehaviour = currentStateBehaviour.CheckConditions(controller);
    }
    
    
    private void OnEnable()
    {
        // Should invoke OnEnter ??
    }

    private void OnDisable()
    {
        // Should invoke OnExit ??
    }
}
