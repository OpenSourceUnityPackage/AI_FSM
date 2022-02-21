using FSMMono;
using UnityEngine;
using Object = UnityEngine.Object;

public class Patrol : StateBehaviour
{
    public GameObject path;
    int currentID = 0;
    
    public override void OnEnter(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.SetYellowMaterial();
        target.MoveTo(path.transform.GetChild(currentID).position);
    }

    public override void OnUpdate(Object controller)
    {
        AIAgent target = controller as AIAgent;
        
        if (target.HasReachedPos())
        {
            currentID++;

            if (currentID > path.transform.childCount - 1)
                currentID = 0;
            
            target.MoveTo(path.transform.GetChild(currentID).position);
        }
    }
    
    public override void OnExit(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.StopMove();
    }
}
