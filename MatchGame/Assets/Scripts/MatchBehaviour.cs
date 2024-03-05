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
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Matched");
        }
        else
        {
            noMatchEvent.Invoke();
            Destroy(gameObject);
            Debug.Log("No Match");
            Debug.Log("GAME OVER!");
            // Time.timeScale = 0;
            // gameoverText.SetActive(true);
            // gameoverScreen.SetActive(true);
        }

        // Debug.Log(idObj);
        // Debug.Log(other.GetComponent<IDContainerBehaviour>().idObj);
    }
}
