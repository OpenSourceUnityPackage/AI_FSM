using UnityEngine;

public class WaitTransition : StateCondition
{
    public float delayToChangeState = 2f;
    private float currentDelay = 0f;
    
    public override bool checkCondition(Object controller)
    {
        currentDelay += Time.deltaTime;

        if (currentDelay > delayToChangeState)
        {
            currentDelay = 0f;
            return true;
        }
        return false;
    }
}