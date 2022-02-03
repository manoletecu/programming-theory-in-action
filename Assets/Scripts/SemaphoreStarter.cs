using UnityEngine;

public class SemaphoreStarter : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SemaphoreLight>().TurnOn();
    }    
}
