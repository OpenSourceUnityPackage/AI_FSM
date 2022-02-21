using FSMMono;
using UnityEngine;

public class Idle : StateBehaviour
{
    public override void OnEnter(Object controller)
    {
        AIAgent target = controller as AIAgent;
        target.SetWhiteMaterial();
    }
}
