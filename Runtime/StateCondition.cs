using UnityEngine;
using Object = UnityEngine.Object;

[RequireComponent(typeof(StateBehaviour))]
public class StateCondition : MonoBehaviour
{
    public StateBehaviour to;
    
    public virtual bool checkCondition(Object controller)
    {
        return false;
    }

    private void OnEnable()
    {
        GetComponent<StateBehaviour>().RegisterStateCondition(this);
    }

    private void OnDisable()
    {
        GetComponent<StateBehaviour>().UnregisterStateCondition(this);
    }
}

