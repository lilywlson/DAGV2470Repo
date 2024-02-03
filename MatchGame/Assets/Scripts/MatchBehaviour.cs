using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContainerBehaviour
{
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if(tempObj == null) 
            return;

        var otherID = tempObj.idObj;
        if(otherID == idObj)
        {
            matchEvent.Invoke();
            Debug.Log("Matched");
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match");
        }

        // Debug.Log(idObj);
        // Debug.Log(other.GetComponent<IDContainerBehaviour>().idObj);
    }
}
