using FSMMono;
using UnityEngine;

public class StopFollowTargetTransition : StateCondition
{
    public override bool checkCondition(Object controller)
    {
        AIAgent target = controller as AIAgent;
        return target.GetTarget() == null || !target.IsTargetInView();
    }
}
