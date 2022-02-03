using System.Collections;
using UnityEngine;

//INHERITANCE
public class SemaphoreBlinkingLight : SemaphoreLight
{
    public float BlinkingTime = .5f;
    
    private Coroutine _blinkingLightCoroutine;

    //POLYMORPHISM
    public override void TurnOn()
    {
        base.TurnOn();
        _blinkingLightCoroutine = StartCoroutine(BlinkingLightCoroutine());
    }

    //POLYMORPHISM
    public override void TurnOff()
    {
        base.TurnOff();
        if(_blinkingLightCoroutine != null)
            StopCoroutine(_blinkingLightCoroutine);
    }

    IEnumerator BlinkingLightCoroutine()
    {
        while(true)
        {
            Light.intensity = 1f;
            yield return new WaitForSeconds(BlinkingTime);
            Light.intensity = .1f;
            yield return new WaitForSeconds(BlinkingTime);
        }
    }
}
