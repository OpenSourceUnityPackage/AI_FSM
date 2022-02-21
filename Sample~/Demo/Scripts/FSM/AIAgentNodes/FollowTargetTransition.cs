using FSMMono;
using UnityEngine;

public class FollowTargetTransition : StateCondition
{
    public override bool checkCondition(Object controller)
    {
        AIAgent target = controller as AIAgent;
        return target.GetTarget() != null;
    }
}