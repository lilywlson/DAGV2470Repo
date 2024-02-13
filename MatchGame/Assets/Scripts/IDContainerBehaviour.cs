using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;
    public GameObject gameoverText;
    public GameObject gameoverScreen;

    public void Start()
    {
        startEvent.Invoke();
        Time.timeScale = 1;
        gameoverText.SetActive(false);
        gameoverScreen.SetActive(false);
    }
}
