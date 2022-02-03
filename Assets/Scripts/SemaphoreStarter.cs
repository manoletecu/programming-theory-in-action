using UnityEngine;

public class SemaphoreStarter : MonoBehaviour
{
    void Start()
    {
        //ABSTRACTION
        FindObjectOfType<SemaphoreLight>().TurnOn();
    }    
}
