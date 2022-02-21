using FSMMono;
using UnityEngine;

public class Chasse : StateBehaviour
{
    public override void OnEnter(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.SetRedMaterial();
    }
    
    public override void OnUpdate(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.MoveToTarget();
    }
    
    public override void OnExit(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.StopMove();
    }
}
