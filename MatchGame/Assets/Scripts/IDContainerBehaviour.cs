using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;
    // public GameObject gameoverText;
    // public GameObject gameoverScreen;

    public void Start()
    {
        startEvent.Invoke();
    }
}
